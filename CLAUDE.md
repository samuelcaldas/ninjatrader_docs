# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Repository Overview

This repository contains the complete documentation and reference materials for **NinjaTrader 8 (NT8)** and **NinjaScript**, structured in Markdown format alongside reference C# sample projects and images.

- `README.md`: Master table of contents and index linking to all documentation sections.
- Root Markdown files (`*.md`): Topic-by-topic documentation pages covering NinjaTrader configuration, operations, UI windows, NinjaScript language reference, SharpDX Direct2D rendering, and release notes.
- Root Image assets (`*.png`, `*.jpg`): Visual diagrams and UI screenshots referenced directly in documentation files.
- `samples/`: Official NinjaTrader 8 NinjaScript reference implementations (Indicators, Strategies, AddOns in C# and WPF XAML) with corresponding `.zip` distribution bundles.
- `content/`: Binary installers and supporting tool packages.

## Structure & Architecture

- **Documentation Organization**:
  - `welcome.md`, `introduction.md`, `configuration.md`, `operations.md`: Platform setup, configuration, and UI trading features.
  - `ninjascript.md`, `language_reference_wip.md`, `common.md`: NinjaScript core concepts, lifecycle (`OnStateChange`, `OnBarUpdate`), event handlers, and indicator/strategy base classes.
  - `sharpdx_sdk_reference.md`, `rendering.md`: SharpDX Direct2D/DirectWrite rendering subsystem for custom chart graphics.
  - `addon_development_overview.md`, `developing_indicators.md`, `developing_strategies.md`: Developer guides and tutorials.
- **NinjaScript Samples (`samples/`)**:
  - Follows standard NinjaScript directory layout: `Indicators/`, `Strategies/`, and `AddOns/`.
  - Built against the NinjaTrader 8 API using .NET / C# and WPF.

## Common Operations & Commands

- **Search Documentation**:
  ```bash
  # Search for a specific API method, class, or error code
  grep -rn "OnBarUpdate" *.md
  grep -rn "CS0246" *.md
```

- **Verify Documentation Links & Assets**:
  ```bash
  # Find broken local markdown links or missing images
  python3 -c "import os, re; [print(f'{f}: missing {m}') for f in os.listdir('.') if f.endswith('.md') for m in re.findall(r'\]\(([^)#]+)', open(f, errors='ignore').read()) if not os.path.exists(m) and not m.startswith('http')]"
```

- **Inspect / Work with NinjaScript Samples**:
  - Sample C# sources are located in `samples/<SampleProjectName>/{Indicators,Strategies,AddOns}/`.
  - Reference indicator patterns: `samples/Sample*`
  - Reference AddOn UI windows: `samples/NinjaTraderAddOnProject/` and `samples/Addon_Framework_NinjaScript_Basic/`
