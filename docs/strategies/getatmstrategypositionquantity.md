# GetAtmStrategyPositionQuantity()

## Definition

Gets the current position quantity of the specified ATM Strategy.

> **Note:** Changes to positions will not be reflected till at least the next [OnBarUpdate()](../language_reference/onbarupdate.md) event after an order fill.

## Method Return Value

An int value representing the quantity.

## Syntax

GetAtmStrategyPositionQuantity(string atmStrategyId)

 

## Parameters

| Name / Option | Description |
| --- | --- |
| atmStrategyId | The unique identifier for the ATM strategy |

## Examples

```csharp
protected override void OnBarUpdate()
{
    // Check if flat
    if (GetAtmStrategyMarketPosition("idValue") != MarketPosition.Flat)
    Print("Position size is " + GetAtmStrategyPositionQuantity("id").ToString());
}
```