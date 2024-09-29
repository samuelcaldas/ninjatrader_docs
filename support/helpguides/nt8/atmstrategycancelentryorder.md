


NinjaScript \> Language Reference \> Strategy \> ATM Strategy Methods \> AtmStrategyCancelEntryOrder()






















AtmStrategyCancelEntryOrder()







| \<\< [Click to Display Table of Contents](atmstrategycancelentryorder.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [ATM Strategy Methods](atm_strategy_methods.md) \> AtmStrategyCancelEntryOrder() | [Previous page](atm_strategy_methods.md) [Return to chapter overview](atm_strategy_methods.md) [Next page](atmstrategychangeentryorder.md) |
| --- | --- |











## Definition


Cancels the specified entry order determined by the string "orderId" parameter.  


 




| Notes:  1\.This method is intended ONLY for orders submitted as [Atm Entry Orders](atmstrategycreate.md) and assumes the [OrderState](getatmstrategyentryorderstatus.md) is NOT terminal (i.e., Cancelled, Filled, Rejected, Unknown).2\.If the specified order does not exist, the method returns false and an error is logged. |
| --- |



 


 


## Method Return Value


Returns true if the specified order was found; otherwise false.


## 


## Syntax


AtmStrategyCancelEntryOrder(string orderId)


 




| Warning:  This method should ONLY be called once the strategy [State](state.md) has reached State.Realtime |
| --- |



 


## 


## Parameters




| orderId | The unique identifier for the entry order |
| --- | --- |



## 


## 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {    // ATM strategy methods only work during real\-time    if (State !\= State.Realtime)      return;      string\[] entryOrder \= GetAtmStrategyEntryOrderStatus("orderId");      // checks if the entry order exists    // and the order state is not already cancelled/filled/rejected    if (entryOrder.Length \> 0 \&\& entryOrder\[2] \=\= "Working")    {      AtmStrategyCancelEntryOrder("orderId");    } } |









