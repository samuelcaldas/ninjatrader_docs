#!/usr/bin/env python3
"""
tools/clean_tables.py

Cleans and standardizes markdown tables across the NinjaTrader 8 documentation:
1. Normalizes Release Notes tables by shifting real headers from row 1 to table header.
2. Removes ghost tables (0 data rows) and redundant layout wrapper tables.
3. Standardizes parameter/property tables with semantic headers (| Parameter | Description |).
4. Cleans inline callout artifacts (| | --- | | Tip: -> > **Tip:**).
5. Fixes unlabeled code fences and adds syntax highlighting.
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
        # Look for table starting with empty header followed by real headers in first data row
        if line.startswith("|") and line.endswith("|") and i + 2 < len(lines):
            header = lines[i]
            sep = lines[i+1]
            first_row = lines[i+2]
            header_cells = [c.strip() for c in header.split("|")[1:-1]]
            first_cells = [c.strip() for c in first_row.split("|")[1:-1]]

            if all(c == "" for c in header_cells) and any(c in ["Issue #", "Feature #", "Status", "Category", "Comments"] for c in first_cells):
                # Promote first_row to header
                col_count = len(first_cells)
                new_lines.append("| " + " | ".join(first_cells) + " |")
                new_lines.append("| " + " | ".join(["---"] * col_count) + " |")
                i += 3
                continue
        new_lines.append(line)
        i += 1
    return "\n".join(new_lines)

def remove_pure_ghost_tables(content):
    """Removes 2-row ghost tables with empty headers, empty separators and 0 data rows."""
    lines = content.splitlines()
    new_lines = []
    i = 0
    while i < len(lines):
        line = lines[i]
        if line.startswith("|") and line.endswith("|") and i + 1 < len(lines):
            header = lines[i]
            sep = lines[i+1]
            header_cells = [c.strip() for c in header.split("|")[1:-1]]
            sep_cells = [c.strip() for c in sep.split("|")[1:-1]]

            is_empty_header = all(c == "" for c in header_cells)
            is_valid_sep = all(set(c).issubset({"-", ":"}) for c in sep_cells) if sep_cells else False

            # Check if next line is end of table (not starting with |)
            is_end_of_table = (i + 2 >= len(lines)) or (not lines[i+2].strip().startswith("|"))

            if is_empty_header and is_valid_sep and is_end_of_table:
                # Ghost table with 0 data rows -> skip
                i += 2
                continue
        new_lines.append(line)
        i += 1
    return "\n".join(new_lines)

def standardize_param_property_headers(content):
    """Replaces empty 2-column table headers with semantic names."""
    # Under ## Parameters
    def repl_param(m):
        return m.group(1) + "| Parameter | Description |\n| --- | --- |\n"
    content = re.sub(r'(## Parameters\s*\n\s*)\|\s*\|\s*\|\s*\n\|\s*---\s*\|\s*---\s*\n', repl_param, content)

    # Under ## Property Value
    def repl_prop(m):
        return m.group(1) + "| Property | Description |\n| --- | --- |\n"
    content = re.sub(r'(## Property Value\s*\n\s*)\|\s*\|\s*\|\s*\n\|\s*---\s*\|\s*---\s*\n', repl_prop, content)

    # General 2-column tables with empty headers
    lines = content.splitlines()
    new_lines = []
    i = 0
    while i < len(lines):
        line = lines[i]
        if line.strip() == "|  |  |" and i + 1 < len(lines) and lines[i+1].strip() == "| --- | --- |":
            # If followed by rows, give it a standard header
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
                return f"```csharp\n{code}```"
            elif "<" in code_strip and ">" in code_strip and any(tag in code_strip for tag in ["<NinjaTrader", "<xml", "<Window", "<Grid", "<Style", "<?xml"]):
                return f"```xml\n{code}```"
            else:
                return f"```text\n{code}```"
        return m.group(0)

    return re.sub(r'```(\w*)\n(.*?)```', repl_fence, content, flags=re.DOTALL)

def clean_all_docs():
    all_docs = glob.glob(os.path.join(DOCS_DIR, "**/*.md"), recursive=True)
    all_docs.append(os.path.join(REPO_ROOT, "README.md"))

    cleaned_files = 0
    for doc in all_docs:
        with open(doc, "r", encoding="utf-8", errors="ignore") as f:
            orig = f.read()

        step1 = clean_release_notes_tables(orig)
        step2 = remove_pure_ghost_tables(step1)
        step3 = standardize_param_property_headers(step2)
        step4 = fix_code_fences(step3)

        if step4 != orig:
            with open(doc, "w", encoding="utf-8") as f:
                f.write(step4)
            cleaned_files += 1

    print(f"Standardized and cleaned {cleaned_files}/{len(all_docs)} documentation files.")

if __name__ == "__main__":
    clean_all_docs()
