#!/usr/bin/env python3
"""
tools/replace_icon_images.py

Investigates and replaces repetitive UI/layout icon images with clean Markdown/Unicode equivalents:
1. `ns.png` (NinjaScript icon prefix above Example code blocks): Remove decorative banner icon before code blocks.
2. `check.png`: Replace with `✅` (or `✔`).
3. `error.png`: Replace with `❌` (or `✖`).
4. `cicon_video_playbutton.png` / `playvideo.jpg`: Replace with video callout icon `▶️ Video Guide:` or clean link.
"""

import os
import re
import glob

REPO_ROOT = os.path.abspath(os.path.join(os.path.dirname(__file__), ".."))
DOCS_DIR = os.path.join(REPO_ROOT, "docs")

def replace_repetitive_icons():
    files = glob.glob(os.path.join(DOCS_DIR, "**/*.md"), recursive=True)
    files.append(os.path.join(REPO_ROOT, "README.md"))

    modified_count = 0
    total_ns = 0
    total_check = 0
    total_error = 0
    total_video = 0

    for file_path in files:
        with open(file_path, "r", encoding="utf-8", errors="ignore") as f:
            content = f.read()

        orig = content

        # 1. Remove ns.png (NinjaScript logo icon in example headers / code fences)
        ns_matches = len(re.findall(r'!\[[^\]]*\]\([^)]*ns\.png\)', content, re.IGNORECASE))
        if ns_matches:
            total_ns += ns_matches
            # Remove standalone image line
            content = re.sub(r'^[ \t]*!\[[^\]]*\]\([^)]*ns\.png\)[ \t]*\n+', '', content, flags=re.MULTILINE|re.IGNORECASE)
            # Remove inline image tag if inside comments/text
            content = re.sub(r'!\[[^\]]*\]\([^)]*ns\.png\)', '', content, flags=re.IGNORECASE)

        # 2. Replace check.png with ✅
        check_matches = len(re.findall(r'!\[[^\]]*\]\([^)]*check\.png\)', content, re.IGNORECASE))
        if check_matches:
            total_check += check_matches
            content = re.sub(r'!\[[^\]]*\]\([^)]*check\.png\)', '✅', content, flags=re.IGNORECASE)

        # 3. Replace error.png with ❌
        error_matches = len(re.findall(r'!\[[^\]]*\]\([^)]*error\.png\)', content, re.IGNORECASE))
        if error_matches:
            total_error += error_matches
            content = re.sub(r'!\[[^\]]*\]\([^)]*error\.png\)', '❌', content, flags=re.IGNORECASE)

        # 4. Replace video play buttons with ▶️
        video_matches = len(re.findall(r'!\[[^\]]*\]\([^)]*(cicon_video_playbutton\.png|playvideo\.jpg)\)', content, re.IGNORECASE))
        if video_matches:
            total_video += video_matches
            content = re.sub(r'!\[[^\]]*\]\([^)]*(cicon_video_playbutton\.png|playvideo\.jpg)\)', '▶️', content, flags=re.IGNORECASE)

        # Cleanup excessive consecutive newlines
        content = re.sub(r'\n{3,}', '\n\n', content)

        if content != orig:
            with open(file_path, "w", encoding="utf-8") as f:
                f.write(content)
            modified_count += 1

    print(f"Replaced repetitive image icons across {modified_count} files:")
    print(f"  - ns.png removed: {total_ns}")
    print(f"  - check.png -> ✅: {total_check}")
    print(f"  - error.png -> ❌: {total_error}")
    print(f"  - video icons -> ▶️: {total_video}")

if __name__ == "__main__":
    replace_repetitive_icons()
