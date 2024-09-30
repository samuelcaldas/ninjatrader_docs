
NinjaScript \> Language Reference \> Strategy \> ATM Strategy Methods \> GetAtmStrategyPositionQuantity()

GetAtmStrategyPositionQuantity()
| \<\< [Click to Display Table of Contents](getatmstrategypositionquantity.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [ATM Strategy Methods](atm_strategy_methods.md) \> GetAtmStrategyPositionQuantity() | [Previous page](getatmstrategypositionaveragep.md) [Return to chapter overview](atm_strategy_methods.md) [Next page](getatmstrategyrealizedprofitlo.md) |
| --- | --- |
## Definition
Gets the current position quantity of the specified ATM Strategy.
 
| Note:  Changes to positions will not be reflected till at least the next [OnBarUpdate()](onbarupdate.md) event after an order fill. |
| --- |

 
## Method Return Value
An int value representing the quantity.
 
## Syntax
GetAtmStrategyPositionQuantity(string atmStrategyId)
 
## 
## Parameters
| atmStrategyId | The unique identifier for the ATM strategy |
| --- | --- |

## 
## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      // Check if flat      if (GetAtmStrategyMarketPosition("idValue") !\= MarketPosition.Flat)          Print("Position size is " \+ GetAtmStrategyPositionQuantity("id").ToString()); } |
