# Submit()

## Definition

Submits specified [Order](../strategies/order.md) object(s).

## Syntax

Submit(IEnumerable<Order> orders)

 

## Parameters

|  |  |
| --- | --- |
| orders | Order(s) to submit |

## Examples

```csharp
Order stopOrder = null;
stopOrder = myAccount.CreateOrder(myInstrument, OrderAction.Sell, OrderType.StopMarket, TimeInForce.Day, 1, 0, 1400, "myOCO", "stopOrder", null);
myAccount.Submit(new[] { stopOrder });
```
