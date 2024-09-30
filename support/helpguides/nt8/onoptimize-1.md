
NinjaScript \> Language Reference \> Optimizer \> OnOptimize()

OnOptimize()

| \<\< [Click to Display Table of Contents](onoptimize.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Optimizer](optimizer-1.md) \> OnOptimize() | [Previous page](numberofiterations-1.md) [Return to chapter overview](optimizer-1.md) [Next page](optimizationparameters-1.md) |
| --- | --- |
## Definition
This method must be overridden in order to optimize a strategy. This method is called once per optimization run (not once per iteration).
 
## Method Return Value
This method does not return a value.
## 
## Syntax
You must override the method in your Optimizer with the following syntax.
 
protected override void OnOptimize()   

{
   

}

## 
## Examples

| ns |
| --- |
| protected override void OnOptimize() {      // If there is no optimization objective, return      if (Strategies\[0].OptimizationParameters.Count \=\= 0\)          return;        // Optimizer logic } |
