# AtmStrategyChangeEntryOrder()

## Definition

Changes the price of the specified entry order.

## Method Return Value

Returns true if the specified order was found; otherwise false.

## Syntax

AtmStrategyChangeEntryOrder(double limitPrice, double stopPrice, string orderId)

 

## Parameters

|  |  |
| --- | --- |
| limitPrice | Order limit price |
| stopPrice | Order stop price |
| orderId | The unique identifier for the entry order |

## Examples

```csharp
protected override void OnBarUpdate()
{
    AtmStrategyChangeEntryOrder(GetCurrentBid(), 0, "orderIdValue");
}
```
