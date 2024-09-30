
NinjaScript > Language Reference > Optimizer > SupportsMultiObjectiveOptimization
SupportsMultiObjectiveOptimization
| << [Click to Display Table of Contents](supportsmultiobjectiveoptimiza.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Optimizer](optimizer.md) > SupportsMultiObjectiveOptimization | [Previous page](runiteration.md) [Return to chapter overview](optimizer.md) [Next page](performance_metrics.md) |
| --- | --- |
## Definition
Informs the Strategy Analyzer if this Optimizer can do multi-objective optimizations.
 
## Property Value
A bool value.
 
## Syntax
SupportsMultiObjectiveOptimization

## Examples
| ns |
| --- |
| protected override void OnStateChange() {      if (State == State.SetDefaults)      {           Name = "MyOptimizer";           SupportsMultiObjectiveOptimization = true;      } } |
