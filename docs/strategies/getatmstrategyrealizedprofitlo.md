# GetAtmStrategyRealizedProfitLoss()

## Definition

Gets the realized profit and loss value of the specified ATM Strategy.

## Method Return Value

A double value representing the realized profit and loss.

## Syntax

GetAtmStrategyRealizedProfitLoss(string atmStrategyId)

 

## Parameters

| Name / Option | Description |
| --- | --- |
| atmStrategyId | The unique identifier for the ATM strategy |

## Examples

![Ns](../images/ns.png)

```csharp
protected override void OnBarUpdate()
{
    Print("PnL is " + GetAtmStrategyRealizedProfitLoss("id").ToString());
}
```