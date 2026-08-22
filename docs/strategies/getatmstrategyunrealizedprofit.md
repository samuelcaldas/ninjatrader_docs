# GetAtmStrategyUnrealizedProfitLoss()

## Definition

Gets the unrealized profit and loss value of the specified ATM Strategy.

## Method Return Value

A double value representing the unrealized profit and loss.

## Syntax

GetAtmStrategyUnrealizedProfitLoss(string atmStrategyId)

 

## Parameters

| Name / Option | Description |
| --- | --- |
| atmStrategyId | The unique identifier for the ATM strategy |

## Examples

```csharp
protected override void OnBarUpdate()
{
    Print("Unrealized PnL is " + GetAtmStrategyUnrealizedProfitLoss("id").ToString());
}
```
