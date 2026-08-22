#!/usr/bin/env python3
"""
tools/html_to_markdown_converter.py

Direct high-fidelity converter using Python standard library (html.parser) from
Help & Manual HTML (support/helpguides/nt8/*.htm) to clean GitHub-flavored Markdown.
"""

import os
import re
import glob
import subprocess
from html.parser import HTMLParser
from html import unescape

REPO_ROOT = os.path.abspath(os.path.join(os.path.dirname(__file__), ".."))
DOCS_DIR = os.path.join(REPO_ROOT, "docs")
IMAGES_DIR = os.path.join(DOCS_DIR, "images")

NAV_ICONS = {
    "leftarrow.png", "uparrow.png", "rightarrow.png",
    "leftarrow-1.png", "uparrow-1.png", "rightarrow-1.png",
    "warning_bar_0000_us.jpg", "tog_plus.gif", "tog_minus.gif",
    "zoom_minus.gif", "zoom_plus.gif", "return_arrow.png",
    "collapse.png", "expand.png", "hm_winarrow.gif", "top_menu.png",
    "link_arrow.png", "p_toggleheading.png"
}

def build_topic_maps():
    md_files = glob.glob(os.path.join(DOCS_DIR, "**/*.md"), recursive=True)
    topic_map = {}
    for f in md_files:
        base = os.path.splitext(os.path.basename(f))[0].lower()
        rel_from_docs = os.path.relpath(f, DOCS_DIR)
        parts = rel_from_docs.split(os.sep)
        cat = parts[0] if len(parts) > 1 else ""
        topic_map[base] = {
            "abs_path": f,
            "rel_path": rel_from_docs,
            "category": cat,
            "filename": os.path.basename(f)
        }
    return topic_map

TOPIC_MAP = build_topic_maps()

def resolve_href(href, current_cat):
    if not href:
        return ""
    if href.startswith("http://") or href.startswith("https://") or href.startswith("mailto:"):
        return href
    if href.startswith("javascript:"):
        return ""

    parts = href.split("#")
    file_part = parts[0]
    anchor = f"#{parts[1]}" if len(parts) > 1 else ""

    if not file_part:
        return anchor

    base = os.path.splitext(os.path.basename(file_part))[0].lower()
    if base in TOPIC_MAP:
        target = TOPIC_MAP[base]
        if target["category"] == current_cat:
            return f"{target['filename']}{anchor}"
        else:
            return f"../{target['category']}/{target['filename']}{anchor}"

    return f"{file_part.replace('.htm', '.md')}{anchor}"

class HtmlToMarkdownParser(HTMLParser):
    def __init__(self, current_cat):
        super().__init__()
        self.current_cat = current_cat
        self.output = []
        self.tag_stack = []
        self.in_script_or_style = False
        self.in_topichead = False
        self.in_pre = False
        self.pre_buffer = []
        self.list_stack = [] # ('ul'|'ol', count)
        self.table_stack = [] # list of rows; row = list of cell contents
        self.current_cell = None
        self.in_note_table = False
        self.note_type = "Note"
        self.note_buffer = []

    def handle_starttag(self, tag, attrs):
        attrs_dict = dict(attrs)
        classes = attrs_dict.get("class", "").split()

        if tag in ["script", "style", "noscript", "iframe"]:
            self.in_script_or_style = True
            return

        if attrs_dict.get("id") == "topichead" or "topichead" in classes:
            self.in_topichead = True
            return

        if self.in_script_or_style or self.in_topichead:
            return

        self.tag_stack.append((tag, attrs_dict))

        # Check for Note / Callout tables
        if tag == "table" and any(c in ["Note", "Tip", "Warning", "Critical"] for c in classes):
            for c in ["Note", "Tip", "Warning", "Critical"]:
                if c in classes:
                    self.in_note_table = True
                    self.note_type = c
                    self.note_buffer = []
                    return

        # Check for code blocks
        if tag == "pre" or (tag == "div" and any("code" in c.lower() for c in classes)):
            self.in_pre = True
            self.pre_buffer = []
            return

        # Headings
        if tag in ["h1", "h2", "h3", "h4", "h5", "h6"]:
            lvl = int(tag[1])
            self.output.append(f"\n\n{'#' * lvl} ")
            return

        # Toggle Headings (Help & Manual)
        if "p_ToggleHeading" in classes or "p_ToggleHeading1" in classes or "p_ToggleHeading2" in classes:
            self.output.append("\n\n## ")
            return

        # Paragraphs & Divs
        if tag in ["p", "div"]:
            self.output.append("\n\n")
            return

        # Line break
        if tag == "br":
            self.output.append("\n")
            return

        # Lists
        if tag == "ul":
            self.list_stack.append(("ul", 0))
            self.output.append("\n")
            return
        if tag == "ol":
            self.list_stack.append(("ol", 1))
            self.output.append("\n")
            return
        if tag == "li":
            if self.list_stack:
                ltype, count = self.list_stack[-1]
                indent = "  " * (len(self.list_stack) - 1)
                if ltype == "ul":
                    self.output.append(f"\n{indent}- ")
                else:
                    self.output.append(f"\n{indent}{count}. ")
                    self.list_stack[-1] = (ltype, count + 1)
            else:
                self.output.append("\n- ")
            return

        # Tables
        if tag == "table":
            self.table_stack.append([])
            return
        if tag == "tr":
            if self.table_stack:
                self.table_stack[-1].append([])
            return
        if tag in ["td", "th"]:
            self.current_cell = []
            return

        # Inlines
        if tag in ["b", "strong"]:
            self.output.append("**")
        elif tag in ["i", "em"]:
            self.output.append("*")
        elif tag in ["code", "tt"]:
            self.output.append("`")
        elif tag == "a":
            href = attrs_dict.get("href", "")
            self.output.append("[")
        elif tag == "img":
            src = attrs_dict.get("src", "")
            img_name = os.path.basename(src).lower()
            if img_name not in NAV_ICONS and not any(x in img_name for x in ["tog_", "zoom_", "arrow"]):
                alt = attrs_dict.get("alt", os.path.splitext(img_name)[0].replace("_", " ").title())
                img_md = f"\n\n![{alt}](../images/{img_name})\n\n"
                if self.in_note_table:
                    self.note_buffer.append(img_md)
                elif self.current_cell is not None:
                    self.current_cell.append(img_md)
                else:
                    self.output.append(img_md)

    def handle_endtag(self, tag):
        if tag in ["script", "style", "noscript", "iframe"]:
            self.in_script_or_style = False
            return

        if self.in_topichead:
            if tag == "table" or tag == "div":
                self.in_topichead = False
            return

        if self.in_script_or_style or self.in_topichead:
            return

        # End pre / code block
        if tag == "pre" or self.in_pre:
            if tag == "pre" or tag == "div":
                self.in_pre = False
                code_text = "".join(self.pre_buffer).strip()
                lang = "csharp"
                if "<" in code_text and ">" in code_text and any(x in code_text for x in ["<NinjaTrader", "<Window", "<Grid", "<xml"]):
                    lang = "xml"
                self.output.append(f"\n\n```{lang}\n{code_text}\n```\n\n")
                return

        # End Note Table
        if self.in_note_table and tag == "table":
            self.in_note_table = False
            note_txt = "".join(self.note_buffer).strip()
            note_txt = re.sub(rf'^{self.note_type}:\s*', '', note_txt, flags=re.IGNORECASE)
            self.output.append(f"\n\n> **{self.note_type}:** {note_txt}\n\n")
            return

        # Inlines closing
        if tag in ["b", "strong"]:
            self.output.append("**")
        elif tag in ["i", "em"]:
            self.output.append("*")
        elif tag in ["code", "tt"]:
            self.output.append("`")
        elif tag == "a":
            # get href from stack
            href = ""
            for t, a in reversed(self.tag_stack):
                if t == "a":
                    href = a.get("href", "")
                    break
            resolved = resolve_href(href, self.current_cat)
            self.output.append(f"]({resolved})")
        elif tag in ["ul", "ol"]:
            if self.list_stack:
                self.list_stack.pop()
            self.output.append("\n")
        elif tag in ["td", "th"]:
            if self.current_cell is not None and self.table_stack and self.table_stack[-1]:
                cell_text = "".join(self.current_cell).strip().replace("\n", "<br>")
                self.table_stack[-1][-1].append(cell_text)
            self.current_cell = None
        elif tag == "table":
            if self.table_stack:
                rows = self.table_stack.pop()
                # Render table
                if rows:
                    max_cols = max(len(r) for r in rows) if rows else 0
                    if max_cols > 0:
                        header = rows[0]
                        while len(header) < max_cols:
                            header.append("")
                        if all(h == "" for h in header):
                            header = ["Parameter / Name", "Description"] if max_cols == 2 else [f"Column {i+1}" for i in range(max_cols)]

                        t_md = ["\n| " + " | ".join(header) + " |", "| " + " | ".join(["---"] * max_cols) + " |"]
                        for r in rows[1:]:
                            while len(r) < max_cols:
                                r.append("")
                            t_md.append("| " + " | ".join(r) + " |")
                        self.output.append("\n" + "\n".join(t_md) + "\n\n")

        if self.tag_stack and self.tag_stack[-1][0] == tag:
            self.tag_stack.pop()

    def handle_data(self, data):
        if self.in_script_or_style or self.in_topichead:
            return
        if self.in_pre:
            self.pre_buffer.append(data)
            return
        if self.in_note_table:
            self.note_buffer.append(data)
            return
        if self.current_cell is not None:
            self.current_cell.append(data)
            return

        self.output.append(data)

    def get_markdown(self):
        text = "".join(self.output)
        # Normalization
        text = re.sub(r'\n{3,}', '\n\n', text)
        text = re.sub(r'[ \t]+$', '', text, flags=re.MULTILINE)
        return text.strip() + "\n"

def test():
    cat_res = subprocess.run(["git", "show", "origin/HTML:support/helpguides/nt8/2d__3d_optimization_graphs.htm"], capture_output=True, text=True, errors="ignore")
    parser = HtmlToMarkdownParser("strategies")
    parser.feed(cat_res.stdout)
    md = parser.get_markdown()
    print("=== Converted Standard Parser Output ===")
    print(md[:1200])

if __name__ == "__main__":
    test()
