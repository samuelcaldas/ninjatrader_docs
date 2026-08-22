# GetAtmStrategyPositionAveragePrice()

## Definition

Gets the current position's average price of the specified ATM Strategy.

> **Note:** Changes to positions will not be reflected till at least the next [OnBarUpdate()](../language_reference/onbarupdate.md) event after an order fill.

## Method Return Value

A double value representing the average price.

## Syntax

GetAtmStrategyPositionAveragePrice(string atmStrategyId)

 

## Parameters

| Name / Option | Description |
| --- | --- |
| atmStrategyId | The unique identifier for the ATM strategy |

## Examples

```csharp
protected override void OnBarUpdate()
{
    // Check if flat
    if (GetAtmStrategyMarketPosition("id") != MarketPosition.Flat)
    Print("Average price is " + GetAtmStrategyPositionAveragePrice("id").ToString());
}
```