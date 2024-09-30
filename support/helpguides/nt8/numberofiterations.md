
NinjaScript > Language Reference > Optimizer > NumberOfIterations
NumberOfIterations
| << [Click to Display Table of Contents](numberofiterations.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Optimizer](optimizer.md) > NumberOfIterations | [Previous page](optimizer.md) [Return to chapter overview](optimizer.md) [Next page](onoptimize.md) |
| --- | --- |
## Definition
Informs the Strategy Analyzer how many iterations of optimizing it needs to do.
 
## Property Value
An int value.
 
## Syntax
NumberOfIterations

## Examples
| ns |
| --- |
| protected override void OnStateChange() {      if (State == State.SetDefaults)          Name = "MyOptimizer";      else if (State == State.Configure && Strategies.Count > 0)          NumberOfIterations = 1; } |
