# CurrentValue

## Definition

The value to be displayed in the Market Analyzer Column

## Property Value

A double representing the value to be displayed in the column

## Syntax

CurrentValue

## Example

![Ns](../images/ns.png)

```csharp
protected override void OnMarketData(Data.MarketDataEventArgs marketDataUpdate)
{
    CurrentValue = marketDataUpdate.Price;
}
```