
NinjaScript \> Language Reference \> Optimizer \> SupportsMultiObjectiveOptimization
SupportsMultiObjectiveOptimization
| \<\< [Click to Display Table of Contents](supportsmultiobjectiveoptimiza.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Optimizer](optimizer-1.md) \> SupportsMultiObjectiveOptimization | [Previous page](runiteration-1.md) [Return to chapter overview](optimizer-1.md) [Next page](performance_metrics-1.md) |
| --- | --- |
## Definition
Informs the Strategy Analyzer if this Optimizer can do multi\-objective optimizations.
 
## Property Value
A bool value.
 
## Syntax
SupportsMultiObjectiveOptimization

## Examples
| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {           Name \= "MyOptimizer";           SupportsMultiObjectiveOptimization \= true;      } } |
