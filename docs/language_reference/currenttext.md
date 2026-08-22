# CurrentText

## Definition

Sets text to be displayed in the Market Analyzer column.

> **Note:** CurrentText will overrule any value set for [[[CurrentValue](currentvalue.md). If both CurrentValue and CurrentText have assigned values, the value of CurrentText will display in the column.

## Property Value

A string representing text to display in the column

## Syntax

CurrentText

## Example

```csharp
protected override void OnMarketData(MarketDataEventArgs marketDataUpdate)
{
    // Print "Ask" in the column if an Ask price update is received
    if(marketDataUpdate.MarketDataType == MarketDataType.Ask)
    CurrentText = "Ask";
}
```
