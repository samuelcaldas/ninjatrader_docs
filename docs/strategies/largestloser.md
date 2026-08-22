# LargestLoser

## Definition

Returns the largest loss amount of the collection.

## Property Value

A double value that represents the largest loss amount of the collection.

## Syntax

`<TradeCollection>.TradesPerformance.<TradesPerformanceValues>.LargestLoser`

## Examples

```csharp
protected override void OnBarUpdate()
{
    // Print out the largest loss of all trades in currency
    Print("Largest loss of all trades is: " + SystemPerformance.AllTrades.TradesPerformance.Currency.LargestLoser);
}
```