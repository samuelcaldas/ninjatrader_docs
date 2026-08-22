# MaxConsecutiveLoser

## Definition

Returns the maximum number of consecutive losers seen.

## Property Value

An int value that represents the maximum number of consecutive losers seen.

## Syntax

`<TradeCollection>.TradesPerformance.MaxConsecutiveLoser`

## Examples

```csharp
protected override void OnBarUpdate()
{
    // Print out the max consecutive losers of all trades
    Print("Max # of consecutive losers is: " + SystemPerformance.AllTrades.TradesPerformance.MaxConsecutiveLoser);
}
```
