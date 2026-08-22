# CumProfit

## Definition

Returns the cumulative profit of the collection.

## Property Value

A double value that represents the cumulative profit of the collection.

## Syntax

`<TradeCollection>.TradesPerformance.<TradesPerformanceValues>.CumProfit`

## Examples

![Ns](../images/ns.png)

```csharp
protected override void OnBarUpdate()
{
    // Print out the cumulative profit of all trades in currency
    Print("Average cumulative profit of all trades is: " + SystemPerformance.AllTrades.TradesPerformance.Currency.CumProfit);
}
```