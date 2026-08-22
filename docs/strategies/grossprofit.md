# GrossProfit

## Definition

Returns the gross profit.

## Property Value

A double value that represents the gross profit.

## Syntax

`<TradeCollection>.TradesPerformance.GrossProfit`

## Examples

![Ns](../images/ns.png)

```csharp
protected override void OnBarUpdate()
{
    // Print out the gross profit of all trades
    Print("Gross profit is: " + SystemPerformance.AllTrades.TradesPerformance.GrossProfit);
}
```