



SupportsMultiObjectiveOptimization

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](supportsmultiobjectiveoptimiza.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Optimizer](optimizer.htm) >  SupportsMultiObjectiveOptimization | [Previous page](runiteration.htm) [Return to chapter overview](optimizer.htm) [Next page](performance_metrics.htm) |

Definition
----------

Informs the Strategy Analyzer if this Optimizer can do multi-objective optimizations.

Property Value
--------------

A bool value.

Syntax
------

SupportsMultiObjectiveOptimization

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()  {      if (State == State.SetDefaults)      {           Name = "MyOptimizer";           SupportsMultiObjectiveOptimization = true;      }  } |