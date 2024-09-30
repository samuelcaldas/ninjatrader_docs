
NinjaScript \> Language Reference \> Strategy \> ATM Strategy Methods \> AtmStrategyClose()
AtmStrategyClose()
| \<\< [Click to Display Table of Contents](atmstrategyclose.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [ATM Strategy Methods](atm_strategy_methods.md) \> AtmStrategyClose() | [Previous page](atmstrategychangestoptarget.md) [Return to chapter overview](atm_strategy_methods.md) [Next page](atmstrategycreate.md) |
| --- | --- |
## Definition
Cancels any working orders and closes any open position of a strategy using the default [ATM strategy close behavior](closing_a_position_or_atm_stra.md).
 
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
| protected override void OnBarUpdate() {      // Check for valid condition and create an ATM Strategy      if (GetAtmStrategyUnrealizedProfitLoss("idValue") \> 500)          AtmStrategyClose("idValue"); } |

