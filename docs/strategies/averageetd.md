# AverageEtd

## Definition

Returns the average ETD (end trade draw down) of the collection.

## Property Value

A double value that represents the average ETD of the collection.

## Syntax

`<TradeCollection>.TradesPerformance.<TradesPerformanceValues>.AverageEtd`

## Examples

```csharp
protected override void OnBarUpdate()
{
    // Print out the average ETD of all trades in currency
    Print("Average ETD of all trades is: " + SystemPerformance.AllTrades.TradesPerformance.Currency.AverageEtd);
}
```