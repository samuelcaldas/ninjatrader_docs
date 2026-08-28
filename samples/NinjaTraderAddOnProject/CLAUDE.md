# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Repository Overview

`NinjaTraderAddOnProject` is a reference C# WPF implementation and Visual Studio solution demonstrating full-featured custom AddOn development for **NinjaTrader 8 (NT8)**. It showcases window hosting (`NTWindow`), tab lifecycle (`NTTabPage`, `INTTabFactory`), Control Center menu integration, market data/depth subscriptions, order execution (market & framework-managed brackets), account events, and workspace persistence (`IWorkspacePersistence`).

## Build & Project Configuration

- **Target Framework**: .NET Framework 4.8 (`v4.8`) / Visual Studio 2015+ format (`.csproj`, `.sln`)
- **Dependencies**: `NinjaTrader.Core.dll` and `NinjaTrader.Gui.dll` (located under `NinjaTrader 8\bin` or bundled in `bin/Debug` / `bin/Release`)
- **Output Type**: Class Library (`NinjaTraderAddOnProject.dll`)
- **Post-Build Action**: Copies compiled assembly and PDB to `%USERPROFILE%\Documents\NinjaTrader 8\bin\Custom`

### Common Build Commands

```powershell
# Build solution via MSBuild
msbuild NinjaTraderAddOnProject.sln /p:Configuration=Debug /p:Platform="Any CPU"
msbuild NinjaTraderAddOnProject.sln /p:Configuration=Release /p:Platform="Any CPU"

# Build project directly via dotnet (requires .NET Framework targeting pack)
dotnet build NinjaTraderAddOnProject\NinjaTraderAddOnProject.csproj -c Debug
```

## Architecture & Key Components

1. **AddOn Entry & Window Lifecycle (`AddOnFramework.cs`)**:
   - `AddOnFramework` (`NinjaTrader.NinjaScript.AddOnBase`): Injects custom menu items into the NT8 Control Center "New" menu (`ControlCenterMenuItemNew`) on `OnWindowCreated` and cleans up on `OnWindowDestroyed`.
   - `AddOnFrameworkWindow` (`NinjaTrader.Gui.Tools.NTWindow`, `IWorkspacePersistence`): Custom top-level NT8 window managing movable and serializable tab pages via `TabControlManager`.
   - `AddOnFrameworkWindowFactory` (`INTTabFactory`): Instantiates new `AddOnFrameworkWindow` parent windows and `AddOnPage` tab pages.

2. **AddOn UI & Functional Engine (`AddOnPage.xaml` & `AddOnPage.xaml.cs`)**:
   - `AddOnPage` (`NinjaTrader.Gui.Tools.NTTabPage`, `IInstrumentProvider`, `IIntervalProvider`): WPF TabPage hosting interactive UI controls and event handlers.
   - **Account Management**: Queries account values, positions, executions, strategies, and listens to `Account.AccountStatusUpdate` / `Account.SimulationAccountReset`.
   - **Market & Depth Data**: Historical `BarsRequest`, real-time `MarketData`, Level 2 `MarketDepth<MarketDepthRow>`, and fundamental data queries.
   - **Order Execution & Management**: Submits market orders, manages entry/stop-loss/profit-target bracket lifecycles, and listens to `Account.OrderUpdate`, `Account.ExecutionUpdate`, and `Account.PositionUpdate`.
   - **Connectivity & News**: Connection status monitoring (`Connection.ConnectionStatusUpdate`) and `NewsSubscription` stream handling.
