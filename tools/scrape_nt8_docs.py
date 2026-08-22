#!/usr/bin/env python3
"""
tools/scrape_nt8_docs.py

Asynchronous multi-threaded scraper for NinjaTrader 8 documentation:
- Crawls all topics referenced in TOC, context maps, and internal hyperlinks.
- Downloads HTML articles, CSS styles, JavaScript configs, and all image assets.
- Stores output in support/helpguides/nt8/ ready for git commit to HTML branch.
"""

import os
import re
import urllib.request
import urllib.parse
from concurrent.futures import ThreadPoolExecutor, as_completed

BASE_URL = "https://ninjatrader.com/support/helpGuides/nt8/"
OUTPUT_DIR = os.path.abspath(os.path.join(os.path.dirname(__file__), "..", "support", "helpguides", "nt8"))

HEADERS = {
    "User-Agent": "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36"
}

def fetch_url(url):
    req = urllib.request.Request(url, headers=HEADERS)
    with urllib.request.urlopen(req, timeout=15) as resp:
        return resp.read()

def download_asset(filename):
    out_path = os.path.join(OUTPUT_DIR, filename)
    url = urllib.parse.urljoin(BASE_URL, urllib.parse.quote(filename))
    try:
        data = fetch_url(url)
        with open(out_path, "wb") as f:
            f.write(data)
        return (filename, True, len(data))
    except Exception as e:
        return (filename, False, str(e))

def discover_all_topics():
    os.makedirs(OUTPUT_DIR, exist_ok=True)
    visited_pages = set()
    queue = ["hmcontent.htm", "NT HelpGuide English.html", "index.html", "welcome.htm"]
    all_images = set()
    all_scripts = set()

    print("--- Phase 1: Crawling topics and assets ---")
    while queue:
        page = queue.pop(0)
        if page in visited_pages:
            continue
        visited_pages.add(page)

        url = urllib.parse.urljoin(BASE_URL, urllib.parse.quote(page))
        try:
            raw_bytes = fetch_url(url)
            out_path = os.path.join(OUTPUT_DIR, page)
            with open(out_path, "wb") as f:
                f.write(raw_bytes)

            text = raw_bytes.decode("utf-8", errors="ignore")

            # Extract links
            links = re.findall(r'href=["\']([^"\']+\.htm[l]?)["\']', text, re.IGNORECASE)
            for link in links:
                clean_link = link.split("#")[0].split("?")[0]
                if clean_link and not clean_link.startswith("http") and clean_link not in visited_pages:
                    queue.append(clean_link)

            # Extract images
            imgs = re.findall(r'src=["\']([^"\']+\.(png|jpg|jpeg|gif|bmp|svg|ico))["\']', text, re.IGNORECASE)
            for img_match in imgs:
                img_name = img_match[0].split("?")[0]
                if not img_name.startswith("http"):
                    all_images.add(img_name)

            # Extract scripts/styles
            assets = re.findall(r'src=["\']([^"\']+\.(js|css))["\']', text, re.IGNORECASE)
            for asset_match in assets:
                asset_name = asset_match[0].split("?")[0]
                if not asset_name.startswith("http"):
                    all_scripts.add(asset_name)

        except Exception as e:
            print(f"Error crawling {page}: {e}")

    print(f"Discovered {len(visited_pages)} HTML pages, {len(all_images)} images, {len(all_scripts)} scripts/styles.")

    # Phase 2: Parallel download of images and scripts
    all_media = list(all_images.union(all_scripts))
    print(f"--- Phase 2: Downloading {len(all_media)} media assets in parallel ---")

    success_count = 0
    with ThreadPoolExecutor(max_workers=16) as executor:
        futures = {executor.submit(download_asset, media): media for media in all_media}
        for future in as_completed(futures):
            name, success, info = future.result()
            if success:
                success_count += 1
            else:
                pass

    print(f"Completed download: {len(visited_pages)} HTML topics and {success_count}/{len(all_media)} media assets saved to {OUTPUT_DIR}.")

if __name__ == "__main__":
    discover_all_topics()
