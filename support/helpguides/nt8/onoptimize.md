



OnOptimize()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](onoptimize.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Optimizer](optimizer.htm) >  OnOptimize() | [Previous page](numberofiterations.htm) [Return to chapter overview](optimizer.htm) [Next page](optimizationparameters.htm) |

Definition
----------

This method must be overridden in order to optimize a strategy. This method is called once per optimization run (not once per iteration).

Method Return Value
-------------------

This method does not return a value.

Syntax 
You must override the method in your Optimizer with the following syntax.
---------------------------------------------------------------------------------

protected override void OnOptimize()   
{

}

Examples
--------

| ns |
| --- |
| protected override void OnOptimize()  {      // If there is no optimization objective, return      if (Strategies[0].OptimizationParameters.Count == 0)          return;         // Optimizer logic  } |