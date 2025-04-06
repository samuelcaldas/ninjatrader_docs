



SupportsMultiObjectiveOptimization

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\supportsmultiobjectiveoptimiza.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Optimizer](optimizer-1.htm) >  SupportsMultiObjectiveOptimization | [Previous page](runiteration-1.htm) [Return to chapter overview](optimizer-1.htm) [Next page](performance_metrics-1.htm) |

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