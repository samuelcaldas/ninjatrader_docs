
NinjaScript \> Language Reference \> Optimizer \> OptimizationParameters
OptimizationParameters
| \<\< [Click to Display Table of Contents](optimizationparameters.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Optimizer](optimizer-1.md) \> OptimizationParameters | [Previous page](onoptimize-1.md) [Return to chapter overview](optimizer-1.md) [Next page](runiteration-1.md) |
| --- | --- |
## Definition
The optimization parameters selected for the optimization run. (e.g. user parameters or Data Series)
 
## Property Value
A bool value.
 
## Syntax
Strategies\[0].OptimizationParameters

## Examples
| ns |
| --- |
| protected override void OnOptimize() {      // If there are no optimization parameters to optimize, return      if (Strategies\[0].OptimizationParameters.Count \=\= 0\)          return;        // Do something with the optimization parameter      Parameter parameter \= Strategies\[0].OptimizationParameters\[0]; } |
