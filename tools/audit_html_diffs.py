#!/usr/bin/env python3
import os
import glob
import re
import subprocess

REPO_ROOT = os.path.abspath(os.path.join(os.path.dirname(__file__), ".."))
DOCS_DIR = os.path.join(REPO_ROOT, "docs")

NAV_TEMPLATES = {
    "leftarrow.png", "uparrow.png", "rightarrow.png",
    "leftarrow-1.png", "uparrow-1.png", "rightarrow-1.png",
    "warning_bar_0000_us.jpg", "tog_plus.gif", "tog_minus.gif",
    "zoom_minus.gif", "zoom_plus.gif", "return_arrow.png",
    "collapse.png", "expand.png", "hm_winarrow.gif", "top_menu.png",
    "link_arrow.png", "p_toggleheading.png"
}

def inspect_content_images():
    res = subprocess.run(["git", "ls-tree", "-r", "--name-only", "origin/HTML", "support/helpguides/nt8/"], capture_output=True, text=True)
    htm_files = [p.strip() for p in res.stdout.splitlines() if p.endswith(".htm")]

    md_files = glob.glob(os.path.join(DOCS_DIR, "**/*.md"), recursive=True)
    md_map = {os.path.splitext(os.path.basename(f))[0].lower(): f for f in md_files}

    missing_list = []

    for htm in htm_files:
        base = os.path.splitext(os.path.basename(htm))[0].lower()
        if base not in md_map:
            continue
        md_path = md_map[base]

        cat_res = subprocess.run(["git", "show", f"origin/HTML:{htm}"], capture_output=True, text=True, errors="ignore")
        html_content = cat_res.stdout

        raw_html_imgs = re.findall(r'<img[^>]+src=["\']([^"\']+)["\']', html_content, re.IGNORECASE)
        content_imgs = []
        for img in raw_html_imgs:
            name = os.path.basename(img).lower()
            if name not in NAV_TEMPLATES and not any(x in name for x in ["tog_", "zoom_", "arrow"]):
                content_imgs.append(name)

        with open(md_path, "r", encoding="utf-8", errors="ignore") as f:
            md_content = f.read()

        md_imgs = [os.path.basename(img).lower() for img in re.findall(r'!\[[^\]]*\]\(([^)#\s]+)', md_content)]

        missing = [img for img in content_imgs if img not in md_imgs]
        if missing:
            missing_list.append((md_path, htm, missing, content_imgs))

    print(f"Total documents with REAL missing content images: {len(missing_list)}")
    for md_path, htm, missing, all_imgs in missing_list:
        print(f"{os.path.relpath(md_path, REPO_ROOT)}: missing {missing} (total in html: {len(all_imgs)})")

if __name__ == "__main__":
    inspect_content_images()
