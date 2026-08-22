#!/usr/bin/env python3
"""
tools/reorganize_docs.py

Reorganizes the 1,556 markdown files and 1,168 images into a clean docs/ folder hierarchy
using `git mv` to preserve git history. Also rewrites all internal relative markdown links
and image links so that everything resolves cleanly across the subfolders.
"""

import os
import re
import subprocess
import glob
from collections import defaultdict, Counter

REPO_ROOT = os.path.abspath(os.path.join(os.path.dirname(__file__), ".."))
DOCS_DIR = os.path.join(REPO_ROOT, "docs")
README_PATH = os.path.join(REPO_ROOT, "README.md")

CATEGORIES = [
    "getting_started",
    "operations",
    "ninjascript",
    "language_reference",
    "indicators",
    "strategies",
    "drawing_tools",
    "addons",
    "release_notes",
]

def get_indent(line):
    return len(line) - len(line.lstrip(' \t'))

def build_tree_mapping():
    """Parses README.md hierarchical tree to map every file to its target category."""
    with open(README_PATH, "r", encoding="utf-8") as f:
        lines = f.readlines()

    items = []
    for line in lines:
        if '[' in line and ']' in line and '(' in line and ')' in line:
            m = re.search(r'\[(.*?)\]\(([^)#\s]+(?:#[^)\s]*)?)\)', line)
            if m:
                indent = get_indent(line)
                title = m.group(1).strip('[]')
                target = os.path.basename(m.group(2).split('#')[0])
                items.append((indent, title, target))

    stack = []
    file_to_cat = {}

    for indent, title, target in items:
        while stack and stack[-1][0] >= indent:
            stack.pop()
        stack.append((indent, title, target))
        path = [s[1] for s in stack]
        p_str = ' > '.join(path)

        cat = 'getting_started'
        if any(k in p_str for k in ['Release Notes', '8.0.', '8.1.']):
            cat = 'release_notes'
        elif any(k in p_str for k in ['Indicator', 'System Indicator Methods']):
            cat = 'indicators'
        elif any(k in p_str for k in ['Drawing Tool', 'SharpDX', 'Direct2D', 'DirectWrite', 'Chart Style']):
            cat = 'drawing_tools'
        elif any(k in p_str for k in ['Add On', 'Controls', 'NTWindow', 'TabControl']):
            cat = 'addons'
        elif any(k in p_str for k in ['Strategy', 'ATM Strategy', 'Strategy Analyzer', 'Strategy Builder', 'Order']):
            cat = 'strategies'
        elif any(k in p_str for k in ['Language Reference', 'Alphabetical Reference', 'Common', 'ISeries', 'Instruments']):
            cat = 'language_reference'
        elif any(k in p_str for k in ['NinjaScript', 'Editor', 'Educational Resources', 'Distribution']):
            cat = 'ninjascript'
        elif any(k in p_str for k in ['Operations', 'Charts', 'SuperDOM', 'Market Analyzer', 'Control Center']):
            cat = 'operations'
        elif any(k in p_str for k in ['Welcome', 'Introduction', 'Configuration', 'Installation', 'Connecting']):
            cat = 'getting_started'

        file_to_cat[target] = cat

    # Also map all files currently in docs/
    all_existing_mds = glob.glob(os.path.join(DOCS_DIR, "**/*.md"), recursive=True)
    all_md_basenames = [os.path.basename(f) for f in all_existing_mds if os.path.basename(f) != "README.md"]

    for md in all_md_basenames:
        if md not in file_to_cat:
            lower = md.lower()
            if re.match(r'^\d+_\d+.*\.md$', lower) or "release" in lower or "notes" in lower or "version" in lower:
                file_to_cat[md] = "release_notes"
            elif any(k in lower for k in ["indicator", "sma", "ema", "rsi", "macd", "bollinger", "stochastics", "atr", "volumetric", "vwap", "order_flow"]):
                file_to_cat[md] = "indicators"
            elif any(k in lower for k in ["strategy", "order", "atm", "position", "trade", "entry", "exit"]):
                file_to_cat[md] = "strategies"
            elif any(k in lower for k in ["drawing", "sharpdx", "render", "direct2d", "dxm", "brush", "chart_anchor"]):
                file_to_cat[md] = "drawing_tools"
            elif any(k in lower for k in ["addon", "ntwindow", "wpf", "tab", "menu", "custom_window"]):
                file_to_cat[md] = "addons"
            elif any(k in lower for k in ["ninjascript", "onstatechange", "onbarupdate", "state", "bars", "series"]):
                file_to_cat[md] = "ninjascript"
            elif any(k in lower for k in ["chart", "superdom", "market_analyzer", "depth_map", "time__sales", "hot_keys", "workspace"]):
                file_to_cat[md] = "operations"
            elif any(k in lower for k in ["welcome", "intro", "install", "config", "license", "account", "connect"]):
                file_to_cat[md] = "getting_started"
            else:
                file_to_cat[md] = "language_reference"

    return file_to_cat

def execute_reorganization():
    os.chdir(REPO_ROOT)
    file_mapping = build_tree_mapping()

    for cat in CATEGORIES:
        os.makedirs(os.path.join(DOCS_DIR, cat), exist_ok=True)
    os.makedirs(os.path.join(DOCS_DIR, "images"), exist_ok=True)

    print("Category breakdown:")
    for c, count in Counter(file_mapping.values()).items():
        print(f"  {c}: {count}")

    # Move all existing markdown files to their correct category folders via git mv
    all_doc_files = glob.glob(os.path.join(DOCS_DIR, "**/*.md"), recursive=True)
    chunk_size = 100

    for doc_path in all_doc_files:
        basename = os.path.basename(doc_path)
        if basename == "README.md":
            continue
        current_cat = os.path.basename(os.path.dirname(doc_path))
        target_cat = file_mapping.get(basename, "language_reference")

        if current_cat != target_cat:
            target_path = os.path.join(DOCS_DIR, target_cat, basename)
            subprocess.run(["git", "mv", doc_path, target_path], check=True)

    doc_locations = {md: cat for md, cat in file_mapping.items()}

    img_extensions = ('.png', '.jpg', '.jpeg', '.gif', '.svg', '.bmp', '.ico')

    # Rewrite links in all docs
    print("Rewriting relative links and image paths in markdown documents...")
    all_doc_paths = glob.glob(os.path.join(DOCS_DIR, "**/*.md"), recursive=True)

    for doc_path in all_doc_paths:
        if os.path.basename(doc_path) == "README.md":
            continue
        current_cat = os.path.basename(os.path.dirname(doc_path))

        with open(doc_path, "r", encoding="utf-8", errors="ignore") as f:
            text = f.read()

        def rewrite_link(match):
            prefix = match.group(1)
            label = match.group(2)
            target = match.group(3)

            if target.startswith("http://") or target.startswith("https://") or target.startswith("mailto:"):
                return f"{prefix}[{label}]({target})"
            if target.startswith("#"):
                return f"{prefix}[{label}]({target})"

            parts = target.split("#", 1)
            path_part = parts[0]
            anchor_part = f"#{parts[1]}" if len(parts) > 1 else ""

            filename = os.path.basename(path_part)
            ext = os.path.splitext(filename)[1].lower()

            if ext in img_extensions:
                return f"{prefix}[{label}](../images/{filename}{anchor_part})"

            if filename in doc_locations:
                target_cat = doc_locations[filename]
                if target_cat == current_cat:
                    new_target = f"{filename}{anchor_part}"
                else:
                    new_target = f"../{target_cat}/{filename}{anchor_part}"
                return f"{prefix}[{label}]({new_target})"

            return f"{prefix}[{label}]({target})"

        pattern = r'(!?\[)(.*?)\]\(([^)#\s]+(?:#[^)\s]*)?)\)'
        updated_text = re.sub(pattern, rewrite_link, text)

        with open(doc_path, "w", encoding="utf-8") as f:
            f.write(updated_text)

    # Update root README.md and docs/README.md
    print("Updating README.md and docs/README.md...")
    with open(README_PATH, "r", encoding="utf-8") as f:
        root_readme = f.read()

    def rewrite_root_readme(match):
        prefix = match.group(1)
        label = match.group(2)
        target = match.group(3)
        if target.startswith("#") or target.startswith("http") or target.startswith("mailto"):
            return f"{prefix}[{label}]({target})"
        parts = target.split("#", 1)
        filename = os.path.basename(parts[0])
        anchor_part = f"#{parts[1]}" if len(parts) > 1 else ""
        if filename in doc_locations:
            target_cat = doc_locations[filename]
            return f"{prefix}[{label}](docs/{target_cat}/{filename}{anchor_part})"
        return f"{prefix}[{label}]({target})"

    updated_root_readme = re.sub(r'(!?\[)(.*?)\]\(([^)#\s]+(?:#[^)\s]*)?)\)', rewrite_root_readme, root_readme)
    with open(README_PATH, "w", encoding="utf-8") as f:
        f.write(updated_root_readme)

    def rewrite_docs_readme(match):
        prefix = match.group(1)
        label = match.group(2)
        target = match.group(3)
        if target.startswith("#") or target.startswith("http") or target.startswith("mailto"):
            return f"{prefix}[{label}]({target})"
        parts = target.split("#", 1)
        filename = os.path.basename(parts[0])
        anchor_part = f"#{parts[1]}" if len(parts) > 1 else ""
        if filename in doc_locations:
            target_cat = doc_locations[filename]
            return f"{prefix}[{label}]({target_cat}/{filename}{anchor_part})"
        return f"{prefix}[{label}]({target})"

    docs_readme = re.sub(r'(!?\[)(.*?)\]\(([^)#\s]+(?:#[^)\s]*)?)\)', rewrite_docs_readme, root_readme)
    with open(os.path.join(DOCS_DIR, "README.md"), "w", encoding="utf-8") as f:
        f.write(docs_readme)

    print("Reorganization complete!")

if __name__ == "__main__":
    execute_reorganization()
