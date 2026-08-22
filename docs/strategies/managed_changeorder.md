# ChangeOrder()

## Definition

Amends a specified [Order](order.md).

> **Note:** This method is only relevant for Managed orders with IsLiveUntilCancelled set to true and Unmanaged orders.

## Syntax

ChangeOrder(Order order, int quantity, double limitPrice, double stopPrice)

 

> **Warning:** If you have existing historical [order](order.md) references which have transitioned to real-time, you MUST update the order object reference to the newly submitted real-time order; otherwise errors may occur as you attempt to change the order.  You may use the [GetRealtimeOrder()](getrealtimeorder.md) helper method to assist in this transition.

 

## Parameters

| Name / Option | Description |
| --- | --- |
| order | [Order object](order.md) of the order you wish to amend |
| quantity | Order quantity |
| limitPrice | Order limit price. Use "0" should this parameter be irrelevant for the OrderType being submitted. |
| stopPrice | Order stop price. Use "0" should this parameter be irrelevant for the OrderType being submitted. |

## Examples

![Ns](../images/ns.png)

```csharp
private Order stopOrder = null;
protected override void OnBarUpdate()
{
    // Raise stop loss to breakeven when you are at least 4 ticks in profit
    if (stopOrder != null && stopOrder.StopPrice < Position.AveragePrice && Close[0] >= Position.AveragePrice + 4 \* TickSize)
    ChangeOrder(stopOrder, stopOrder.Quantity, 0, Position.AveragePrice);
}
```