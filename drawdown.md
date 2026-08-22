# Drawdown

## Definition

Returns the draw down of the trade collection.

## Property Value

A double value that represents the average ETD of the collection.

## Syntax

`<TradeCollection>.TradesPerformance.<TradesPerformanceValues>.Drawdown`

## Examples

```csharp
protected override void OnBarUpdate()
{
    // Print out the draw down of all trades in currency
    Print("Draw down of all trades is: " + SystemPerformance.AllTrades.TradesPerformance.Currency.Drawdown);
}
```
