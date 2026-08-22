#!/usr/bin/env python3
"""
tools/generate_readme.py

Generates the enhanced, polished root README.md with executive overview,
repository architecture, quick hubs, sample references, and the full index.
"""

import os
import re

REPO_ROOT = os.path.abspath(os.path.join(os.path.dirname(__file__), ".."))
README_PATH = os.path.join(REPO_ROOT, "README.md")
DOCS_README_PATH = os.path.join(REPO_ROOT, "docs", "README.md")

HEADER = """# NinjaTrader 8 Documentation & NinjaScript Reference

<p align="center">
  <img src="docs/images/nt8logo.png" alt="NinjaTrader 8 Logo" width="280"/>
</p>

<p align="center">
  <strong>Comprehensive, searchable Markdown documentation, NinjaScript C# API reference, and development guides for NinjaTrader 8 (NT8).</strong>
</p>

---

## 📚 Table of Contents

- [Overview](#-overview)
- [Repository Structure](#-repository-structure)
- [Key Documentation Hubs](#-key-documentation-hubs)
- [NinjaScript Samples & Code](#-ninjascript-samples--code)
- [Tools & Automated Verification](#-tools--automated-verification)
- [Full Documentation Index](#-full-documentation-index)

---

## 📖 Overview

This repository provides the complete offline-ready reference library for NinjaTrader 8 and NinjaScript programming. All 1,556 documentation files and 1,168 image assets are organized into modular, categorized folders under [`docs/`](docs/) with full Git history preserved.

- **1,550+ Documentation Articles**: In-depth coverage across configuration, trading operations, order management, indicators, automated strategies, SharpDX Direct2D rendering, and AddOn UI development.
- **1,160+ Visual Assets**: Screenshots, UI guides, indicator configuration examples, and Direct2D coordinate diagrams in [`docs/images/`](docs/images/).
- **Working Reference Samples**: Reference NinjaScript C# source code projects in [`samples/`](samples/).

---

## 🗂 Repository Structure

```text
ninjatrader_docs/
├── README.md                            # Main repository documentation portal & master index
├── CLAUDE.md                            # Repository & agent instructions
├── docs/                                # Full documentation tree
│   ├── images/                          # Visual diagrams, screenshots, and icons (1,168 assets)
│   ├── getting_started/                 # Installation, licensing, connections, workspaces
│   ├── operations/                      # Charts, SuperDOM, Market Analyzer, Order Entry
│   ├── ninjascript/                     # NinjaScript lifecycle, editor, best practices
│   ├── language_reference/              # C# API classes, methods, properties, and events
│   ├── indicators/                      # Technical indicators reference (SMA, RSI, Volumetric, etc.)
│   ├── strategies/                      # Strategy development, order methods, position management
│   ├── drawing_tools/                   # Drawing tools, chart anchors, and SharpDX Direct2D
│   ├── addons/                          # AddOn development, WPF controls, custom menus & tabs
│   └── release_notes/                   # Release history (8.0 through 8.1.3.1)
├── samples/                             # C# NinjaScript reference projects and bundles
├── content/                             # Distribution packages and installer tools
├── tools/                               # Migration, restructuring, and verification scripts
│   ├── reorganize_docs.py               # Document classification and link rewriter
│   ├── deploy_wiki.py                   # GitHub Wiki staging and flattening engine
│   ├── generate_readme.py               # Master README generator
│   └── verify_docs.py                   # Integrity check for links, images, and formatting
└── tests/                               # Automated test suite
    ├── test_repository_validation.py    # Link, image, and structure tests
    └── test_wiki_deployment.py          # Wiki staging and sidebar tests
```

---

## 🚀 Key Documentation Hubs

| Category | Description | Primary Hubs |
| :--- | :--- | :--- |
| **Getting Started** | Setup, licensing, data connections, and workspace options | [Introduction](docs/getting_started/introduction.md) • [Installation](docs/getting_started/installation.md) • [Connecting](docs/getting_started/connecting.md) |
| **Operations** | SuperDOM, Charting, Market Analyzer, Alert Log, and ATI | [Operations Guide](docs/operations/operations.md) • [Charts](docs/operations/charts.md) • [SuperDOM](docs/strategies/superdom.md) |
| **NinjaScript Core** | Lifecycle, state management, event hooks, and threading | [Lifecycle](docs/ninjascript/understanding_the_lifecycle_of.md) • [Best Practices](docs/ninjascript/ninjascript_best_practices.md) |
| **Language Reference** | Complete C# NinjaScript API reference | [Language Reference](docs/language_reference/language_reference_wip.md) • [Alphabetical Index](docs/language_reference/alphabetical_reference.md) |
| **Indicators** | Technical indicator calculations, plots, and series methods | [Indicators Reference](docs/indicators/indicators.md) • [Developing Indicators](docs/indicators/developing_indicators.md) |
| **Strategies** | Automated trade execution, ATM templates, and backtesting | [Strategy Guide](docs/strategies/strategy.md) • [Strategy Analyzer](docs/strategies/strategy_analyzer.md) |
| **Drawing & Graphics** | Chart anchors, custom shapes, and SharpDX Direct2D | [Drawing Tools](docs/drawing_tools/drawing_tools.md) • [SharpDX SDK](docs/drawing_tools/sharpdx_sdk_reference.md) |
| **AddOns & UI** | Custom WPF windows, Control Center menus, and tab factories | [AddOn Overview](docs/ninjascript/addon_development_overview.md) • [NTWindow](docs/addons/ntwindow.md) |
| **Release Notes** | Version changelogs and API migration guides | [Release Notes](docs/release_notes/release_notes.md) • [Code Breaking Changes](docs/ninjascript/code_breaking_changes.md) |

---

## 💻 NinjaScript Samples & Code

The [`samples/`](samples/) directory contains official NinjaTrader 8 reference implementations:

- **Indicators**: Sample indicator logic, plot styles, multi-time-frame access, and custom chart rendering.
- **Strategies**: ATM strategy integration, multi-instrument execution, and risk management.
- **AddOns & WPF Windows**: Custom window integration via `NTWindow`, menu integration, and WPF XAML controls.

---

## 🛠 Tools & Automated Verification

Validate documentation integrity or stage for wiki deployment:

```bash
# Verify 100% of markdown links and image assets across all documents
python3 tools/verify_docs.py

# Run unit tests for structure and link integrity
python3 -m unittest discover -s tests

# Stage flat GitHub Wiki distribution
python3 tools/deploy_wiki.py --stage-only
```

---

## 📑 Full Documentation Index

"""

def update_readme():
    with open(DOCS_README_PATH, "r", encoding="utf-8") as f:
        docs_readme = f.read()

    # Clean double brackets from index
    cleaned_toc = docs_readme
    # Fix the using [] brackets literal
    cleaned_toc = cleaned_toc.replace('[[[Using [] brackets](ninjascript/using__brackets.md)', '[Using [] brackets](ninjascript/using__brackets.md)')
    cleaned_toc = re.sub(r'\[+([^\]]+)\]+\(([^)]+)\)', r'[\1](\2)', cleaned_toc)

    # Remove leading header from docs/README if present
    cleaned_toc = re.sub(r'^\[!\[Back to Index\].*?\n+---\n+', '', cleaned_toc, flags=re.DOTALL)

    # Convert relative paths from docs/ to root
    lines = cleaned_toc.splitlines()
    new_lines = []
    for line in lines:
        if '(' in line and ')' in line and ']' in line:
            # Replace target with docs/<target> if not starting with http/mailto/#/docs/
            def repl(m):
                prefix = m.group(1)
                label = m.group(2)
                target = m.group(3)
                if target.startswith("http") or target.startswith("mailto") or target.startswith("#") or target.startswith("docs/"):
                    return f"{prefix}[{label}]({target})"
                return f"{prefix}[{label}](docs/{target})"
            line = re.sub(r'(!?\[)(.*?)\]\(([^)#\s]+(?:#[^)\s]*)?)\)', repl, line)
        new_lines.append(line)

    full_readme = HEADER + "\n".join(new_lines) + "\n"

    with open(README_PATH, "w", encoding="utf-8") as f:
        f.write(full_readme)

    print("README.md successfully updated!")

if __name__ == "__main__":
    update_readme()
