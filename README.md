# NinjaTrader 8 Documentation & NinjaScript Reference

<p align="center">
  <img src="docs/images/nt8logo.png" alt="NinjaTrader 8 Logo" width="280"/>
</p>

<p align="center">
  <strong>Comprehensive, searchable Markdown documentation, NinjaScript C# API reference, and development guides for NinjaTrader 8 (NT8).</strong>
</p>

---

## 📚 Table of Contents

- [Overview](#-overview)
- [Documentation Sections & Sub-Indices](#-documentation-sections--sub-indices)
- [Repository Structure](#-repository-structure)
- [NinjaScript Samples & Code](#-ninjascript-samples--code)
- [Tools & Automated Verification](#-tools--automated-verification)
- [Full Master Index](#-full-master-index)

---

## 📖 Overview

This repository provides the complete offline-ready reference library for NinjaTrader 8 and NinjaScript programming. All 1,556 documentation files and 1,168 image assets are organized into modular, categorized folders under [`docs/`](docs/) with full Git history preserved.

- **1,550+ Documentation Articles**: In-depth coverage across configuration, trading operations, order management, indicators, automated strategies, SharpDX Direct2D rendering, and AddOn UI development.
- **1,160+ Visual Assets**: Screenshots, UI guides, indicator configuration examples, and Direct2D coordinate diagrams in [`docs/images/`](docs/images/).
- **Working Reference Samples**: Reference NinjaScript C# source code projects in [`samples/`](samples/).

---

## 📑 Documentation Sections & Sub-Indices

Each section contains its own dedicated `README.md` index with complete topic listings:

| Category | Description | Articles | Dedicated Index | Key Hubs |
| :--- | :--- | :---: | :---: | :--- |
| **Getting Started** | Platform setup, installation, licensing, data connections, and workspaces | 39 | [📂 `docs/getting_started/`](docs/getting_started/README.md) | [Introduction](docs/getting_started/introduction.md) • [Installation](docs/getting_started/installation.md) • [Connecting](docs/getting_started/connecting.md) |
| **Operations** | Charting, SuperDOM, Market Analyzer, Alert Log, and ATI | 158 | [📂 `docs/operations/`](docs/operations/README.md) | [Operations Guide](docs/operations/operations.md) • [Charts](docs/operations/charts.md) • [SuperDOM](docs/strategies/superdom.md) |
| **NinjaScript Core** | Lifecycle, state management, event hooks, threading, and best practices | 84 | [📂 `docs/ninjascript/`](docs/ninjascript/README.md) | [Lifecycle](docs/ninjascript/understanding_the_lifecycle_of.md) • [Best Practices](docs/ninjascript/ninjascript_best_practices.md) |
| **Language Reference** | Complete C# NinjaScript API reference (classes, methods, properties, series) | 454 | [📂 `docs/language_reference/`](docs/language_reference/README.md) | [Language Reference](docs/language_reference/language_reference_wip.md) • [Alphabetical Reference](docs/language_reference/alphabetical_reference.md) |
| **Indicators** | Technical indicator calculations, plots, series, and indicator development | 197 | [📂 `docs/indicators/`](docs/indicators/README.md) | [Indicators Reference](docs/indicators/indicators.md) • [Developing Indicators](docs/indicators/developing_indicators.md) |
| **Strategies** | Automated trade execution, ATM templates, position tracking, and backtesting | 310 | [📂 `docs/strategies/`](docs/strategies/README.md) | [Strategy Guide](docs/strategies/strategy.md) • [Strategy Analyzer](docs/strategies/strategy_analyzer.md) |
| **Drawing & Graphics** | Interactive chart drawing tools, chart anchors, and SharpDX Direct2D | 169 | [📂 `docs/drawing_tools/`](docs/drawing_tools/README.md) | [Drawing Tools](docs/drawing_tools/drawing_tools.md) • [SharpDX SDK](docs/drawing_tools/sharpdx_sdk_reference.md) |
| **AddOns & UI** | Custom WPF windows (`NTWindow`), menus, tab controls, and XAML | 93 | [📂 `docs/addons/`](docs/addons/README.md) | [AddOn Overview](docs/ninjascript/addon_development_overview.md) • [NTWindow](docs/addons/ntwindow.md) |
| **Release Notes** | Version changelogs (8.0 to 8.1.3.1) and API migration guides | 50 | [📂 `docs/release_notes/`](docs/release_notes/README.md) | [Release Notes](docs/release_notes/release_notes.md) • [Code Breaking Changes](docs/ninjascript/code_breaking_changes.md) |

---

## 🗂 Repository Structure

```text
ninjatrader_docs/
├── README.md                            # Main repository documentation portal
├── CLAUDE.md                            # Repository & agent instructions
├── docs/                                # Full documentation tree
│   ├── README.md                        # Master table of contents & Wiki guide
│   ├── images/                          # Visual diagrams, screenshots, and icons (1,168 assets)
│   ├── getting_started/README.md        # Getting Started topic index (39 articles)
│   ├── operations/README.md             # Trading operations topic index (158 articles)
│   ├── ninjascript/README.md            # NinjaScript core topic index (84 articles)
│   ├── language_reference/README.md     # C# API language reference index (454 articles)
│   ├── indicators/README.md             # Technical indicators index (197 articles)
│   ├── strategies/README.md             # Automated strategies index (310 articles)
│   ├── drawing_tools/README.md          # Drawing tools & Direct2D index (169 articles)
│   ├── addons/README.md                 # AddOns & custom UI index (93 articles)
│   └── release_notes/README.md          # Release notes index (50 articles)
├── samples/                             # C# NinjaScript reference projects and bundles
├── content/                             # Distribution packages and installer tools
├── tools/                               # Migration, restructuring, and verification scripts
│   ├── deploy_wiki.py                   # GitHub Wiki staging and deployment engine
│   ├── generate_readme.py               # Master README and index generator
│   └── verify_docs.py                   # Integrity check for links, images, and formatting
└── tests/                               # Automated test suite
    ├── test_repository_validation.py    # Link, image, and structure tests
    └── test_wiki_deployment.py          # Wiki staging and sidebar tests
```

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

## 🔗 Full Master Index

For the full flat alphabetical index linking every single individual documentation page in one place, see [`docs/README.md`](docs/README.md).
