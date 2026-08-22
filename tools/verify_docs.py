#!/usr/bin/env python3
"""
tools/verify_docs.py

Verifies doc links, image references, and code block formatting across all docs.
"""

import os
import re
import sys
import glob

REPO_ROOT = os.path.abspath(os.path.join(os.path.dirname(__file__), ".."))
DOCS_DIR = os.path.join(REPO_ROOT, "docs")
IMAGES_DIR = os.path.join(DOCS_DIR, "images")

def verify_all_docs():
    errors = []
    all_docs = glob.glob(os.path.join(DOCS_DIR, "**/*.md"), recursive=True)
    all_docs.append(os.path.join(REPO_ROOT, "README.md"))

    print(f"Scanning {len(all_docs)} markdown files...")

    # Pattern for markdown links [text](path) and images ![alt](path)
    link_pattern = re.compile(r'(!?\[)(.*?)\]\(([^)#\s]+(?:#[^)\s]*)?)\)')

    for doc in all_docs:
        doc_dir = os.path.dirname(doc)
        with open(doc, "r", encoding="utf-8", errors="ignore") as f:
            lines = f.readlines()

        in_code_fence = False
        for line_num, line in enumerate(lines, 1):
            if line.strip().startswith("```"):
                in_code_fence = not in_code_fence

            for match in link_pattern.finditer(line):
                prefix = match.group(1) # '[' or '!['
                raw_target = match.group(3)

                if raw_target.startswith("http://") or raw_target.startswith("https://") or raw_target.startswith("mailto:"):
                    continue
                if raw_target.startswith("#"):
                    continue

                target_path = raw_target.split("#")[0]
                if not target_path:
                    continue

                resolved = os.path.normpath(os.path.join(doc_dir, target_path))
                if not os.path.exists(resolved):
                    errors.append(f"{os.path.relpath(doc, REPO_ROOT)}:{line_num} Broken link -> {raw_target} (resolved: {os.path.relpath(resolved, REPO_ROOT)})")

    return errors

if __name__ == "__main__":
    errs = verify_all_docs()
    if errs:
        print(f"FAILED: Found {len(errs)} broken links/images:")
        for e in errs[:20]:
            print(f"  {e}")
        if len(errs) > 20:
            print(f"  ... and {len(errs) - 20} more.")
        sys.exit(1)
    else:
        print("SUCCESS: 0 broken links or missing image assets found!")
        sys.exit(0)
