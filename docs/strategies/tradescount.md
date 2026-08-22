# TradesCount

## Definition

Returns the total # of trades.

## Property Value

A double value that represents the total # of trades.

## Syntax

`<TradeCollection>.TradesPerformance.TradesCount`

## Examples

```csharp
protected override void OnBarUpdate()
{
    // Print out the total # of trades
    Print("Trades count is: " + SystemPerformance.AllTrades.TradesPerformance.TradesCount);
}
```