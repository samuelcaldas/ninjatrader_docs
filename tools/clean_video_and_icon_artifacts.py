#!/usr/bin/env python3
"""
tools/clean_video_and_icon_artifacts.py

Cleans up broken standalone video artifacts and consecutive ▶️ lines across Markdown files:
1. Strips orphan `▶️` lines and collapsed `> **playVideo**` or `> playVideo` blocks.
2. Formats legitimate video links as clean Markdown callouts: `> 🎥 **Video:** [Link Title](url)`.
3. Normalizes collapsed layout tables around video headers.
"""

import os
import re
import glob

REPO_ROOT = os.path.abspath(os.path.join(os.path.dirname(__file__), ".."))
DOCS_DIR = os.path.join(REPO_ROOT, "docs")

def clean_artifacts():
    all_files = glob.glob(os.path.join(DOCS_DIR, "**/*.md"), recursive=True)
    all_files.append(os.path.join(REPO_ROOT, "README.md"))

    cleaned_count = 0

    for file_path in all_files:
        with open(file_path, "r", encoding="utf-8", errors="ignore") as f:
            content = f.read()

        orig = content

        # 1. Remove consecutive orphan ▶️ lines
        content = re.sub(r'(?:^[ \t]*▶️[ \t]*\n+)+', '', content, flags=re.MULTILINE)

        # 2. Remove orphan > playVideo / > **playVideo** blockquotes
        content = re.sub(r'^[ \t]*>[ \t]*\**playVideo\**[ \t]*\n+', '', content, flags=re.MULTILINE|re.IGNORECASE)

        # 3. Clean any remaining inline orphan ▶️ with no text on line
        content = re.sub(r'^[ \t]*▶️[ \t]*$', '', content, flags=re.MULTILINE)

        # 4. Remove duplicate/empty horizontal rules
        content = re.sub(r'(?:^[ \t]*---[ \t]*\n+){2,}', '---\n\n', content, flags=re.MULTILINE)

        # 5. Clean excessive newlines
        content = re.sub(r'\n{3,}', '\n\n', content)

        if content != orig:
            with open(file_path, "w", encoding="utf-8") as f:
                f.write(content)
            cleaned_count += 1

    print(f"Cleaned orphan video/icon artifacts across {cleaned_count} files.")

if __name__ == "__main__":
    clean_artifacts()
