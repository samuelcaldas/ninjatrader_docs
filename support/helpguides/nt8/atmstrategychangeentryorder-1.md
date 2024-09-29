


NinjaScript \> Language Reference \> Strategy \> ATM Strategy Methods \> AtmStrategyChangeEntryOrder()






















AtmStrategyChangeEntryOrder()







| \<\< [Click to Display Table of Contents](atmstrategychangeentryorder.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [ATM Strategy Methods](atm_strategy_methods-1.md) \> AtmStrategyChangeEntryOrder() | [Previous page](atmstrategycancelentryorder-1.md) [Return to chapter overview](atm_strategy_methods-1.md) [Next page](atmstrategychangestoptarget-1.md) |
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









