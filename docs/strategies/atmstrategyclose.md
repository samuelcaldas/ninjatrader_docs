# AtmStrategyClose()

## Definition

Cancels any working orders and closes any open position of a strategy using the default [ATM strategy close behavior](../addons/closing_a_position_or_atm_stra.md).

 

## Method Return Value

Returns true if the specified ATM strategy was found; otherwise false.

> **Note:** A method return value of true in NO WAY indicates that the strategy in fact is closed. It indicates that the the specified ATM strategy was found and the internal close routine was triggered.

## Syntax

AtmStrategyClose(string atmStrategyId)

## Parameters

| Name / Option | Description |
| --- | --- |
| atmStrategyId | The unique identifier for the ATM strategy |

## Examples

```csharp
protected override void OnBarUpdate()
{
    // Check for valid condition and create an ATM Strategy
    if (GetAtmStrategyUnrealizedProfitLoss("idValue") > 500)
    AtmStrategyClose("idValue");
}
```