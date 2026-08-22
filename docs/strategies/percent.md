# Percent

## Definition

Returns a [TradesPerformanceValues](tradesperformancevalues.md) object in percent.

## Property Value

A TradesPerformanceValues object that is represented in percent.

## Syntax

`<TradeCollection>.TradesPerformance.Percent`

## Examples

```csharp
protected override void OnBarUpdate()
{
    // Print out the avg. profit of all trades in percent
    Print("Average profit: " + SystemPerformance.AllTrades.TradesPerformance.Percent.AverageProfit);
}
```
