# OrderFillResolutionValue

## Definition

Determines the bars period interval value which will be used for historical fill processing.

> **Note:** This property will only be valid if the [[[OrderFillResolution](orderfillresolution.md) is set to OrderFillResolution.High

## Property Value

A int representing the interval used for the bars period during historical order processing.  Default value is set to 1.

## Syntax

`OrderFillResolutionValue`

> **Warning:** This property should ONLY bet set from the [[[OnStateChange()](../language_reference/onstatechange.md) method during State.SetDefaults

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
