# SharpeRatio

## Definition

Returns the Sharpe ratio using a [risk free return](riskfreereturn.md).

## Property Value

A double value that represents the Sharpe ratio using a risk free return.

## Syntax

`<TradeCollection>.TradesPerformance.SharpeRatio`

## Examples

```csharp
protected override void OnBarUpdate()
{
    // Set a 0% risk free return
    SystemPerformance.AllTrades.TradesPerformance.RiskFreeReturn = 0;
    // Print out the Sharpe ratio of all trades based on a zero risk free return
    Print("Sharpe ratio is: " + SystemPerformance.AllTrades.TradesPerformance.SharpeRatio);
}
```
