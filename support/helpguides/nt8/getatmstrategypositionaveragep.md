


NinjaScript \> Language Reference \> Strategy \> ATM Strategy Methods \> GetAtmStrategyPositionAveragePrice()






















GetAtmStrategyPositionAveragePrice()







| \<\< [Click to Display Table of Contents](getatmstrategypositionaveragep.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [ATM Strategy Methods](atm_strategy_methods.md) \> GetAtmStrategyPositionAveragePrice() | [Previous page](getatmstrategymarketposition.md) [Return to chapter overview](atm_strategy_methods.md) [Next page](getatmstrategypositionquantity.md) |
| --- | --- |











## Definition


Gets the current position's average price of the specified ATM Strategy.


 




| Note:  Changes to positions will not be reflected till at least the next [OnBarUpdate()](onbarupdate.md) event after an order fill. |
| --- |



 


## Method Return Value


A double value representing the average price.


## 


## Syntax


GetAtmStrategyPositionAveragePrice(string atmStrategyId)


 


## 


## Parameters




| atmStrategyId | The unique identifier for the ATM strategy |
| --- | --- |



## 


## 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {      // Check if flat      if (GetAtmStrategyMarketPosition("id") !\= MarketPosition.Flat)           Print("Average price is " \+ GetAtmStrategyPositionAveragePrice("id").ToString());  } |









