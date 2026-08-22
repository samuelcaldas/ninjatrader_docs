#!/usr/bin/env python3
import urllib.request
import re

url = "https://ninjatrader.com/support/helpGuides/nt8/hmcontent.htm"
req = urllib.request.Request(url, headers={"User-Agent": "Mozilla/5.0"})
with urllib.request.urlopen(req, timeout=10) as resp:
    data = resp.read().decode("utf-8", errors="ignore")
    print(f"hmcontent.htm len: {len(data)}")
    links = set(re.findall(r'href=["\']([^"\']+\.htm)["\']', data, re.IGNORECASE))
    print(f"Unique topic links in hmcontent.htm: {len(links)}")
    print(f"Sample links: {list(links)[:10]}")
