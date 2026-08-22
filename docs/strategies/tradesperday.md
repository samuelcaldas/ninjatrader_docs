# TradesPerDay

## Definition

Returns the average number of trades per day.

## Property Value

An int value that represents the average number of trades per day.

## Syntax

`<TradeCollection>.TradesPerformance.TradesPerDay`

## Examples

![Ns](../images/ns.png)

```csharp
protected override void OnBarUpdate()
{
    // Print out the average number of trades per day of all trades
    Print("Average # of trades per day is: " + SystemPerformance.AllTrades.TradesPerformance.TradesPerDay);
}
```