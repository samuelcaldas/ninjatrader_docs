



NumberOfIterations

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\numberofiterations.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Optimizer](optimizer-1.htm) >  NumberOfIterations | [Previous page](optimizer-1.htm) [Return to chapter overview](optimizer-1.htm) [Next page](onoptimize-1.htm) |

Definition
----------

Informs the Strategy Analyzer how many iterations of optimizing it needs to do.

Property Value
--------------

An int value.

Syntax
------

NumberOfIterations

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()  {       if (State == State.SetDefaults)           Name = "MyOptimizer";       else if (State == State.Configure && Strategies.Count > 0)           NumberOfIterations = 1;  } |