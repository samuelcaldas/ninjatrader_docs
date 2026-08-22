#!/usr/bin/env python3
"""
tests/test_wiki_deployment.py

Automated unit tests asserting wiki staging, sidebar generation,
and internal wiki page references.
"""

import os
import unittest
import glob
import subprocess
import sys

REPO_ROOT = os.path.abspath(os.path.join(os.path.dirname(__file__), ".."))
WIKI_DIST = os.path.join(REPO_ROOT, ".wiki_dist")
TOOLS_DIR = os.path.join(REPO_ROOT, "tools")

class TestWikiDeployment(unittest.TestCase):

    @classmethod
    def setUpClass(cls):
        # Stage wiki if not present
        deploy_script = os.path.join(TOOLS_DIR, "deploy_wiki.py")
        subprocess.run([sys.executable, deploy_script, "--stage-only"], check=True, cwd=REPO_ROOT)

    def test_wiki_dist_files_exist(self):
        """Essential wiki files must exist in .wiki_dist."""
        self.assertTrue(os.path.exists(os.path.join(WIKI_DIST, "Home.md")))
        self.assertTrue(os.path.exists(os.path.join(WIKI_DIST, "_Sidebar.md")))
        self.assertTrue(os.path.exists(os.path.join(WIKI_DIST, "_Footer.md")))

    def test_sidebar_structure(self):
        """_Sidebar.md must contain navigational headers and wiki page links."""
        with open(os.path.join(WIKI_DIST, "_Sidebar.md"), "r", encoding="utf-8") as f:
            content = f.read()

        self.assertIn("[NinjaTrader 8 Wiki](Home)", content)
        self.assertIn("### [Welcome to NinjaTrader](welcome)", content)
        self.assertIn("### [NinjaScript](ninjascript)", content)
        self.assertIn("### [Operations](operations)", content)

    def test_wiki_pages_count(self):
        """All documentation pages should be present in the flat wiki staging directory."""
        wiki_mds = glob.glob(os.path.join(WIKI_DIST, "*.md"))
        self.assertGreaterEqual(len(wiki_mds), 1550)

if __name__ == "__main__":
    unittest.main()
