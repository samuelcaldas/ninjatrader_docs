import glob
import re
from pathlib import Path

files = sorted(glob.glob("*.md"))
print(f"Checking {len(files)} markdown files...")

ns_remaining = 0
nav_remaining = 0
unmatched_fences = []
nbsp_remaining = 0
broken_links = []
md_set = set(files)
img_set = set(glob.glob("*.png") + glob.glob("*.jpg") + glob.glob("*.gif") + glob.glob("*.svg"))

for f in files:
    content = open(f, "r", encoding="utf-8", errors="ignore").read()
    if "| ns |" in content or "|ns|" in content:
        ns_remaining += 1
    if "Click to Display Table of Contents" in content:
        nav_remaining += 1
    if "\xa0" in content:
        nbsp_remaining += 1

    fences = len(re.findall(r"^```", content, re.MULTILINE))
    if fences % 2 != 0:
        unmatched_fences.append((f, fences))

    for m in re.finditer(r"\[([^\]]*)\]\(([^)\n]+)\)", content):
        raw_dest = m.group(2).strip()
        dest = raw_dest.split(' "')[0].split(" '")[0].split("#")[0].strip()
        if dest and not dest.startswith(("http://", "https://", "mailto:", "javascript:")):
            if dest not in md_set and dest not in img_set:
                broken_links.append((f, m.group(1), raw_dest))

print(f"ns tables remaining: {ns_remaining}")
print(f"nav tables remaining: {nav_remaining}")
print(f"nbsp remaining: {nbsp_remaining}")
print(f"unmatched fences: {len(unmatched_fences)}")
print(f"broken links: {len(broken_links)}")
for b in broken_links[:10]:
    print(" ", b)
