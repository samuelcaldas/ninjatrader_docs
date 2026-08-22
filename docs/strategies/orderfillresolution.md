# OrderFillResolution

## Definition

Determines how strategy orders are filled during historical states.

Please see [Understanding Historical Fill Processing](understanding_historical_fill_.md) for general information on historical fill processing.

## Property Value

An enum value that determines how the strategy orders are filled.  Default value is set to OrderFillResolution.Standard.  Possible values are:

| Name / Option | Description |
| --- | --- |
| OrderFillResolution.Standard | Faster - Uses the existing bar type and interval that you are running the backtest on to fill your orders. |
| OrderFillResolution.High | More granular - Allows you to set a secondary bar series to be used as the price data to fill your orders.   (See also [OrderFillResolutionType](orderfillresolutiontype.md) and [OrderFillResolutionValue](orderfillresolutionvalue.md)) |

## Syntax

`OrderFillResolution`

> **Warning:** This property should ONLY bet set from the [OnStateChange()](../language_reference/onstatechange.md) method during State.SetDefaults

## Examples

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        Name = "ExampleStrategy";
        OrderFillResolution = OrderFillResolution.Standard;
    }
}
```