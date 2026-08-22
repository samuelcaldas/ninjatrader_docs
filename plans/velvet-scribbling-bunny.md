# Plan: Repository Reorganization (`docs/` Hierarchy via `git mv`) & GitHub Wiki Deployment

## Context
The repository `samuelcaldas/ninjatrader_docs` contains 1,556 Markdown documentation files and 1,168 image assets sitting directly in the repository root alongside code samples, tools, and tests.
The user requested:
1. **Clean up the repository root**: Reorganize all 1,556 markdown files and 1,168 image assets into a clean, logical directory folder tree under `docs/` based on `README.md` chapters.
2. **Preserve Git History**: Use `git mv` explicitly for every single file relocation so Git history and blame are 100% preserved.
3. **Transform into GitHub Wiki**: Deploy the documentation as a live, fully navigable GitHub Wiki at `https://github.com/samuelcaldas/ninjatrader_docs/wiki` using `gh` CLI, GitHub API, and Git wiki remote synchronization.

---

## 1. Target Repository Structure (`docs/` Hierarchy)

Based on the structure and chapters in `README.md`, all files will be organized into logical subdirectories under `docs/`:

```text
ninjatrader_docs/
├── README.md                            # Master repository landing page & documentation index
├── CLAUDE.md                            # Repository & agent instructions
├── samples/                             # NinjaScript C# sample projects & zip bundles
├── content/                             # Distribution packages / binaries
├── tools/                               # Migration, restructuring, and deployment scripts
│   ├── reorganize_docs.py               # Generates mapping, executes git mv, and updates relative links
│   ├── deploy_wiki.py                   # Stages & synchronizes docs to GitHub Wiki remote
│   └── verify_docs.py                   # Integrity check for links, images, and formatting across docs/
├── tests/                               # Automated static tests & validation gates
│   ├── test_repository_validation.py    # Validates links, fences, and assets in docs/ tree
│   └── test_wiki_deployment.py          # Validates wiki staging, sidebar, and deployment
└── docs/
    ├── README.md                        # Documentation table of contents with updated relative paths
    ├── images/                          # All screenshots, icons, and visual diagrams (1,168 images)
    ├── getting_started/                 # welcome, introduction, installation, licensing, accounts
    ├── operations/                      # Charting, SuperDOM, Strategy Analyzer, Market Analyzer
    ├── ninjascript/                     # Lifecycle (OnStateChange, OnBarUpdate), State, Core architecture
    ├── language_reference/              # General C# API classes, methods, properties, and events
    ├── indicators/                      # Technical indicators reference (SMA, RSI, EMA, Volumetric, etc.)
    ├── strategies/                      # Strategy development, order methods, position management
    ├── drawing_tools/                   # Drawing tools, chart anchors, and SharpDX Direct2D graphics
    ├── addons/                          # AddOn development, WPF controls, custom windows, menus
    └── release_notes/                   # Version release notes (8.0 through 8.1.3.1) and migration guides
```

---

## 2. Implementation Phases

### Phase 1: Repository Root Cleanup & Folder Tree Restructuring using `git mv`
1. **Create Mapping Engine (`tools/reorganize_docs.py`)**:
   - Parses `README.md` sections to map all 1,556 markdown files into target subdirectories under `docs/`.
   - Maps all 1,168 image assets (`*.png`, `*.jpg`, `*.gif`, `*.svg`) to `docs/images/`.
   - Creates the destination folders under `docs/`.
2. **Execute Relocations via `git mv`**:
   - Executes `git mv <source_file> <target_destination>` for each markdown file and image asset to maintain full Git commit history.
3. **Cross-Document Relative Link & Asset Path Rewriting**:
   - Inter-category links: `[Text](../category/filename.md)`.
   - Intra-category links: `[Text](filename.md)`.
   - Image embeds: `![alt](../images/image.png)`.
   - `README.md` and `docs/README.md`: Links updated to point to `docs/<category>/filename.md`.
4. **Update Verification & Test Suite**:
   - Update `tools/verify_docs.py` and `tests/test_repository_validation.py` to recursively scan `docs/` and verify:
     - 0 broken relative markdown links.
     - 0 missing image asset references.
     - 0 unbalanced code block fences.
     - Clean repo root containing only project root files (`README.md`, `CLAUDE.md`, `docs/`, `samples/`, `content/`, `tools/`, `tests/`).

### Phase 2: GitHub Wiki Deployment Automation (`tools/deploy_wiki.py`)
1. **GitHub Wiki Specifics**:
   - GitHub Wiki repository is a flat Git repository (`git@github.com:samuelcaldas/ninjatrader_docs.wiki.git`).
   - `Home.md`: Generated from `welcome.md` / `README.md` as the main landing portal.
   - `_Sidebar.md`: Multi-section, collapsible sidebar navigation menu constructed from `README.md` category headings.
   - `_Footer.md`: Global footer linking back to the source code repository, samples, and issues.
2. **Staging & Flattening Engine**:
   - Stages all `docs/**/*.md` files into a temporary build directory `.wiki_dist/`.
   - Converts relative folder paths (`../category/page.md`) into flat Wiki links (`page` or `page.md`).
   - Copies `docs/images/*` to the wiki root.
3. **Deployment via `gh` & Git**:
   - Verifies `has_wiki: true` via `gh api`.
   - Initializes/configures git remote in `.wiki_dist/`.
   - Commits with descriptive message and pushes to `origin master` of the wiki repository.

### Phase 3: Automated Testing & Verification
1. **`tests/test_repository_validation.py`**:
   - Asserts 0 broken links across all subfolders in `docs/`.
   - Asserts 0 missing images in `docs/images/`.
   - Asserts all code fences and markdown headings are valid.
2. **`tests/test_wiki_deployment.py`**:
   - Validates `Home.md`, `_Sidebar.md`, and `_Footer.md` generation.
   - Asserts 100% of wiki internal links resolve to staged wiki pages.
3. **Remote Live Verification**:
   - Use `gh browse --wiki` / `git ls-remote` to confirm wiki deployment on GitHub.

---

## 3. Verification & Acceptance Criteria
- [ ] Every file move is performed via `git mv` ensuring `git log --follow` preserves all historical revisions.
- [ ] Root directory is clean (only `README.md`, `CLAUDE.md`, `docs/`, `samples/`, `content/`, `tools/`, `tests/`).
- [ ] All 1,556 documentation files reside in appropriate `docs/<category>/` folders.
- [ ] `python3 -m unittest discover -s tests` passes 100% of link and asset verification tests.
- [ ] GitHub Wiki at `https://github.com/samuelcaldas/ninjatrader_docs/wiki` is populated with `Home.md`, `_Sidebar.md`, `_Footer.md`, all docs, and all images.
