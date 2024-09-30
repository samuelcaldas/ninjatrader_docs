
NinjaScript > Language Reference > Optimizer > OnOptimize()

OnOptimize()

| << [Click to Display Table of Contents](onoptimize.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Optimizer](optimizer.md) > OnOptimize() | [Previous page](numberofiterations.md) [Return to chapter overview](optimizer.md) [Next page](optimizationparameters.md) |
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
| protected override void OnOptimize() {      // If there is no optimization objective, return      if (Strategies[0].OptimizationParameters.Count == 0)          return;        // Optimizer logic } |
