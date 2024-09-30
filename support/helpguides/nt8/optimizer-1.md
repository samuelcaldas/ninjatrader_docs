
NinjaScript > Language Reference > Optimizer

Optimizer

| << [Click to Display Table of Contents](optimizer.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > Optimizer | [Previous page](optimization_fitness_value-1.md) [Return to chapter overview](language_reference_wip-1.md) [Next page](numberofiterations-1.md) |
| --- | --- |
Custom Optimizers can be used to optimize your Strategy through different algorithms. These may allow you to make trade offs like being able to find adequate results quickly as opposed to trying to find the absolute best result but through a time consuming process. The methods and properties covered in this section are unique to custom Optimizer development.
 
## In this section

| [NumberOfIterations](numberofiterations-1.md) | Informs the Strategy Analyzer how many iterations of optimizing it needs to do. |
| --- | --- |
| [OnOptimize()](onoptimize-1.md) | This method must be overridden in order to optimize a strategy. |
| [OptimizationParameters](optimizationparameters-1.md) | The optimization parameters selected for the optimization run. |
| [RunIteration()](runiteration-1.md) | Runs an iteration of backtesting for the optimizer. |
| [SupportsMultiObjectiveOptimization](supportsmultiobjectiveoptimiza-1.md) | Informs the Strategy Analyzer if this Optimizer can do multi-objective optimizations. |
