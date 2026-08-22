# AverageTotalEfficiency

## Definition

Returns the average total efficiency.

## Property Value

A double value that represents the average total efficiency.

## Syntax

`<TradeCollection>.TradesPerformance.AverageTotalEfficiency`

## Examples

![Ns](../images/ns.png)

```csharp
protected override void OnBarUpdate()
{
    // Print out the average total efficiency
    Print("Average total efficiency is: " + SystemPerformance.AllTrades.TradesPerformance.AverageTotalEfficiency);
}
```