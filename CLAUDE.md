# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Repository Overview

This repository contains the complete documentation, C# reference samples, and tooling for **NinjaTrader 8 (NT8)** and **NinjaScript**. The documentation is structured in Markdown under categorized directories with automated GitHub Wiki deployment and link verification pipelines.

## Source of Truth & Reference Branches

- **`origin/HTML` (Source of Truth)**: Contains the original unmodified Help & Manual HTML documentation files (`support/helpguides/nt8/*.htm`) and image assets. When refactoring formatting, repairing broken tables, or recovering missing text, consult `origin/HTML` as the ground truth.
  ```bash
  # Inspect original HTML source for an article
  git show origin/HTML:support/helpguides/nt8/<topic_name>.htm
  ```
- **`markdown` (Active Development)**: The primary working branch containing clean Markdown files under `docs/`, organized into 9 categorized subfolders.

## Repository Architecture

```text
ninjatrader_docs/
├── README.md                            # Documentation landing portal with category hubs
├── .github/workflows/deploy-wiki.yml    # CI/CD pipeline for validation and Wiki deployment
├── docs/                                # Full documentation tree (1,550+ Markdown articles)
│   ├── README.md                        # Master alphabetical topic index
│   ├── images/                          # Visual diagrams, UI screenshots, and icons (1,168 assets)
│   ├── getting_started/README.md        # Platform setup, licensing, and workspaces (39 articles)
│   ├── operations/README.md             # Charting, SuperDOM, Market Analyzer, and ATI (158 articles)
│   ├── ninjascript/README.md            # NinjaScript core lifecycle and best practices (84 articles)
│   ├── language_reference/README.md     # C# API reference (classes, methods, properties) (454 articles)
│   ├── indicators/README.md             # Indicator calculations, plots, and series (197 articles)
│   ├── strategies/README.md             # Automated trade execution, ATM templates, backtests (310 articles)
│   ├── drawing_tools/README.md          # Drawing tools and SharpDX Direct2D reference (169 articles)
│   ├── addons/README.md                 # AddOns and custom WPF NTWindow interfaces (93 articles)
│   └── release_notes/README.md          # Version changelogs and API migration guides (50 articles)
├── samples/                             # Official NinjaTrader 8 reference C# and WPF projects
├── content/                             # Distribution packages and installer tools
├── tools/                               # Maintenance and deployment automation scripts
│   ├── clean_tables.py                  # Table standardizer, toggle unwrapper, code highlighter
│   ├── deploy_wiki.py                   # GitHub Wiki flattener, sidebar generator, and deployer
│   ├── generate_readme.py               # Master README and category index builder
│   ├── replace_icon_images.py           # Repetitive decorative icon to Unicode/Markdown converter
│   ├── restore_missing_media.py         # Image & diagram restorer from origin/HTML
│   ├── scrape_nt8_docs.py               # Multi-threaded crawler for official online docs
│   ├── sync_and_convert_docs.py         # Full automated sync, conversion, and validation pipeline
│   └── verify_docs.py                   # Strict markdown link and image validator
└── tests/                               # Automated Python test suite
    ├── test_repository_validation.py    # Link, image, and structure unit tests
    └── test_wiki_deployment.py          # Wiki distribution staging and sidebar tests
```

## Common Operations & Commands

### 1. Document Validation & Tests

- **Run Full Test Suite**:
  ```bash
  python3 -m unittest discover -s tests
  ```

- **Run a Specific Test File or Case**:
  ```bash
  python3 -m unittest tests/test_repository_validation.py
  python3 -m unittest tests.test_wiki_deployment.TestWikiDeployment.test_sidebar_generation
  ```

- **Validate Markdown Links & Image Assets**:
  ```bash
  python3 tools/verify_docs.py
  ```

### 2. Maintenance & Formatting Automation

- **Run Full Automated Crawl, Sync, Conversion & Verification Pipeline**:
  ```bash
  python3 tools/sync_and_convert_docs.py
  ```

- **Scrape Latest Official Online Documentation**:
  ```bash
  python3 tools/scrape_nt8_docs.py
  ```

- **Restore Missing Media & Diagrams from `origin/HTML`**:
  ```bash
  python3 tools/restore_missing_media.py
  ```

- **Replace Repetitive Decorative Icons with Unicode/Markdown**:
  ```bash
  python3 tools/replace_icon_images.py
  ```

- **Clean & Standardize Tables, Code Blocks, and Toggles**:
  ```bash
  python3 tools/clean_tables.py
  ```

- **Regenerate Master README and Subfolder Index Hubs**:
  ```bash
  python3 tools/generate_readme.py
  ```

### 3. GitHub Wiki Staging & Deployment

- **Stage Flat GitHub Wiki Distribution (Dry Run)**:
  ```bash
  python3 tools/deploy_wiki.py --stage-only
  ```

- **Deploy Wiki with Git Authentication**:
  ```bash
  python3 tools/deploy_wiki.py
  ```

## Working with NinjaScript Samples (`samples/`)

- C# source files follow NinjaTrader 8 directory layout: `Indicators/`, `Strategies/`, and `AddOns/`.
- UI extensions utilize WPF (`System.Windows.Controls`, XAML) and `NTWindow` helper classes (`samples/NinjaTraderAddOnProject/` and `samples/Addon_Framework_NinjaScript_Basic/`).
- Direct2D custom rendering utilizes SharpDX (`SharpDX.Direct2D1`, `SharpDX.DirectWrite`).
