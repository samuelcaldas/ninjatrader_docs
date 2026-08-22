# AverageProfit

## Definition

Returns the average profit of the collection.

## Property Value

A double value that represents the average profit of the collection.

## Syntax

`<TradeCollection>.TradesPerformance.<TradesPerformanceValues>.AverageProfit`

## Examples

```csharp
protected override void OnBarUpdate()
{
    // Print out the average profit of all trades in currency
    Print("Average profit of all trades is: " + SystemPerformance.AllTrades.TradesPerformance.Currency.AverageProfit);
}
```