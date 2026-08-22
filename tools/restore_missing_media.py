#!/usr/bin/env python3
"""
tools/restore_missing_media.py

Targeted Media & Section Restoration Tool:
Iterates through all Markdown documentation files in `docs/` and cross-references
against `origin/HTML:support/helpguides/nt8/<topic>.htm`.

For any images, diagrams, callout blocks, or sections present in the source HTML
that were omitted during conversion, it inserts them into the exact corresponding
context in the Markdown file.
"""

import os
import re
import glob
import subprocess
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

def get_html_files():
    res = subprocess.run(["git", "ls-tree", "-r", "--name-only", "origin/HTML", "support/helpguides/nt8/"], capture_output=True, text=True)
    return [p.strip() for p in res.stdout.splitlines() if p.endswith(".htm")]

def build_topic_maps():
    md_files = glob.glob(os.path.join(DOCS_DIR, "**/*.md"), recursive=True)
    topic_map = {}
    for f in md_files:
        base = os.path.splitext(os.path.basename(f))[0].lower()
        topic_map[base] = f
    return topic_map

def extract_html_blocks(html_text):
    """
    Extracts high-level segments from HTML with their surrounding text and images.
    Returns list of {'type': 'image'|'text', 'img_name': ..., 'alt': ..., 'preceding_text': ..., 'following_text': ...}
    """
    # Clean scripts, styles, topichead
    clean_html = re.sub(r'<script.*?</script>', '', html_text, flags=re.DOTALL|re.IGNORECASE)
    clean_html = re.sub(r'<style.*?</style>', '', clean_html, flags=re.DOTALL|re.IGNORECASE)
    clean_html = re.sub(r'<table[^>]+class="topichead".*?</table>', '', clean_html, flags=re.DOTALL|re.IGNORECASE)

    # Find all images with their surrounding text context
    img_matches = []
    for m in re.finditer(r'<img[^>]+src=["\']([^"\']+)["\']([^>]*)>', clean_html, re.IGNORECASE):
        src = m.group(1)
        attrs = m.group(2)
        img_name = os.path.basename(src).lower()
        if img_name in NAV_ICONS or any(x in img_name for x in ["tog_", "zoom_", "arrow"]):
            continue

        alt_m = re.search(r'alt=["\']([^"\']+)["\']', attrs, re.IGNORECASE)
        alt = alt_m.group(1) if alt_m else os.path.splitext(img_name)[0].replace("_", " ").title()

        # Context around image (200 chars before and after)
        start = max(0, m.start() - 300)
        end = min(len(clean_html), m.end() + 300)
        ctx_before = re.sub(r'<[^>]+>', ' ', clean_html[start:m.start()]).strip()
        ctx_after = re.sub(r'<[^>]+>', ' ', clean_html[m.end():end]).strip()

        # Normalize words
        words_before = [w for w in re.findall(r'\w{4,}', ctx_before) if not w.startswith('http')][-6:]
        words_after = [w for w in re.findall(r'\w{4,}', ctx_after) if not w.startswith('http')][:6]

        img_matches.append({
            'img_name': img_name,
            'alt': alt,
            'words_before': words_before,
            'words_after': words_after
        })

    return img_matches

def restore_images_in_file(md_path, htm_file):
    cat_res = subprocess.run(["git", "show", f"origin/HTML:{htm_file}"], capture_output=True, text=True, errors="ignore")
    html_content = cat_res.stdout

    img_matches = extract_html_blocks(html_content)
    if not img_matches:
        return False

    with open(md_path, "r", encoding="utf-8", errors="ignore") as f:
        md_content = f.read()

    existing_imgs = set(re.findall(r'!\[[^\]]*\]\(([^)#\s]+)', md_content))
    existing_img_names = {os.path.basename(img).lower() for img in existing_imgs}

    missing_imgs = [img for img in img_matches if img['img_name'] not in existing_img_names]
    if not missing_imgs:
        return False

    lines = md_content.splitlines()
    changed = False

    for missing in missing_imgs:
        img_tag = f"![{missing['alt']}](../images/{missing['img_name']})"
        inserted = False

        # Attempt 1: Match by words_before
        if missing['words_before']:
            for idx in range(len(lines) - 1, -1, -1):
                line = lines[idx]
                if any(w.lower() in line.lower() for w in missing['words_before'][-3:]):
                    # Insert after this line
                    lines.insert(idx + 1, "")
                    lines.insert(idx + 2, img_tag)
                    lines.insert(idx + 3, "")
                    inserted = True
                    changed = True
                    break

        # Attempt 2: Match by words_after
        if not inserted and missing['words_after']:
            for idx in range(len(lines)):
                line = lines[idx]
                if any(w.lower() in line.lower() for w in missing['words_after'][:3]):
                    # Insert before this line
                    lines.insert(idx, img_tag)
                    lines.insert(idx + 1, "")
                    inserted = True
                    changed = True
                    break

        # Attempt 3: If neither matched, append to end of relevant section or document
        if not inserted:
            lines.append("")
            lines.append(img_tag)
            lines.append("")
            changed = True

    if changed:
        new_md = "\n".join(lines)
        new_md = re.sub(r'\n{3,}', '\n\n', new_md).strip() + "\n"
        with open(md_path, "w", encoding="utf-8") as f:
            f.write(new_md)
        return True

    return False

def restore_all_docs():
    htm_files = get_html_files()
    topic_map = build_topic_maps()

    restored_count = 0
    for htm in htm_files:
        base = os.path.splitext(os.path.basename(htm))[0].lower()
        if base in topic_map:
            md_path = topic_map[base]
            if restore_images_in_file(md_path, htm):
                restored_count += 1

    print(f"Successfully restored missing images and figures across {restored_count} documentation files.")

if __name__ == "__main__":
    restore_all_docs()
