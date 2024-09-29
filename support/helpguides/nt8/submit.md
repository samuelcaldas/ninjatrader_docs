


NinjaScript \> Language Reference \> Add On \> Account \> Submit()






















Submit()







| \<\< [Click to Display Table of Contents](submit.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Add On](add_on.md) \> [Account](account_class.md) \> Submit() | [Previous page](strategies_account.md) [Return to chapter overview](account_class.md) [Next page](barsrequest.md) |
| --- | --- |











## Definition


Submits specified [Order](order.md) object(s).


 


## Syntax


Submit(IEnumerable\<Order\> orders)


 


## Parameters




| orders | Order(s) to submit |
| --- | --- |



 


 


## 


## Examples




| ns |
| --- |
| Order stopOrder \= null; stopOrder \= myAccount.CreateOrder(myInstrument, OrderAction.Sell, OrderType.StopMarket, TimeInForce.Day, 1, 0, 1400, "myOCO", "stopOrder", null);   myAccount.Submit(new\[] { stopOrder }); |









