# MinValue

## Definition

The minimum value used for the automatic scaling of the y axis.  This property will only be used when the chart object is set to [IsAutoScale](isautoscale.md)

## Property Value

A double value

## Syntax

MinValue

## Examples

![Ns](../images/ns.png)

```csharp
public override void OnCalculateMinMax()
{
    if (DrawingState != DrawingState.Building)
    {
        //set the minimum value to the chart anchors price
        MinValue = Anchor.Price;
    }
}
```