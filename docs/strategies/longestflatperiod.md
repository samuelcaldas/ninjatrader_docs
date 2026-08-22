# LongestFlatPeriod

## Definition

Returns the longest duration of being flat.

## Property Value

A TimeSpan value that represents the longest duration of being flat.

## Syntax

`<TradeCollection>.TradesPerformance.LongestFlatPeriod`

## Examples

![Ns](../images/ns.png)

```csharp
protected override void OnBarUpdate()
{
    // Print out the longest duration of being flat
    Print("Longest flat period: " + SystemPerformance.AllTrades.TradesPerformance.LongestFlatPeriod);
}
```