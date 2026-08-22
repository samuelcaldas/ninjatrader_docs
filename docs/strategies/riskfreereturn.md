# RiskFreeReturn

## Definition

The risk free return used in calculations of [Sharpe](sharperatio.md) and [Sortino](sortinoratio.md) ratios.

## Property Value

A double value that represents the risk free return.

## Syntax

`<TradeCollection>.TradesPerformance.RiskFreeReturn`

## Examples

```csharp
protected override void OnBarUpdate()
{
    // Set a 3.5% risk free return
    SystemPerformance.AllTrades.TradesPerformance.RiskFreeReturn = 0.035;
    // Print out the Sharpe ratio of all trades based on a 3.5% risk free return
    Print("Sharpe ratio is: " + SystemPerformance.AllTrades.TradesPerformance.SharpeRatio);
}
```
