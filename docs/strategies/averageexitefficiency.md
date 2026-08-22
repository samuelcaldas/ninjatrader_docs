# AverageExitEfficiency

## Definition

Returns the average exit efficiency.

## Property Value

A double value that represents the average exit efficiency.

## Syntax

`<TradeCollection>.TradesPerformance.AverageExitEfficiency`

## Examples

```csharp
protected override void OnBarUpdate()
{
    // Print out the average exit efficiency
    Print("Average exit efficiency is: " + SystemPerformance.AllTrades.TradesPerformance.AverageExitEfficiency);
}
```