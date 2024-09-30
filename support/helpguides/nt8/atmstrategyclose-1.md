
NinjaScript > Language Reference > Strategy > ATM Strategy Methods > AtmStrategyClose()
AtmStrategyClose()
| << [Click to Display Table of Contents](atmstrategyclose.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Strategy](strategy-1.md) > [ATM Strategy Methods](atm_strategy_methods-1.md) > AtmStrategyClose() | [Previous page](atmstrategychangestoptarget-1.md) [Return to chapter overview](atm_strategy_methods-1.md) [Next page](atmstrategycreate-1.md) |
| --- | --- |
## Definition
Cancels any working orders and closes any open position of a strategy using the default [ATM strategy close behavior](closing_a_position_or_atm_stra-1.md).
 
## Method Return Value
Returns true if the specified ATM strategy was found; otherwise false. 
 
| Note:  A method return value of true in NO WAY indicates that the strategy in fact is closed. It indicates that the the specified ATM strategy was found and the internal close routine was triggered. |
| --- |

## Syntax
AtmStrategyClose(string atmStrategyId)
## 
## Parameters
| atmStrategyId | The unique identifier for the ATM strategy |
| --- | --- |
## 
## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Check for valid condition and create an ATM Strategy      if (GetAtmStrategyUnrealizedProfitLoss("idValue") > 500)          AtmStrategyClose("idValue"); } |

