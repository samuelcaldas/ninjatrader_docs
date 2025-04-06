



Optimizer

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](optimizer.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) >  Optimizer | [Previous page](optimization_fitness_value.htm) [Return to chapter overview](language_reference_wip.htm) [Next page](numberofiterations.htm) |

Custom Optimizers can be used to optimize your Strategy through different algorithms. These may allow you to make trade offs like being able to find adequate results quickly as opposed to trying to find the absolute best result but through a time consuming process. The methods and properties covered in this section are unique to custom Optimizer development.

In this section
---------------

|  |  |
| --- | --- |
| [NumberOfIterations](numberofiterations.htm) | Informs the Strategy Analyzer how many iterations of optimizing it needs to do. |
| [OnOptimize()](onoptimize.htm) | This method must be overridden in order to optimize a strategy. |
| [OptimizationParameters](optimizationparameters.htm) | The optimization parameters selected for the optimization run. |
| [RunIteration()](runiteration.htm) | Runs an iteration of backtesting for the optimizer. |
| [SupportsMultiObjectiveOptimization](supportsmultiobjectiveoptimiza.htm) | Informs the Strategy Analyzer if this Optimizer can do multi-objective optimizations. |