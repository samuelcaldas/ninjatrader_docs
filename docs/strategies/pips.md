# Pips

## Definition

Returns a [[[TradesPerformanceValues](tradesperformancevalues.md) object in pips.

## Property Value

A TradesPerformanceValues object that is represented in pips.

## Syntax

`<TradeCollection>.TradesPerformance.Pips`

## Examples

```csharp
protected override void OnBarUpdate()
{
    // Print out the avg. profit of all trades in pips
    Print("Average profit: " + SystemPerformance.AllTrades.TradesPerformance.Pips.AverageProfit);
}
```
