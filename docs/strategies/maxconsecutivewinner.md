# MaxConsecutiveWinner

## Definition

Returns the maximum number of consecutive winners seen.

## Property Value

An int value that represents the maximum number of consecutive winners seen.

## Syntax

`<TradeCollection>.TradesPerformance.MaxConsecutiveWinner`

## Examples

![Ns](../images/ns.png)

```csharp
protected override void OnBarUpdate()
{
    // Print out the max consecutive winners of all trades
    Print("Max # of consecutive winners is: " + SystemPerformance.AllTrades.TradesPerformance.MaxConsecutiveWinner);
}
```