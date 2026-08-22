"""
Automated Static Verification and Quality Assurance Test Suite for NinjaTrader 8 Docs.

Asserts 5 core verification gates:
1. Zero broken local links or image asset links across all markdown documents.
2. Zero legacy navigation table leftovers ("Click to Display Table of Contents").
3. Zero unconverted legacy code tables ("| ns |" or "|ns|").
4. Zero unescaped non-breaking spaces (\\xa0).
5. Zero unmatched or unclosed markdown code block fences (```).
6. 100% Idempotency of transformation pipeline.
"""

import glob
import re
import unittest
from pathlib import Path
from tools.migrate_docs import transform_document


class TestNinjaTraderDocsRepository(unittest.TestCase):
    @classmethod
    def setUpClass(cls):
        cls.root_dir = Path(__file__).resolve().parent.parent
        cls.md_files = sorted([f.name for f in cls.root_dir.glob("*.md")])
        cls.all_md_set = set(cls.md_files)
        cls.all_images = set(
            [f.name for f in (
                list(cls.root_dir.glob("*.png")) +
                list(cls.root_dir.glob("*.jpg")) +
                list(cls.root_dir.glob("*.gif")) +
                list(cls.root_dir.glob("*.svg"))
            )]
        )

    def test_gate1_zero_broken_local_links(self):
        """Assert that all local markdown links and image links resolve to real files on disk."""
        broken_links = []
        for filename in self.md_files:
            filepath = self.root_dir / filename
            content = filepath.read_text(encoding="utf-8", errors="ignore")
            for m in re.finditer(r"\[([^\]]*)\]\(([^)\n]+)\)", content):
                raw_dest = m.group(2).strip()
                dest = raw_dest.split(' "')[0].split(" '")[0].split("#")[0].strip()
                if dest and not dest.startswith(("http://", "https://", "mailto:", "javascript:")):
                    if dest not in self.all_md_set and dest not in self.all_images:
                        broken_links.append((filename, m.group(1), raw_dest))

        self.assertEqual(
            len(broken_links), 0,
            f"Found {len(broken_links)} broken local links: {broken_links[:10]}"
        )

    def test_gate2_zero_legacy_navigation_tables(self):
        """Assert no legacy navigation table headers remain."""
        nav_remnants = []
        for filename in self.md_files:
            filepath = self.root_dir / filename
            content = filepath.read_text(encoding="utf-8", errors="ignore")
            if "Click to Display Table of Contents" in content:
                nav_remnants.append(filename)

        self.assertEqual(
            len(nav_remnants), 0,
            f"Found legacy navigation tables in {nav_remnants}"
        )

    def test_gate3_zero_unconverted_ns_code_tables(self):
        """Assert no unconverted | ns | table artifacts remain."""
        ns_remnants = []
        for filename in self.md_files:
            filepath = self.root_dir / filename
            content = filepath.read_text(encoding="utf-8", errors="ignore")
            if "| ns |" in content or "|ns|" in content:
                ns_remnants.append(filename)

        self.assertEqual(
            len(ns_remnants), 0,
            f"Found unconverted ns tables in {ns_remnants}"
        )

    def test_gate4_zero_non_breaking_spaces(self):
        """Assert no non-breaking space characters (\\xa0) exist in markdown docs."""
        nbsp_files = []
        for filename in self.md_files:
            filepath = self.root_dir / filename
            content = filepath.read_text(encoding="utf-8", errors="ignore")
            if "\xa0" in content:
                nbsp_files.append(filename)

        self.assertEqual(
            len(nbsp_files), 0,
            f"Found non-breaking spaces in {nbsp_files}"
        )

    def test_gate5_matching_code_block_fences(self):
        """Assert all markdown documents have balanced and properly closed code block fences."""
        unmatched_fences = []
        for filename in self.md_files:
            filepath = self.root_dir / filename
            content = filepath.read_text(encoding="utf-8", errors="ignore")
            fences = len(re.findall(r"^```", content, re.MULTILINE))
            if fences % 2 != 0:
                unmatched_fences.append((filename, fences))

        self.assertEqual(
            len(unmatched_fences), 0,
            f"Found unbalanced code block fences in {unmatched_fences}"
        )

    def test_gate6_pipeline_idempotency(self):
        """Assert that running the migration transform on clean docs produces 0 modifications."""
        modified = []
        # Sample across diverse doc types: root index, tutorials, api references, sharpdx
        sample_files = [
            "README.md",
            "welcome.md",
            "onstatechange.md",
            "onbarupdate.md",
            "adding_indicators_to_strategie.md",
            "using_sharpdx_for_custom_chart_rendering.md",
            "code_breaking_changes.md",
            "working_with_brushes.md",
            "managed_approach.md",
            "ninjascript_best_practices.md"
        ]
        for filename in sample_files:
            filepath = self.root_dir / filename
            content = filepath.read_text(encoding="utf-8", errors="ignore")
            transformed = transform_document(content, filename, self.all_md_set, self.all_images)
            if transformed != content:
                modified.append(filename)

        self.assertEqual(
            len(modified), 0,
            f"Pipeline is not idempotent on sample files: {modified}"
        )


if __name__ == "__main__":
    unittest.main()
