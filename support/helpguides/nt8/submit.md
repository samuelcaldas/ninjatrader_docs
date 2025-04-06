



Submit()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](submit.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Add On](add_on.htm) > [Account](account_class.htm) >  Submit() | [Previous page](strategies_account.htm) [Return to chapter overview](account_class.htm) [Next page](barsrequest.htm) |

Definition
----------

Submits specified [Order](order.htm) object(s).

Syntax
------

Submit(IEnumerable<Order> orders)

 

Parameters
----------

|  |  |
| --- | --- |
| orders | Order(s) to submit |

Examples
--------

| ns |
| --- |
| Order stopOrder = null;  stopOrder = myAccount.CreateOrder(myInstrument, OrderAction.Sell, OrderType.StopMarket, TimeInForce.Day, 1, 0, 1400, "myOCO", "stopOrder", null);     myAccount.Submit(new[] { stopOrder }); |