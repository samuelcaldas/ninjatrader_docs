#!/usr/bin/env python3
"""
tools/deploy_wiki.py

Stages and synchronizes the NinjaTrader 8 documentation to GitHub Wiki.
GitHub Wikis are flat Git repositories (`git@github.com:samuelcaldas/ninjatrader_docs.wiki.git`).
This script:
1. Flattens docs/ directory into a temporary build directory (.wiki_dist/).
2. Generates Home.md, _Sidebar.md, and _Footer.md.
3. Rewrites internal folder links into flat Wiki links.
4. Copies all images directly to the wiki root.
5. Commits and pushes to the GitHub Wiki remote.
"""

import os
import re
import sys
import shutil
import glob
import subprocess

REPO_ROOT = os.path.abspath(os.path.join(os.path.dirname(__file__), ".."))
DOCS_DIR = os.path.join(REPO_ROOT, "docs")
IMAGES_DIR = os.path.join(DOCS_DIR, "images")
WIKI_DIST = os.path.join(REPO_ROOT, ".wiki_dist")

def generate_sidebar(readme_path):
    """Generates a structured _Sidebar.md from README.md table of contents."""
    with open(readme_path, "r", encoding="utf-8") as f:
        lines = f.readlines()

    sidebar_lines = [
        "# [NinjaTrader 8 Wiki](Home)\n",
        "- [Home](Home)",
        "- [Documentation Index](README)\n",
    ]

    for line in lines:
        stripped = line.strip()
        if not stripped:
            continue

        # Check for top-level headers in list or headings
        if line.startswith("#"):
            level = len(line) - len(line.lstrip("#"))
            title = line.strip("# \t\n")
            if level == 1:
                continue
            elif level == 2:
                sidebar_lines.append(f"\n### {title}\n")
            elif level == 3:
                sidebar_lines.append(f"**{title}**\n")
        elif line.startswith("* [[") or line.startswith("* ["):
            # Top-level item
            match = re.search(r'\[+([^\]]+)\]+\(([^)#\s]+(?:#[^)\s]*)?)\)', line)
            if match:
                title = match.group(1).lstrip("[")
                target = match.group(2)
                if target.startswith("http") or target.startswith("mailto"):
                    sidebar_lines.append(f"\n### [{title}]({target})\n")
                else:
                    parts = target.split("#", 1)
                    filename = os.path.basename(parts[0])
                    page_name = os.path.splitext(filename)[0]
                    anchor = f"#{parts[1]}" if len(parts) > 1 else ""
                    sidebar_lines.append(f"\n### [{title}]({page_name}{anchor})\n")
        elif stripped.startswith("+ [") or stripped.startswith("+ [["):
            match = re.search(r'\[+([^\]]+)\]+\(([^)#\s]+(?:#[^)\s]*)?)\)', line)
            if match:
                title = match.group(1).lstrip("[")
                target = match.group(2)
                if target.startswith("http") or target.startswith("mailto"):
                    sidebar_lines.append(f"**[{title}]({target})**")
                else:
                    parts = target.split("#", 1)
                    filename = os.path.basename(parts[0])
                    page_name = os.path.splitext(filename)[0]
                    anchor = f"#{parts[1]}" if len(parts) > 1 else ""
                    sidebar_lines.append(f"**[{title}]({page_name}{anchor})**")
        elif stripped.startswith("- [") or stripped.startswith("- [[") or stripped.startswith("* ["):
            match = re.search(r'\[+([^\]]+)\]+\(([^)#\s]+(?:#[^)\s]*)?)\)', line)
            if match:
                title = match.group(1).lstrip("[")
                target = match.group(2)
                if target.startswith("http") or target.startswith("mailto"):
                    sidebar_lines.append(f"- [{title}]({target})")
                else:
                    parts = target.split("#", 1)
                    filename = os.path.basename(parts[0])
                    page_name = os.path.splitext(filename)[0]
                    anchor = f"#{parts[1]}" if len(parts) > 1 else ""
                    sidebar_lines.append(f"- [{title}]({page_name}{anchor})")

    return "\n".join(sidebar_lines)

def stage_wiki():
    """Flattens docs into .wiki_dist with wiki-compliant links."""
    print("Staging GitHub Wiki distribution in .wiki_dist/...")
    if os.path.exists(WIKI_DIST):
        shutil.rmtree(WIKI_DIST)
    os.makedirs(WIKI_DIST, exist_ok=True)

    # 1. Copy images directly to wiki root
    print("Copying images to wiki distribution root...")
    img_files = glob.glob(os.path.join(IMAGES_DIR, "*"))
    for img in img_files:
        shutil.copy2(img, WIKI_DIST)

    # 2. Gather all markdown files
    all_md_files = glob.glob(os.path.join(DOCS_DIR, "**/*.md"), recursive=True)
    img_extensions = ('.png', '.jpg', '.jpeg', '.gif', '.svg', '.bmp', '.ico')

    # 3. Process markdown files
    for md_path in all_md_files:
        filename = os.path.basename(md_path)
        dest_path = os.path.join(WIKI_DIST, filename)

        with open(md_path, "r", encoding="utf-8", errors="ignore") as f:
            text = f.read()

        def rewrite_for_wiki(match):
            prefix = match.group(1) # '[' or '!['
            label = match.group(2)
            target = match.group(3)

            if target.startswith("http://") or target.startswith("https://") or target.startswith("mailto:"):
                return f"{prefix}[{label}]({target})"
            if target.startswith("#"):
                return f"{prefix}[{label}]({target})"

            parts = target.split("#", 1)
            target_filename = os.path.basename(parts[0])
            anchor = f"#{parts[1]}" if len(parts) > 1 else ""
            ext = os.path.splitext(target_filename)[1].lower()

            if ext in img_extensions:
                # Image in wiki root
                return f"{prefix}[{label}]({target_filename}{anchor})"
            elif ext == ".md":
                # Flat wiki page link
                page_name = os.path.splitext(target_filename)[0]
                return f"{prefix}[{label}]({page_name}{anchor})"

            return f"{prefix}[{label}]({target})"

        pattern = r'(!?\[)(.*?)\]\(([^)#\s]+(?:#[^)\s]*)?)\)'
        wiki_text = re.sub(pattern, rewrite_for_wiki, text)

        with open(dest_path, "w", encoding="utf-8") as f:
            f.write(wiki_text)

    # 4. Generate Home.md (from welcome.md or docs/README.md)
    welcome_path = os.path.join(WIKI_DIST, "welcome.md")
    home_path = os.path.join(WIKI_DIST, "Home.md")
    if os.path.exists(welcome_path):
        shutil.copy2(welcome_path, home_path)
    else:
        shutil.copy2(os.path.join(WIKI_DIST, "README.md"), home_path)

    # 5. Generate _Sidebar.md
    sidebar_content = generate_sidebar(os.path.join(DOCS_DIR, "README.md"))
    with open(os.path.join(WIKI_DIST, "_Sidebar.md"), "w", encoding="utf-8") as f:
        f.write(sidebar_content)

    # 6. Generate _Footer.md
    footer_content = """---
[NinjaTrader 8 Documentation Repository](https://github.com/samuelcaldas/ninjatrader_docs) | [C# Reference Samples](https://github.com/samuelcaldas/ninjatrader_docs/tree/markdown/samples) | [Issues & Feedback](https://github.com/samuelcaldas/ninjatrader_docs/issues)
"""
    with open(os.path.join(WIKI_DIST, "_Footer.md"), "w", encoding="utf-8") as f:
        f.write(footer_content)

    print(f"Staged {len(os.listdir(WIKI_DIST))} files in .wiki_dist/")

def deploy_wiki(dry_run=False):
    """Initializes and pushes .wiki_dist to GitHub Wiki remote."""
    stage_wiki()

    auth_token = os.environ.get("GH_TOKEN") or os.environ.get("GITHUB_TOKEN")
    repo_slug = os.environ.get("GITHUB_REPOSITORY", "samuelcaldas/ninjatrader_docs")

    print(f"Deploying to GitHub Wiki: {repo_slug}.wiki")

    if dry_run:
        print("Dry run requested. Staging complete, skipping push.")
        return

    cwd = os.getcwd()
    try:
        os.chdir(WIKI_DIST)
        subprocess.run(["git", "init"], check=True)
        subprocess.run(["git", "config", "user.name", "github-actions[bot]"], check=True)
        subprocess.run(["git", "config", "user.email", "41898282+github-actions[bot]@users.noreply.github.com"], check=True)
        subprocess.run(["git", "add", "-A"], check=True)
        commit_msg = "Deploy NinjaTrader 8 complete documentation and assets to GitHub Wiki"
        subprocess.run(["git", "commit", "-m", commit_msg], check=True)

        if auth_token:
            wiki_remote = f"https://x-access-token:{auth_token}@github.com/{repo_slug}.wiki.git"
        else:
            wiki_remote = f"git@github.com:{repo_slug}.wiki.git"

        print("Checking remote wiki repository and pushing...")
        res = subprocess.run(["git", "push", "--force", wiki_remote, "master"], capture_output=True, text=True)
        if res.returncode == 0:
            print("Wiki successfully deployed to GitHub!")
        else:
            # Mask any token from output if present
            err_msg = res.stderr.strip() or res.stdout.strip()
            if auth_token and auth_token in err_msg:
                err_msg = err_msg.replace(auth_token, "***")
            print(f"Wiki push notice: {err_msg}")
            if os.environ.get("GITHUB_ACTIONS"):
                sys.exit(res.returncode)
    finally:
        os.chdir(cwd)

if __name__ == "__main__":
    import argparse
    parser = argparse.ArgumentParser(description="Stage and deploy NinjaTrader 8 documentation to GitHub Wiki.")
    parser.add_argument("--stage-only", action="store_true", help="Stage wiki distribution without deploying.")
    parser.add_argument("--dry-run", action="store_true", help="Perform staging and local commit check without pushing.")
    args = parser.parse_args()

    if args.stage_only:
        stage_wiki()
    else:
        deploy_wiki(dry_run=args.dry_run)
