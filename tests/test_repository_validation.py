#!/usr/bin/env python3
"""
tests/test_repository_validation.py

Automated unit tests asserting repository structure, clean root,
relative link integrity, and image asset resolution across the docs/ tree.
"""

import os
import unittest
import glob
import re

REPO_ROOT = os.path.abspath(os.path.join(os.path.dirname(__file__), ".."))
DOCS_DIR = os.path.join(REPO_ROOT, "docs")
IMAGES_DIR = os.path.join(DOCS_DIR, "images")

class TestRepositoryValidation(unittest.TestCase):

    def test_clean_root_directory(self):
        """Root directory should only contain standard top-level project directories and files."""
        allowed_root_files = {
            ".git",
            ".github",
            ".gitignore",
            ".claude",
            ".wiki_dist",
            ".playwright-mcp",
            "README.md",
            "CLAUDE.md",
            "content",
            "docs",
            "plans",
            "samples",
            "tests",
            "tools",
        }
        root_entries = set(os.listdir(REPO_ROOT))
        extra_entries = root_entries - allowed_root_files
        self.assertEqual(len(extra_entries), 0, f"Root contains unexpected files/folders: {extra_entries}")

    def test_docs_subdirectories_exist(self):
        """All expected category directories under docs/ must exist and contain markdown files."""
        expected_dirs = [
            "getting_started",
            "operations",
            "ninjascript",
            "language_reference",
            "indicators",
            "strategies",
            "drawing_tools",
            "addons",
            "release_notes",
            "images",
        ]
        for d in expected_dirs:
            target = os.path.join(DOCS_DIR, d)
            self.assertTrue(os.path.isdir(target), f"Missing expected docs folder: {d}")
            self.assertGreater(len(os.listdir(target)), 0, f"Folder {d} is empty")

    def test_image_assets_count(self):
        """docs/images should contain all 1,168 image assets."""
        images = os.listdir(IMAGES_DIR)
        self.assertGreaterEqual(len(images), 1168, f"Expected at least 1168 images, got {len(images)}")

    def test_zero_broken_markdown_links(self):
        """All internal relative markdown and image links in docs/ and README.md must resolve."""
        all_docs = glob.glob(os.path.join(DOCS_DIR, "**/*.md"), recursive=True)
        all_docs.append(os.path.join(REPO_ROOT, "README.md"))

        link_pattern = re.compile(r'(!?\[)(.*?)\]\(([^)#\s]+(?:#[^)\s]*)?)\)')
        broken_links = []

        for doc in all_docs:
            doc_dir = os.path.dirname(doc)
            with open(doc, "r", encoding="utf-8", errors="ignore") as f:
                for line_num, line in enumerate(f, 1):
                    for match in link_pattern.finditer(line):
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
                            broken_links.append(f"{os.path.relpath(doc, REPO_ROOT)}:{line_num} -> {raw_target}")

        self.assertEqual(len(broken_links), 0, f"Found broken links: {broken_links[:10]}")

if __name__ == "__main__":
    unittest.main()
