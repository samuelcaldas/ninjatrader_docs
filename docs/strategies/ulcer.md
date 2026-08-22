# Ulcer

## Definition

Returns the Ulcer.

## Property Value

A double value that represents the Ulcer.

## Syntax

`<TradeCollection>.TradesPerformance.<TradesPerformanceValues>.Ulcer`

## Examples

![Ns](../images/ns.png)

```csharp
protected override void OnBarUpdate()
{
    // Print out the Ulcer index of all trades
    Print("Turnaround of all trades is: " + SystemPerformance.AllTrades.TradesPerformance.Currency.Ulcer);
}
```