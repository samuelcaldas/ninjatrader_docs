
NinjaScript > Language Reference > Strategy > BarsSinceExitExecution()
BarsSinceExitExecution()
| << [Click to Display Table of Contents](barssinceexitexecution.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > BarsSinceExitExecution() | [Previous page](barssinceentryexecution.md) [Return to chapter overview](strategy.md) [Next page](chartindicators.md) |
| --- | --- |
## Definition
Returns the number of bars that have elapsed since the last exit. When a signal name is provided, the number of bars that have elapsed since that last specific exit will be returned.
## 
## Method Return Value
An int value that represents a number of bars. A value of -1 will be returned if a previous exit does not exist.
 
## Syntax
BarsSinceExitExecution()
BarsSinceExitExecution(string signalName)
 
The following method signature should be used when working with [multi-time frame and instrument strategies](multi-time_frame__instruments.md):
   

BarsSinceExitExecution(int barsInProgressIndex, string signalName, int exitExecutionsAgo)  

 
| Note: When working with a multi-series strategy the BarsSinceExitExecution() will return you the elapsed bars as determined by the first Bars object for the instrument specified in the barsInProgressIndex. |
| --- |

## Parameters
| signalName | The signal name of an exit order specified in an order exit method. |
| --- | --- |
| barsInProgressIndex | The index of the Bars object the entry order was submitted against.    Note:  See the [BarsInProgress](barsinprogress.md) property. |
| exitExecutionsAgo | Number of exit executions ago. Pass in 0 for the number of bars since the last exit execution. |

| Tip:  Please see [SetStopLoss()](setstoploss.md), [SetProfitTarget()](setprofittarget.md) or [SetTrailStop()](settrailstop.md) for their corresponding signal name |
| --- |

## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {     if (CurrentBar < BarsRequiredToTrade)         return;       // Only enter if at least 10 bars has passed since our last exit or if we have never traded yet    if ((BarsSinceExitExecution() > 10 || BarsSinceExitExecution() == -1) && CrossAbove(SMA(10), SMA(20), 1))        EnterLong(); } |

