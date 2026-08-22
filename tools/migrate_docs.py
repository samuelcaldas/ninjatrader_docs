#!/usr/bin/env python3
"""
NinjaTrader 8 Documentation Migration, Cleaning, and Standardization Script.

Transforms legacy converted markdown into standardized, clean Markdown:
1. Strips legacy navigation tables and converts top document titles to # Title (H1).
2. Converts | ns |, | C# |, | XAML |, and code tables into fenced ```csharp / ```xaml blocks.
3. Converts callout tables into standard markdown blockquotes (> **Note:** ...).
4. Cleans HTML entities (&nbsp;, &lt;, &gt;, &amp;), <font>, <span>, <div>, <br>.
5. Normalizes • bullet points to markdown list items (- ).
6. Converts Setext headings (Heading\\n---) to ATX (## Heading).
7. Wraps generic types (ISeries<double>, Series<T>, etc.) and syntax lines in backticks.
8. Repairs broken local links (Windows backslashes, -1.md legacy links, .htm extensions, renamed files).
9. Normalizes code fences to ensure valid matching pairs across all documents.
10. Ensures clean whitespace, single trailing newline, and full idempotency.
"""

import os
import sys
import glob
import re
from pathlib import Path

RENAME_MAP = {
    "alert_rearmalert().md": "alert_rearmalert.md",
    "chartbars_tochartstring().md": "chartbars_tochartstring.md",
    "draw_pathtool().md": "draw_pathtool.md",
    "ntmessageboxsimple_show().md": "ntmessageboxsimple_show.md",
    "propagateinstrumentchange().md": "propagateinstrumentchange.md",
    "propagateintervalchange().md": "propagateintervalchange.md",
    "commitment-of-traders-(cot).md": "commitment_of_traders_cot.md",
    "creating-chart-wpf-(ui)-modifi.md": "creating_chart_wpf_ui_modifications.md",
    "NT HelpGuide English.md": "welcome.md",
    "NT HelpGuide English-2.md": "welcome.md",
    "NT HelpGuide English-3.md": "welcome.md",
    # Truncated link targets due to parenthesis export bugs
    "alert_rearmalert(": "alert_rearmalert.md",
    "chartbars_tochartstring(": "chartbars_tochartstring.md",
    "draw_pathtool(": "draw_pathtool.md",
    "ntmessageboxsimple_show(": "ntmessageboxsimple_show.md",
    "propagateinstrumentchange(": "propagateinstrumentchange.md",
    "propagateintervalchange(": "propagateintervalchange.md",
    "commitment-of-traders-(cot": "commitment_of_traders_cot.md",
    "creating-chart-wpf-(ui": "creating_chart_wpf_ui_modifications.md",
    "creating-chart-wpf-(ui)-modifi": "creating_chart_wpf_ui_modifications.md",
    # Known alias targets
    "order-flow-delta-bars.md": "order_flow_volumetric_bars.md",
    "%3C%25CONNECTIONGUIDE%25%3E": "connecting_to_youraccount.md",
    "<%CONNECTIONGUIDE%>": "connecting_to_youraccount.md",
}

GENERIC_PATTERN = re.compile(
    r'(?<![`\w])(ISeries|Series|List|Dictionary|HashSet|Collection|Nullable|KeyValuePair|Tuple|Action|Func|EventHandler|IReadOnlyList|ArraySegment)<([A-Za-z0-9_,\s]+)>(?![`\w])'
)

CODE_KEYWORDS = [
    'protected override', 'public class', 'private void', 'public void', 'public override',
    'OnBarUpdate', 'OnStateChange', 'OnRender', 'AddDataSeries', 'Draw.', 'Print(',
    'State == State', 'BarsInProgress', 'CurrentBar', 'AddPlot', 'AddLine',
    'SimpleFont', 'ChartControl', 'SystemPerformance', 'AddChartIndicator',
    'BarsArray', 'Instrument.', 'BarsPeriod', 'OrderFillResolution',
    'AccountSelector', 'AtmStrategy', 'LogicalTreeHelper', 'Brushes.',
    'DashStyleHelper', 'PlotStyle', 'Series<', 'ISeries<'
]


def format_csharp_code(code_str: str) -> str:
    """Format flattened C# code into readable indented lines."""
    raw = code_str.replace(r'\|', '|').replace('\xa0', ' ')
    raw = raw.replace('&lt;', '<').replace('&gt;', '>').replace('&amp;', '&')

    raw_lines = []
    for chunk in raw.split('\n'):
        parts = [p.strip() for p in re.split(r' {2,}', chunk) if p.strip()]
        raw_lines.extend(parts)

    indent_level = 0
    formatted = []
    for line in raw_lines:
        line = line.strip()
        if not line:
            continue

        match_close = re.match(r'^\}+', line)
        leading_closes = len(match_close.group(0)) if match_close else 0
        current_indent = max(0, indent_level - leading_closes)

        formatted.append('    ' * current_indent + line)

        opens = line.count('{')
        closes = line.count('}')
        indent_level = max(0, indent_level + opens - closes)

    return '\n'.join(formatted)


def format_xaml_code(xaml_str: str) -> str:
    """Format XAML code string."""
    raw = xaml_str.replace(r'\|', '|').replace('\xa0', ' ')
    raw = raw.replace('&lt;', '<').replace('&gt;', '>').replace('&amp;', '&')
    raw = re.sub(r'<Pagexmlns=', '<Page xmlns=', raw)
    lines = [p.strip() for p in re.split(r' {2,}|\n', raw) if p.strip()]
    return '\n'.join(lines)


def clean_navigation_header(text: str) -> str:
    """Strip the entire legacy navigation table and ensure top level # Title."""
    text = text.lstrip('﻿')

    nav_table_re = re.compile(
        r'^(.*?)\n*\|\s*\|\s*\|\n\|\s*---\s*\|\s*---\s*\|\n\|[^\n]*<<\s*\[Click to Display Table of Contents\].*?\|\s*(?:\n+|$)',
        re.DOTALL
    )

    m = nav_table_re.match(text)
    if m:
        pre_title = m.group(1).strip()
        rest = text[m.end():].lstrip()
        if pre_title:
            title_clean = pre_title.lstrip('#').strip()
            title_line = [l.strip() for l in title_clean.split('\n') if l.strip()][0]
            text = f"# {title_line}\n\n{rest}"
        else:
            text = rest

    text = re.sub(
        r'^\|\s*<<\s*\[Click to Display Table of Contents\].*?\|\s*\n*',
        '',
        text,
        flags=re.MULTILINE
    )

    return text


def extract_and_format_code_tables(text: str) -> str:
    """Convert | ns |, | C# |, | XAML |, and other single-column/multi-column code tables to fenced blocks."""

    # 1. Inline or multi-column ns table markers: | ns ... | ... | --- ... | ... |
    p_inline = re.compile(
        r'\|\s*ns\b[^|\n]*\|(?:[^|\n]*\|)*\s*---+[^|\n]*\|(?:[^|\n]*\|)*\s*',
        re.IGNORECASE
    )
    text = p_inline.sub('\n\n```csharp\n', text)

    # 2. Multiline ns header: | ns ... |\n| --- ... |\n|
    p_multi = re.compile(
        r'^[ \t]*\|[ \t]*ns\b[^|\n]*\|[^\n]*\n+[ \t]*\|[ \t]*---+[^\n]*\n+[ \t]*\|[ \t]*',
        re.IGNORECASE | re.MULTILINE
    )
    text = p_multi.sub('\n\n```csharp\n', text)

    # 3. Convert free-standing | ns\n
    text = re.sub(
        r'^[ \t]*\|[ \t]*ns[ \t]*\n',
        '\n\n```csharp\n',
        text,
        flags=re.IGNORECASE | re.MULTILINE
    )

    # 4. Standard single-column tables
    def repl_table(m):
        header = m.group(1).strip()
        body = m.group(2).strip()

        lines = body.split('\n')
        cell_contents = []
        for line in lines:
            line = line.strip()
            if line.startswith('|'):
                line = line[1:]
            if line.endswith('|'):
                line = line[:-1]
            line = line.strip()
            if line:
                cell_contents.append(line)

        full_content = '  '.join(cell_contents)
        clean_content = full_content.replace('\xa0', ' ').strip()

        if header.upper() == 'XAML' or 'XAML' in header or clean_content.startswith('<Page') or clean_content.startswith('<Grid'):
            xaml_formatted = format_xaml_code(clean_content)
            title_comment = f"<!-- {header} -->\n" if header and header.upper() != 'XAML' and not header.startswith('ns') else ""
            return f"```xaml\n{title_comment}{xaml_formatted}\n```"

        is_code = (
            header.lower().startswith('ns') or
            header.upper() == 'C#' or
            'C#' in header or
            any(kw in clean_content for kw in CODE_KEYWORDS) or
            clean_content.startswith('//') or
            clean_content.startswith('protected') or
            clean_content.startswith('public')
        )

        for prefix in ("Note:", "Notes:", "Warning:", "Warnings:", "Tip:", "Tips:", "Critical:", "Important:", "Disclaimer:"):
            if clean_content.startswith(prefix):
                rest = clean_content[len(prefix):].strip()
                return f"> **{prefix}** {rest}\n"

        if clean_content.startswith("Attention"):
            if ':' in clean_content:
                h, t = clean_content.split(':', 1)
                return f"> **{h.strip()}:** {t.strip()}\n"
            return f"> **{clean_content}**\n"

        if is_code:
            code_formatted = format_csharp_code(clean_content)
            title_comment = f"// {header}\n" if header and header.lower() != 'ns' and header.upper() != 'C#' and not header.startswith('ns') else ""
            return f"```csharp\n{title_comment}{code_formatted}\n```"

        if not header:
            return f"> {clean_content}\n"

        return f"> **{header}**\n> {clean_content}\n"

    text = re.sub(
        r'\|([^\n|]*)\|\n\|\s*---+\s*\|\n((?:\|[^\n]*\|\n?)+)',
        repl_table,
        text
    )

    return text


def clean_headings_and_structure(text: str) -> str:
    """Convert Setext headings to ATX headings and normalize sections."""
    text = re.sub(
        r'(?i)\bSyntax\s*\n+([^\n]+)\n+[-=]{3,}',
        r'## Syntax\n\n`\1`',
        text
    )

    lines = text.split('\n')
    new_lines = []
    i = 0
    in_code_block = False

    while i < len(lines):
        line = lines[i]
        stripped = line.strip()

        if stripped.startswith('```'):
            in_code_block = not in_code_block
            new_lines.append(line)
            i += 1
            continue

        if in_code_block:
            new_lines.append(line)
            i += 1
            continue

        if i + 1 < len(lines):
            next_line = lines[i + 1].strip()
            if stripped and not stripped.startswith('|') and not stripped.startswith('#') and not stripped.startswith('>') and not stripped.startswith('-') and not stripped.startswith('*'):
                if re.match(r'^-{3,}\s*$', next_line):
                    if stripped.lower() == 'syntax' or stripped.lower().startswith('syntax'):
                        new_lines.append("## Syntax")
                    else:
                        new_lines.append(f"## {stripped}")
                    i += 2
                    continue
                elif re.match(r'^={3,}\s*$', next_line):
                    new_lines.append(f"# {stripped}")
                    i += 2
                    continue

        new_lines.append(line)
        i += 1

    return '\n'.join(new_lines)


def clean_html_and_formatting(text: str) -> str:
    """Clean HTML tags, entities, bullets, and protect generic types."""
    lines = text.split('\n')
    new_lines = []
    in_code_block = False

    for line in lines:
        if line.strip().startswith('```'):
            in_code_block = not in_code_block
            new_lines.append(line)
            continue

        if in_code_block:
            new_lines.append(line)
            continue

        l = line

        l = l.replace('\xa0', ' ').replace('&nbsp;', ' ')

        l = re.sub(r'^\s*•\s*', '- ', l)
        l = re.sub(r'\s+•\s*', '\n- ', l)

        l = re.sub(r'</?(?:font|span|div)[^>]*>', '', l, flags=re.IGNORECASE)
        l = re.sub(r'<br\s*/?>', '  \n', l, flags=re.IGNORECASE)
        l = re.sub(r'<b>(.*?)</b>', r'**\1**', l, flags=re.IGNORECASE)
        l = re.sub(r'<strong>(.*?)</strong>', r'**\1**', l, flags=re.IGNORECASE)
        l = re.sub(r'<i>(.*?)</i>', r'*\1*', l, flags=re.IGNORECASE)
        l = re.sub(r'<em>(.*?)</em>', r'*\1*', l, flags=re.IGNORECASE)

        def wrap_generic(m):
            return f"`{m.group(0)}`"

        parts = l.split('`')
        for idx in range(0, len(parts), 2):
            parts[idx] = GENERIC_PATTERN.sub(wrap_generic, parts[idx])
        l = '`'.join(parts)

        new_lines.append(l)

    return '\n'.join(new_lines)


def repair_links(text: str, current_file: str, all_md_files: set, all_images: set) -> str:
    """Repair broken links, Windows backslashes, -1.md, and renamed paths."""

    def replace_link(m):
        link_text = m.group(1)
        raw_dest = m.group(2).strip()

        title_part = ""
        dest = raw_dest
        if ' "' in raw_dest and raw_dest.endswith('"'):
            dest, title = raw_dest.rsplit(' "', 1)
            title_part = f' "{title}'
        elif " '" in raw_dest and raw_dest.endswith("'"):
            dest, title = raw_dest.rsplit(" '", 1)
            title_part = f" '{title}"

        if "/cdn-cgi/l/email-protection" in dest:
            if "sale" in link_text.lower():
                return f"[{link_text}](mailto:sales@ninjatrader.com{title_part})"
            return f"[{link_text}](mailto:support@ninjatrader.com{title_part})"

        if dest.startswith(("http://", "https://", "mailto:", "#", "javascript:")):
            return m.group(0)

        # Fix MSDN or external domains missing protocol
        if dest.startswith("msdn.microsoft.com") or dest.startswith("www."):
            return f"[{link_text}](https://{dest}{title_part})"

        anchor = ""
        if "#" in dest:
            dest, anchor_val = dest.split("#", 1)
            anchor = "#" + anchor_val

        clean = dest.replace('\\', '/')
        if clean.startswith('./'):
            clean = clean[2:]

        if clean in RENAME_MAP:
            clean = RENAME_MAP[clean]

        if clean in all_md_files or clean in all_images:
            return f"[{link_text}]({clean}{anchor}{title_part})"

        if clean.endswith('.htm') or clean.endswith('.html'):
            stem = clean.rsplit('.', 1)[0]
            if (stem + '.md') in all_md_files:
                return f"[{link_text}]({stem}.md{anchor}{title_part})"

        if clean.endswith('-1.md'):
            stem = clean[:-5]
            if (stem + '.md') in all_md_files:
                return f"[{link_text}]({stem}.md{anchor}{title_part})"

        if (clean + '.md') in all_md_files:
            return f"[{link_text}]({clean}.md{anchor}{title_part})"

        return f"[{link_text}]({clean}{anchor}{title_part})"

    text = re.sub(r'\[([^\]]*)\]\(([^)\n]+)\)', replace_link, text)
    return text


def normalize_code_fences(text: str) -> str:
    """Normalize and fix broken, double, or unclosed code block fences."""
    # 1. Remove empty code block fences: ```csharp\n``` or ```\n```
    text = re.sub(r'```[a-zA-Z0-9_-]*\s*\n\s*```\s*\n?', '', text)

    # 2. Fix consecutive fences: ```\n```csharp -> ```csharp
    text = re.sub(r'```[a-zA-Z0-9_-]*\s*\n+```([a-zA-Z0-9_-]+)', r'```\1', text)
    text = re.sub(r'```\s*\n+```', '', text)

    # 3. Fix misplaced closing fences right inside code blocks followed by C# code
    lines = text.split('\n')
    new_lines = []
    in_code = False

    for i, line in enumerate(lines):
        stripped = line.strip()
        if stripped.startswith('```'):
            if not in_code:
                in_code = True
                new_lines.append(line)
            else:
                rest = [l.strip() for l in lines[i+1:min(len(lines), i+8)] if l.strip()]
                is_continuation = False
                if rest and any(
                    rest[0].startswith(kw) for kw in [
                        '#region', '#endregion', '[Range', '[NinjaScriptProperty',
                        '[Display', '[Browsable', '[XmlIgnore', 'public', 'protected',
                        'private', 'get;', 'set;', '{', '}', '//'
                    ]
                ):
                    is_continuation = True

                if is_continuation:
                    continue
                else:
                    in_code = False
                    new_lines.append('```')
        else:
            new_lines.append(line)

    if in_code:
        new_lines.append('```')

    res = '\n'.join(new_lines)
    res = re.sub(r'```\s*\n+```', '', res)
    return res


def repair_specific_damaged_files(content: str, filename: str) -> str:
    """Special handling for known corrupted files like adding_indicators_to_strategie.md."""
    if filename == "adding_indicators_to_strategie.md":
        return """# Adding Indicators to Strategies

When backtesting strategies it can be useful to add the indicators you use for calculations onto the chart to make it easier to check your strategy for accuracy. Instead of doing this step manually every time you run the strategy you can program it to automatically load the indicators for you.

## Example

To add a volume indicator to your charts you need to add this code snippet into the [OnStateChange](onstatechange.md) section of your code for the State: `State.DataLoaded`:

```csharp
protected override void OnStateChange()
{
    if (State == State.DataLoaded)
    {
        AddChartIndicator(VOL());
    }
}
```

To choose which panel you want your indicator plotted on you can use this code snippet in `State.DataLoaded`:

```csharp
VOL().Panel = 1;
AddChartIndicator(VOL());
```

To customize plot colors:

```csharp
VOL().Plots[0].Brush = Brushes.Red;
```

To customize plot width:

```csharp
VOL().Plots[0].Width = 4;
```

To customize the plot dash style:

```csharp
VOL().Plots[0].DashStyleHelper = DashStyleHelper.Dash;
```

To customize the plot style:

```csharp
VOL().Plots[0].PlotStyle = PlotStyle.Bar;
VOL().Plots[0].IsOverlay = true;
```

To customize lines you can do it the same way as above:

```csharp
RSI(14, 3).Lines[0].Brush = Brushes.Green;
```

Remember, you need to use the [AddChartIndicator()](addchartindicator.md) method to add your indicator if you wish to use any of the plot / line indicator customization examples.
"""
    return content


def transform_document(content: str, filename: str, all_md_files: set, all_images: set) -> str:
    """Execute complete transformation pipeline on a single document."""
    repaired = repair_specific_damaged_files(content, filename)
    if repaired != content:
        return repaired.strip() + '\n'

    # 1. Clean navigation header and ensure # Title
    text = clean_navigation_header(content)

    # 2. Extract and format code tables (| ns |, | C# |, | XAML |)
    text = extract_and_format_code_tables(text)

    # 3. Clean headings (Setext -> ATX)
    text = clean_headings_and_structure(text)

    # 4. Clean HTML and formatting
    text = clean_html_and_formatting(text)

    # 5. Repair links
    text = repair_links(text, filename, all_md_files, all_images)

    # 6. Normalize code fences
    text = normalize_code_fences(text)

    # 7. Normalize consecutive blank lines (max 2 newlines = 1 blank line)
    text = re.sub(r'\n{3,}', '\n\n', text)

    # 8. Ensure single trailing newline
    text = text.strip() + '\n'

    return text


def main():
    root_dir = Path(".")
    md_files = sorted([f.name for f in root_dir.glob("*.md")])
    image_files = set([f.name for f in (list(root_dir.glob("*.png")) + list(root_dir.glob("*.jpg")) + list(root_dir.glob("*.gif")) + list(root_dir.glob("*.svg")))])
    all_md_set = set(md_files)

    print(f"Starting migration across {len(md_files)} markdown files...")

    changed_count = 0
    for filename in md_files:
        filepath = root_dir / filename
        with open(filepath, "r", encoding="utf-8", errors="ignore") as f:
            original = f.read()

        transformed = transform_document(original, filename, all_md_set, image_files)

        if transformed != original:
            with open(filepath, "w", encoding="utf-8") as f:
                f.write(transformed)
            changed_count += 1

    print(f"Migration complete! Modified {changed_count} / {len(md_files)} files.")


if __name__ == "__main__":
    main()
