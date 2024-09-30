
NinjaScript \> Language Reference \> Add On \> Account \> Submit()
Submit()
| \<\< [Click to Display Table of Contents](submit.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Add On](add_on-1.md) \> [Account](account_class-1.md) \> Submit() | [Previous page](strategies_account-1.md) [Return to chapter overview](account_class-1.md) [Next page](barsrequest-1.md) |
| --- | --- |
## Definition
Submits specified [Order](order-1.md) object(s).
 
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
