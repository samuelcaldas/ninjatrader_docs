# NetProfit

## Definition

Returns the net profit.

## Property Value

A double value that represents the net profit.

## Syntax

`<TradeCollection>.TradesPerformance.NetProfit`

## Examples

![Ns](../images/ns.png)

```csharp
protected override void OnBarUpdate()
{
    // Print out the net profit of all trades
    Print("Net profit is: " + SystemPerformance.AllTrades.TradesPerformance.NetProfit);
}
```