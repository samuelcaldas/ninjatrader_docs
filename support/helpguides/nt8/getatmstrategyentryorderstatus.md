


NinjaScript \> Language Reference \> Strategy \> ATM Strategy Methods \> GetAtmStrategyEntryOrderStatus()






















GetAtmStrategyEntryOrderStatus()







| \<\< [Click to Display Table of Contents](getatmstrategyentryorderstatus.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [ATM Strategy Methods](atm_strategy_methods.md) \> GetAtmStrategyEntryOrderStatus() | [Previous page](atmstrategycreate.md) [Return to chapter overview](atm_strategy_methods.md) [Next page](getatmstrategymarketposition.md) |
| --- | --- |











## Definition


Gets the current state of the specified entry order. 


 




| Note:  If the method can't find the specified order, an empty array is returned. |
| --- |



 


 


## Method Return Value


A string\[] array holding three elements that represent average fill price, filled amount and order state.


## 


## Syntax


GetAtmStrategyEntryOrderStatus(string orderId)


## 


## Parameters




| orderId | The unique identifier for the entry order |
| --- | --- |



 


## 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {      string\[] entryOrder \= GetAtmStrategyEntryOrderStatus("orderId");        // Check length to ensure that returned array holds order information      if (entryOrder.Length \> 0)      {          Print("Average fill price is " \+ entryOrder\[0].ToString());          Print("Filled amount is " \+ entryOrder\[1].ToString());          Print("Current state is " \+ entryOrder\[2].ToString());      } } |









