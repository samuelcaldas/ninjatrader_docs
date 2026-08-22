# MonthlyUlcer

## Definition

Returns the monthly Ulcer index.

## Property Value

A double value that represents the monthly Ulcer index.

## Syntax

`<TradeCollection>.TradesPerformance.MonthlyUlcer`

## Examples

```csharp
protected override void OnBarUpdate()
{
    // Print out the monthly Ulcer index
    Print("Monthly Ulcer index is: " + SystemPerformance.AllTrades.TradesPerformance.MonthlyUlcer);
}
```