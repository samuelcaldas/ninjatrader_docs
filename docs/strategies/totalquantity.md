# TotalQuantity

## Definition

Returns the total quantity.

## Property Value

A double value that represents the total quantity.

## Syntax

`<TradeCollection>.TradesPerformance.TotalQuantity`

## Examples

![Ns](../images/ns.png)

```csharp
protected override void OnBarUpdate()
{
    // Print out the total quantity of all trades
    Print("Total quantity is: " + SystemPerformance.AllTrades.TradesPerformance.TotalQuantity);
}
```