# AtmStrategyChangeStopTarget()

## Definition

Changes the price of the specified order of the specified ATM strategy.

## Method Return Value

Returns true if the specified order was found; otherwise false.

## Syntax

AtmStrategyChangeStopTarget(double limitPrice, double stopPrice, string orderName, string atmStrategyId)

## Parameters

| Name / Option | Description |
| --- | --- |
| limitPrice | Order limit price |
| stopPrice | Order stop price |
| orderName | The order name such as "Stop1" or "Target2" |
| atmStrategyId | The unique identifier for the ATM strategy |

## Examples

```csharp
protected override void OnBarUpdate()
{
    AtmStrategyChangeStopTarget(0, SMA(10)[0], "Stop1", "AtmIdValue");
}
```