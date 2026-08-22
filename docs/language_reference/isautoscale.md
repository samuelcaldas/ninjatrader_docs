# IsAutoScale

## Definition

If true, the object will call [CalculateMinMax()](oncalculateminmax.md) in order to determine the object's [MinValue](minvalue.md) and [MaxValue](maxvalue.md) value used to scale the Y-axis of the chart.

## Property Value

This property returns true if the object's are included in the y-scale; otherwise, false. Default set to false for [DrawingTools](../drawing_tools/drawing_tools.md), but set to true for [Indicators](../indicators/indicator.md).

> **Warning:** This property should ONLY bet set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults or State.Configure

## Syntax

IsAutoScale

## Example

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        Name
        = "Example Indicator";

![Ns](../images/ns.png)

        // set this to true to call CalculateMinMix() to ensure drawing tool is fully rendered in chart scale
        IsAutoScale = true;
    }
    else if (State == State.Configure)
    {
    }
}
```