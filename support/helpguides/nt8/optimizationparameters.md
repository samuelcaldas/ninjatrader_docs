



OptimizationParameters

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](optimizationparameters.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Optimizer](optimizer.htm) >  OptimizationParameters | [Previous page](onoptimize.htm) [Return to chapter overview](optimizer.htm) [Next page](runiteration.htm) |

Definition
----------

The optimization parameters selected for the optimization run. (e.g. user parameters or Data Series)

Property Value
--------------

A bool value.

Syntax
------

Strategies[0].OptimizationParameters

Examples
--------

| ns |
| --- |
| protected override void OnOptimize()  {      // If there are no optimization parameters to optimize, return      if (Strategies[0].OptimizationParameters.Count == 0)          return;         // Do something with the optimization parameter      Parameter parameter = Strategies[0].OptimizationParameters[0];  } |