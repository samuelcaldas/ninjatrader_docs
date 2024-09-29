


NinjaScript \> Language Reference \> Optimizer \> OptimizationParameters






















OptimizationParameters







| \<\< [Click to Display Table of Contents](optimizationparameters.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Optimizer](optimizer.md) \> OptimizationParameters | [Previous page](onoptimize.md) [Return to chapter overview](optimizer.md) [Next page](runiteration.md) |
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









