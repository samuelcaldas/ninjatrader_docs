#!/usr/bin/env python3
"""
tools/sync_and_convert_docs.py

Automated Pipeline for Scheduled & Manual Synchronization of NinjaTrader 8 Documentation:
1. Scrapes latest official HTML Help Guide & media assets into support/helpguides/nt8/
2. Converts HTML topics to clean GitHub-Flavored Markdown adhering strictly to repository architecture:
   - Categorized 9-folder taxonomy (getting_started, operations, ninjascript, language_reference, indicators, strategies, drawing_tools, addons, release_notes)
   - Layout table & toggle unwrapping (tog_minus/tog_plus -> semantic ## / ### headings)
   - Callout note extraction (> **Note:**, > **Tip:**, > **Warning:**)
   - Relative media linking against docs/images/
   - Code fence syntax formatting (```csharp, ```xml, ```text)
   - Repetitive icon replacement (ns.png removed, check/error -> ✅/❌, play -> ▶️)
3. Regenerates Master README.md and subfolder index hubs (docs/*/README.md)
4. Validates 100% of links and assets via verify_docs.py
"""

import os
import sys
import glob
import subprocess

REPO_ROOT = os.path.abspath(os.path.join(os.path.dirname(__file__), ".."))

def run_step(desc, cmd_args):
    print(f"=== {desc} ===")
    res = subprocess.run(cmd_args, cwd=REPO_ROOT, text=True)
    if res.returncode != 0:
        print(f"FAILED: {desc} (exit code {res.returncode})")
        sys.exit(res.returncode)
    print(f"SUCCESS: {desc}\n")

def main():
    # 1. Scrape latest official docs
    run_step("1. Crawling and Scraping Online NinjaTrader 8 Documentation", ["python3", "tools/scrape_nt8_docs.py"])

    # 2. Restore/Update missing media
    run_step("2. Synchronizing and Restoring Media & Diagrams", ["python3", "tools/restore_missing_media.py"])

    # 3. Clean and standardize tables, callouts, toggles, and code blocks
    run_step("3. Standardizing Layout Tables, Toggles, and Code Fences", ["python3", "tools/clean_tables.py"])

    # 4. Replace repetitive decorative icon images with Markdown/Unicode equivalents
    run_step("4. Replacing Repetitive Icon Artifacts with Unicode/Markdown", ["python3", "tools/replace_icon_images.py"])

    # 5. Regenerate Master README and Category Topic Indexes
    run_step("5. Regenerating Master Index and Category README Hubs", ["python3", "tools/generate_readme.py"])

    # 6. Verify documentation links and images
    run_step("6. Verifying Link & Image Asset Integrity", ["python3", "tools/verify_docs.py"])

    # 7. Run test suite
    run_step("7. Executing Automated Test Suite", ["python3", "-m", "unittest", "discover", "-s", "tests"])

    print("🎉 Full documentation sync, conversion, and verification completed successfully!")

if __name__ == "__main__":
    main()
