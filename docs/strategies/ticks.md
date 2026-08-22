# Ticks

## Definition

Returns a [TradesPerformanceValues](tradesperformancevalues.md) object in ticks.

## Property Value

A TradesPerformanceValues object that is represented in ticks.

## Syntax

`<TradeCollection>.TradesPerformance.Ticks`

## Examples

```csharp
protected override void OnBarUpdate()
{
    // Print out the avg. profit of all trades in ticks
    Print("Average profit: " + SystemPerformance.AllTrades.TradesPerformance.Ticks.AverageProfit);
}
```