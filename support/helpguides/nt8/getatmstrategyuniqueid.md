


NinjaScript \> Language Reference \> Strategy \> ATM Strategy Methods \> GetAtmStrategyUniqueId()






















GetAtmStrategyUniqueId()







| \<\< [Click to Display Table of Contents](getatmstrategyuniqueid.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [ATM Strategy Methods](atm_strategy_methods.md) \> GetAtmStrategyUniqueId() | [Previous page](getatmstrategyunrealizedprofit.md) [Return to chapter overview](atm_strategy_methods.md) [Next page](barsrequiredtotrade.md) |
| --- | --- |











## Definition


Generates a unique ATM Strategy ID value. 


 


## Method Return Value


A string value representing a unique id value.


## 


## Syntax


GetAtmStrategyUniqueId()


 


## Parameters


This method does use take any parameters.


 


## 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {      string orderId \= GetAtmStrategyUniqueId(); } |









