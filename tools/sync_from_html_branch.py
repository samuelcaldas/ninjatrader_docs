#!/usr/bin/env python3
"""
tools/sync_from_html_branch.py

Synchronizes Markdown documentation directly from the updated origin/HTML branch:
1. Copies newly downloaded image assets from origin/HTML into docs/images/
2. Converts new HTML topics (NT 8.1.1 - 8.1.8 release notes, Calendar, Economics, Pulse, Order Flow Delta/POV bars)
   into the proper categorized folders in docs/
3. Runs the full standardizing & cleaning pipeline (layout tables, toggles, callouts, fences, icons)
4. Regenerates master README.md and folder indices
5. Verifies 100% link and image integrity
"""

import os
import re
import glob
import subprocess

REPO_ROOT = os.path.abspath(os.path.join(os.path.dirname(__file__), ".."))
DOCS_DIR = os.path.join(REPO_ROOT, "docs")
IMAGES_DIR = os.path.join(DOCS_DIR, "images")

# Category mapping for new topics
NEW_TOPIC_CATEGORIES = {
    # Release Notes
    "8_1_1": ("release_notes", "8_1_1.md", "Release Notes - NinjaTrader 8.1.1"),
    "8_1_2": ("release_notes", "8_1_2.md", "Release Notes - NinjaTrader 8.1.2"),
    "8_1_3": ("release_notes", "8_1_3.md", "Release Notes - NinjaTrader 8.1.3"),
    "8_1_4": ("release_notes", "8_1_4.md", "Release Notes - NinjaTrader 8.1.4"),
    "8_1_5": ("release_notes", "8_1_5.md", "Release Notes - NinjaTrader 8.1.5"),
    "8_1_6": ("release_notes", "8_1_6.md", "Release Notes - NinjaTrader 8.1.6"),
    "8_1_7": ("release_notes", "8_1_7.md", "Release Notes - NinjaTrader 8.1.7"),
    "8_1_8": ("release_notes", "8_1_8.md", "Release Notes - NinjaTrader 8.1.8"),

    # Operations & Features
    "calendar": ("operations", "calendar.md", "Calendar"),
    "economics-properties": ("operations", "economics-properties.md", "Economics Properties"),
    "using-the-economics-tab": ("operations", "using-the-economics-tab.md", "Using the Economics Tab"),
    "using-economics-columns": ("operations", "using-economics-columns.md", "Using Economics Columns"),
    "pulse": ("operations", "pulse.md", "Pulse"),
    "pulse-properties": ("operations", "pulse-properties.md", "Pulse Properties"),
    "using-the-pulse-window": ("operations", "using-the-pulse-window.md", "Using the Pulse Window"),
    "using-time--sales-quotes": ("operations", "using-time--sales-quotes.md", "Using Time & Sales Quotes"),
    "order-flow-delta-bars": ("operations", "order-flow-delta-bars.md", "Order Flow Delta Bars"),
    "order-flow-price-on-volume-bars": ("operations", "order-flow-price-on-volume-bars.md", "Order Flow Price on Volume Bars"),

    # Indicators & Language Reference
    "commitment-of-traders-(cot)": ("indicators", "commitment_of_traders_cot.md", "Commitment of Traders (COT)"),
    "creating-chart-wpf-(ui)-modifi": ("ninjascript", "creating_chart_wpf_ui_modifications.md", "Creating Chart WPF UI Modifications"),
    "alert_rearmalert()": ("language_reference", "rearmalert.md", "RearmAlert()"),
    "chartbars_tochartstring()": ("language_reference", "tochartstring.md", "ToChartString()"),
    "draw_pathtool()": ("language_reference", "pathtool.md", "PathTool()"),
    "ntmessageboxsimple_show()": ("language_reference", "ntmessageboxsimple_show.md", "NTMessageBoxSimple.Show()"),
    "propagateinstrumentchange()": ("language_reference", "propagateinstrumentchange.md", "PropagateInstrumentChange()"),
    "propagateintervalchange()": ("language_reference", "propagateintervalchange.md", "PropagateIntervalChange()"),
}

def sync_images_from_html_branch():
    print("--- Step 1: Syncing images from origin/HTML ---")
    res = subprocess.run(["git", "ls-tree", "-r", "--name-only", "origin/HTML", "support/helpguides/nt8/"], capture_output=True, text=True)
    all_imgs = [p.strip() for p in res.stdout.splitlines() if any(p.lower().endswith(ext) for ext in [".png", ".jpg", ".jpeg", ".gif"])]

    local_imgs = {os.path.basename(f).lower() for f in glob.glob(os.path.join(IMAGES_DIR, "*"))}

    synced = 0
    for img_path in all_imgs:
        base_name = os.path.basename(img_path).lower()
        if base_name not in local_imgs:
            dest_path = os.path.join(IMAGES_DIR, base_name)
            img_data = subprocess.run(["git", "show", f"origin/HTML:{img_path}"], capture_output=True).stdout
            with open(dest_path, "wb") as f:
                f.write(img_data)
            local_imgs.add(base_name)
            synced += 1

    print(f"Synced {synced} new image assets to docs/images/ (Total: {len(local_imgs)} images).")

def convert_new_topics():
    print("--- Step 2: Converting newly added topics ---")
    from html_to_markdown_converter import HtmlToMarkdownParser

    converted = 0
    for slug, (cat, filename, title) in NEW_TOPIC_CATEGORIES.items():
        htm_name = f"support/helpguides/nt8/{slug}.htm"
        cat_res = subprocess.run(["git", "show", f"origin/HTML:{htm_name}"], capture_output=True, text=True, errors="ignore")
        if cat_res.returncode != 0:
            continue

        parser = HtmlToMarkdownParser(cat)
        parser.feed(cat_res.stdout)
        md_text = parser.get_markdown()

        # Ensure title at top
        if not md_text.startswith("# "):
            md_text = f"# {title}\n\n" + md_text

        out_path = os.path.join(DOCS_DIR, cat, filename)
        with open(out_path, "w", encoding="utf-8") as f:
            f.write(md_text)
        converted += 1
        print(f"  Converted {slug}.htm -> docs/{cat}/{filename}")

    print(f"Successfully converted {converted} new documentation articles.")

def run_pipeline():
    sync_images_from_html_branch()
    convert_new_topics()

    print("--- Step 3: Running table & formatting standardizer ---")
    subprocess.run(["python3", "tools/clean_tables.py"], cwd=REPO_ROOT)

    print("--- Step 4: Restoring media references across all docs ---")
    subprocess.run(["python3", "tools/restore_missing_media.py"], cwd=REPO_ROOT)

    print("--- Step 5: Replacing repetitive icon artifacts ---")
    subprocess.run(["python3", "tools/replace_icon_images.py"], cwd=REPO_ROOT)

    print("--- Step 6: Regenerating Master README and topic hubs ---")
    subprocess.run(["python3", "tools/generate_readme.py"], cwd=REPO_ROOT)

    print("--- Step 7: Verifying documentation links and assets ---")
    subprocess.run(["python3", "tools/verify_docs.py"], cwd=REPO_ROOT)

    print("--- Step 8: Running automated test suite ---")
    subprocess.run(["python3", "-m", "unittest", "discover", "-s", "tests"], cwd=REPO_ROOT)

if __name__ == "__main__":
    run_pipeline()
