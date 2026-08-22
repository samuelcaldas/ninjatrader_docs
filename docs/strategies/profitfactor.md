# ProfitFactor

## Definition

Returns the profit factor.

## Property Value

A double value that represents the profit factor.

## Syntax

`<TradeCollection>.TradesPerformance.ProfitFactor`

## Examples

```csharp
protected override void OnBarUpdate()
{
    // Print out the profit factor of all trades
    Print("Profit factor is: " + SystemPerformance.AllTrades.TradesPerformance.ProfitFactor);
}
```