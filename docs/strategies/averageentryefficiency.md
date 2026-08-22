# AverageEntryEfficiency

## Definition

Returns the average entry efficiency.

## Property Value

A double value that represents the average entry efficiency.

## Syntax

`<TradeCollection>.TradesPerformance.AverageEntryEfficiency`

## Examples

![Ns](../images/ns.png)

```csharp
protected override void OnBarUpdate()
{
    // Print out the average entry efficiency
    Print("Average entry efficiency is: " + SystemPerformance.AllTrades.TradesPerformance.AverageEntryEfficiency);
}
```