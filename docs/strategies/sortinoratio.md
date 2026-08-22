# SortinoRatio

## Definition

Returns the Sortino ratio using a [[[risk free return](riskfreereturn.md).

## Property Value

A double value that represents the Sortino ratio using a risk free return.

## Syntax

`<TradeCollection>.TradesPerformance.SortinoRatio`

## Examples

```csharp
protected override void OnBarUpdate()
{
    // Set a 0% risk free return
    SystemPerformance.AllTrades.TradesPerformance.RiskFreeReturn = 0;
    // Print out the Sortino ratio of all trades based on a zero risk free return
    Print("Sortino ratio is: " + SystemPerformance.AllTrades.TradesPerformance.SortinoRatio);
}
```
