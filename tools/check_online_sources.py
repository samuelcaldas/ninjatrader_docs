#!/usr/bin/env python3
import urllib.request
import re

urls = [
    "https://ninjatrader.com/support/helpGuides/nt8/NT%20HelpGuide%20English.html",
    "https://ninjatrader.com/support/helpGuides/nt8/NT%20HelpGuide%20English_toc.html",
    "https://ninjatrader.com/support/helpGuides/nt8/hmcontent.html",
    "https://ninjatrader.com/support/helpGuides/nt8/cslh_toc.html",
    "https://ninjatrader.com/support/helpGuides/nt8/index.html",
    "https://ninjatrader.com/support/helpGuides/nt8/toc.html"
]

for u in urls:
    try:
        req = urllib.request.Request(u, headers={"User-Agent": "Mozilla/5.0"})
        with urllib.request.urlopen(req, timeout=10) as resp:
            data = resp.read().decode("utf-8", errors="ignore")
            print(f"URL: {u} -> Status: 200, Len: {len(data)}")
            # look for frame src or toc links
            frames = re.findall(r'src=["\']([^"\']+)["\']', data, re.IGNORECASE)
            if frames:
                print(f"  Frames/Scripts found: {frames[:5]}")
    except Exception as e:
        print(f"URL: {u} -> {e}")
