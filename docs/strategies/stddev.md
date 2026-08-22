# StdDev

## Definition

Returns the standard deviation of the collection on a per unit basis.

## Property Value

A double value that represents the standard deviation of the collection on a per unit basis.

## Syntax

`<TradeCollection>.TradesPerformance.<TradesPerformanceValues>.StdDev`

## Examples

```csharp
protected override void OnBarUpdate()
{
    // Print out the standard deviation of all trades
    Print("Standard deviation of all trades is: " + SystemPerformance.AllTrades.TradesPerformance.Currency.StdDev);
}
```
