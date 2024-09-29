


NinjaScript \> Language Reference \> Strategy \> ATM Strategy Methods \> GetAtmStrategyUniqueId()






















GetAtmStrategyUniqueId()







| \<\< [Click to Display Table of Contents](getatmstrategyuniqueid.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [ATM Strategy Methods](atm_strategy_methods-1.md) \> GetAtmStrategyUniqueId() | [Previous page](getatmstrategyunrealizedprofit-1.md) [Return to chapter overview](atm_strategy_methods-1.md) [Next page](barsrequiredtotrade-1.md) |
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









