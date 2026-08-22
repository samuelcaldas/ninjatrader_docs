# Currency

## Definition

Returns a [[[TradesPerformanceValues](tradesperformancevalues.md) object in currency.

## Property Value

A TradesPerformanceValues object that is represented in currency.

## Syntax

`<TradeCollection>.TradesPerformance.Currency`

## Examples

```csharp
protected override void OnBarUpdate()
{
    // Print out the avg. profit of all trades in currency
    Print("Average profit: " + SystemPerformance.AllTrades.TradesPerformance.Currency.AverageProfit);
}
```
