
NinjaScript > Language Reference > Strategy > StopTargetHandling
StopTargetHandling
| << [Click to Display Table of Contents](stoptargethandling.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Strategy](strategy-1.md) > StopTargetHandling | [Previous page](startbehavior-1.md) [Return to chapter overview](strategy-1.md) [Next page](strategybaseconverter-1.md) |
| --- | --- |
## Definition
Determines how stop and target orders are submitted during an entry order execution.  
 
## Property Value
An enum value that determines how the strategy behaves.  Default value is set to StopTargetHandling.PerEntryExecution.  Possible values are:
## 
| StopTargetHandling.ByStrategyPosition | Stop and Target order quantities will match the current strategy position.  (Stops and targets may result in "stacked" orders on partial fills) |
| --- | --- |
| StopTargetHandling.PerEntryExecution | Stop and Target orders will match the total entry execution. (Stops and targets order quantities may not match strategy position under a partial fill scenario) |

 
| Warning:  If your strategy executes to an Interactive Brokers or TD Ameritrade account, the StopTargetHandling will always be forced to .ByStrategyPosition |
| --- |

## Syntax
StopTargetHandling
 
| Tip:  The default strategy behavior is to match the order quantity used for the stops and targets to the total entry execution. However in cases where the strategy's entry order is partially filled, StopTargetHandling.PerEntryExecution will result in a new set of stop loss and profit target orders for each entry execution.  If you would prefer all of your stops and targets to be placed at the same time within the same order, it is suggested to use StopTargetHandling.ByStrategyPosition. However this may result in more stop and target orders being submitted than the overall strategy position in a scenario in which the strategy's entire entry orders are not filled in one fill. |
| --- |

## 
## Example
| ns |
| --- |
| protected override void OnStateChange() {      if (State == State.SetDefaults)      {          StopTargetHandling = StopTargetHandling.PerEntryExecution;      } } |

 
