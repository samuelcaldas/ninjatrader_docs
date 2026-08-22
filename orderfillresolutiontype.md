# OrderFillResolutionType

## Definition

Determines the bars type which will be used for historical fill processing.

> **Note:** This property will only be valid if the [OrderFillResolution](orderfillresolution.md) is set to OrderFillResolution.High

## Property Value

A [BarsPeriodType](barsperiod.md) representing the type of bars during historical order processing.  Default value is set to BarsPeriodType.Minute.

## Syntax

`OrderFillResolutionType`

> **Warning:** This property should ONLY bet set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults

## Examples

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        Name = "ExampleStrategy";
        // use one second bars for filling orders
        OrderFillResolution
        = OrderFillResolution.High;
        OrderFillResolutionType
        = BarsPeriodType.Second;
        OrderFillResolutionValue
        = 1;
    }
}
```
