


NinjaScript \> Language Reference \> Strategy \> ATM Strategy Methods \> AtmStrategyChangeEntryOrder()






















AtmStrategyChangeEntryOrder()







| \<\< [Click to Display Table of Contents](atmstrategychangeentryorder.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [ATM Strategy Methods](atm_strategy_methods.md) \> AtmStrategyChangeEntryOrder() | [Previous page](atmstrategycancelentryorder.md) [Return to chapter overview](atm_strategy_methods.md) [Next page](atmstrategychangestoptarget.md) |
| --- | --- |











## Definition


Changes the price of the specified entry order.


 


## Method Return Value


Returns true if the specified order was found; otherwise false.


 


## Syntax


AtmStrategyChangeEntryOrder(double limitPrice, double stopPrice, string orderId)


 


## 


## Parameters




| limitPrice | Order limit price |
| --- | --- |
| stopPrice | Order stop price |
| orderId | The unique identifier for the entry order |



## 


## 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {      AtmStrategyChangeEntryOrder(GetCurrentBid(), 0, "orderIdValue"); } |









