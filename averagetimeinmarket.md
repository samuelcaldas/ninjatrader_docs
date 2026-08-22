# AverageTimeInMarket

## Definition

Returns the average duration of a trade weighted by quantity.

## Property Value

A TimeSpan value that represents the quantity-weighted average duration of a trade.

## Syntax

`<TradeCollection>.TradesPerformance.AverageTimeInMarket`

## Examples

```csharp
protected override void OnBarUpdate()
{
    // Print out the quantity-weighted average duration of all trades
    Print("Average time in market: " + SystemPerformance.AllTrades.TradesPerformance.AverageTimeInMarket);
}
```
