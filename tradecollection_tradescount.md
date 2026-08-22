# TradesCount

## Definition

Indicates the number of trades in the collection.

## Property Value

An int value that represents the number of trades in the collection.

## Syntax

`<TradeCollection>.Count`

## Examples

```csharp
protected override void OnBarUpdate()
{
    // Print out the number of long trades
    Print("The strategy has taken " + SystemPerformance.LongTrades.TradesCount + " long trades.");
}
```
