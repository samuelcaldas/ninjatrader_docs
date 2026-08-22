#!/usr/bin/env python3
"""
tools/clean_tables.py

Cleans and standardizes markdown tables and legacy layout artifacts across the NinjaTrader 8 documentation:
1. Normalizes Release Notes tables by shifting real headers from row 1 to table header.
2. Removes ghost tables (0 data rows) and un-wraps layout wrapper tables.
3. Converts legacy Help & Manual toggle icons (tog_minus/tog_plus) into semantic markdown headings.
4. Standardizes parameter/property tables with semantic headers (| Parameter | Description |).
5. Cleans inline callout artifacts (| | --- | | Tip: -> > **Tip:**).
6. Fixes unlabeled code fences and adds syntax highlighting.
"""

import os
import re
import glob

REPO_ROOT = os.path.abspath(os.path.join(os.path.dirname(__file__), ".."))
DOCS_DIR = os.path.join(REPO_ROOT, "docs")

def clean_release_notes_tables(content):
    """Promotes real header rows in release notes to standard markdown headers."""
    lines = content.splitlines()
    new_lines = []
    i = 0
    while i < len(lines):
        line = lines[i]
        if line.startswith("|") and line.endswith("|") and i + 2 < len(lines):
            header = lines[i]
            sep = lines[i+1]
            first_row = lines[i+2]
            header_cells = [c.strip() for c in header.split("|")[1:-1]]
            first_cells = [c.strip() for c in first_row.split("|")[1:-1]]

            if all(c == "" for c in header_cells) and any(c in ["Issue #", "Feature #", "Status", "Category", "Comments"] for c in first_cells):
                col_count = len(first_cells)
                new_lines.append("| " + " | ".join(first_cells) + " |")
                new_lines.append("| " + " | ".join(["---"] * col_count) + " |")
                i += 3
                continue
        new_lines.append(line)
        i += 1
    return "\n".join(new_lines)

def clean_toggles_and_callouts(content):
    """Converts toggle image markers into headings and extracts inline callouts."""
    # 1. Transform tog_minus / tog_plus followed by heading text on same line
    def repl_tog_heading(m):
        heading_text = m.group(1).strip()
        return f"\n## {heading_text}\n"

    content = re.sub(r'^[ \t]*!\[tog_[^\]]*\]\([^)]+\)[ \t]+(.+)$', repl_tog_heading, content, flags=re.MULTILINE)

    # 2. Remove standalone tog_minus / tog_plus lines
    content = re.sub(r'^[ \t]*!\[tog_[^\]]*\]\([^)]+\)[ \t]*\n+', '', content, flags=re.MULTILINE)

    # 3. Clean inline callout table artifacts: | | --- | | Note: ... |
    def repl_inline_callout(m):
        callout_type = m.group(1).capitalize()
        text = m.group(2).strip()
        return f"\n\n> **{callout_type}:** {text}\n\n"

    content = re.sub(r'\|\s*\|\s*---\s*\|\s*\|\s*(Note|Tip|Warning):\s*([^|]+)\|', repl_inline_callout, content, flags=re.IGNORECASE)

    # 4. Handle collapsed multi-row key-value table embedded in single cell (e.g. sharpdx_color.md)
    def repl_collapsed_colors(m):
        raw = m.group(0)
        pairs = re.findall(r'\|\s*([^|\n]+?)\s*\|\s*([^|\n]+?)\s*(?=\|)', raw)
        valid_pairs = []
        for k, v in pairs:
            if k == '---' or v == '---' or not k.strip() or not v.strip():
                continue
            if k.strip() in ['Name / Option', 'Parameter', 'Property']:
                continue
            valid_pairs.append((k.strip(), v.strip()))

        if len(valid_pairs) > 5:
            res_lines = ['\n| Color Constant / Option | Description |', '| --- | --- |']
            for k, v in valid_pairs:
                res_lines.append(f'| {k} | {v} |')
            return '\n' + '\n'.join(res_lines) + '\n'
        return raw

    content = re.sub(r'(\|\s*Colors by name[^\n]+)', repl_collapsed_colors, content)

    return content

def unwrap_layout_and_ghost_tables(content):
    """Unwraps layout tables and removes ghost tables with 0 data rows."""
    lines = content.splitlines()
    new_lines = []
    i = 0
    while i < len(lines):
        line = lines[i]
        if line.strip().startswith('|') and line.strip().endswith('|') and i + 1 < len(lines):
            header_cells = [c.strip() for c in line.split('|')[1:-1]]
            sep_line = lines[i+1]
            sep_cells = [c.strip() for c in sep_line.split('|')[1:-1]]

            is_empty_header = all(c == '' for c in header_cells) and len(header_cells) >= 1
            is_sep = all(set(c).issubset({'-', ':', ' '}) and c != '' for c in sep_cells) and len(sep_cells) == len(header_cells)

            if is_empty_header and is_sep:
                table_rows = []
                j = i + 2
                while j < len(lines) and lines[j].strip().startswith('|'):
                    row_cells = [c.strip() for c in lines[j].split('|')[1:-1]]
                    table_rows.append((lines[j], row_cells))
                    j += 1

                # 0 data rows -> ghost table
                if len(table_rows) == 0:
                    i = j
                    continue

                # Multi-column or layout wrapper containing paragraphs
                is_layout = any(any(len(cell) > 60 for cell in r_cells) for _, r_cells in table_rows) or len(header_cells) >= 3
                if is_layout:
                    for raw_row, r_cells in table_rows:
                        for cell in r_cells:
                            if cell:
                                new_lines.append('')
                                new_lines.append(cell)
                    new_lines.append('')
                    i = j
                    continue

        new_lines.append(line)
        i += 1
    return "\n".join(new_lines)

def standardize_param_property_headers(content):
    """Replaces empty 2-column table headers with semantic names."""
    def repl_param(m):
        return m.group(1) + "| Parameter | Description |\n| --- | --- |\n"
    content = re.sub(r'(## Parameters\s*\n\s*)\|\s*\|\s*\|\s*\n\|\s*---\s*\|\s*---\s*\n', repl_param, content)

    def repl_prop(m):
        return m.group(1) + "| Property | Description |\n| --- | --- |\n"
    content = re.sub(r'(## Property Value\s*\n\s*)\|\s*\|\s*\|\s*\n\|\s*---\s*\|\s*---\s*\n', repl_prop, content)

    lines = content.splitlines()
    new_lines = []
    i = 0
    while i < len(lines):
        line = lines[i]
        if line.strip() == "|  |  |" and i + 1 < len(lines) and lines[i+1].strip() == "| --- | --- |":
            if i + 2 < len(lines) and lines[i+2].strip().startswith("|"):
                new_lines.append("| Name / Option | Description |")
                new_lines.append("| --- | --- |")
                i += 2
                continue
        new_lines.append(line)
        i += 1
    return "\n".join(new_lines)

def fix_code_fences(content):
    """Ensures code blocks have proper syntax highlighting."""
    def repl_fence(m):
        lang = m.group(1)
        code = m.group(2)
        if not lang:
            code_strip = code.strip()
            if any(k in code_strip for k in ["void ", "public ", "private ", "protected ", "override ", "double ", "int ", "string ", "class ", "using System", "new "]):
                return "```csharp\n" + code + "```"
            elif "<" in code_strip and ">" in code_strip and any(tag in code_strip for tag in ["<NinjaTrader", "<xml", "<Window", "<Grid", "<Style", "<?xml"]):
                return "```xml\n" + code + "```"
            else:
                return "```text\n" + code + "```"
        return m.group(0)

    pattern = r'```(\w*)\n(.*?)```'
    content = re.sub(pattern, repl_fence, content, flags=re.DOTALL)
    content = re.sub(r'\n{3,}', '\n\n', content)
    return content

def clean_all_docs():
    all_docs = glob.glob(os.path.join(DOCS_DIR, "**/*.md"), recursive=True)
    all_docs.append(os.path.join(REPO_ROOT, "README.md"))

    cleaned_files = 0
    for doc in all_docs:
        with open(doc, "r", encoding="utf-8", errors="ignore") as f:
            orig = f.read()

        s1 = clean_release_notes_tables(orig)
        s2 = clean_toggles_and_callouts(s1)
        s3 = unwrap_layout_and_ghost_tables(s2)
        s4 = standardize_param_property_headers(s3)
        s5 = fix_code_fences(s4)

        if s5 != orig:
            with open(doc, "w", encoding="utf-8") as f:
                f.write(s5)
            cleaned_files += 1

    print(f"Standardized and cleaned {cleaned_files}/{len(all_docs)} documentation files.")

if __name__ == "__main__":
    clean_all_docs()
