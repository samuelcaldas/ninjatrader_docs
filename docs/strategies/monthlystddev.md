# MonthlyStdDev

## Definition

Returns the monthly standard deviation.

## Property Value

A double value that represents the monthly standard deviation.

## Syntax

`<TradeCollection>.TradesPerformance.MonthlyStdDev`

## Examples

![Ns](../images/ns.png)

```csharp
protected override void OnBarUpdate()
{
    // Print out the monthly standard deviation
    Print("Monthly standard deviation is: " + SystemPerformance.AllTrades.TradesPerformance.MonthlyStdDev);
}
```