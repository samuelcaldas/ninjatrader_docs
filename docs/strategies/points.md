# Points

## Definition

Returns a [TradesPerformanceValues](tradesperformancevalues.md) object in points.

## Property Value

A TradesPerformanceValues object that is represented in points.

## Syntax

`<TradeCollection>.TradesPerformance.Points`

## Examples

![Ns](../images/ns.png)

```csharp
protected override void OnBarUpdate()
{
    // Print out the avg. profit of all trades in points
    Print("Average profit: " + SystemPerformance.AllTrades.TradesPerformance.Points.AverageProfit);
}
```