# ZOrderType

## Definition

Determines the order in which the drawing tool will be rendered. This will help control the [ZOrder](../strategies/chart_zorder.md) index between chart objects

## Property Value

An enum determining the drawing tool's ZOrder type.  Possible values are:

|  |  |
| --- | --- |
| DrawingToolZOrder.Normal | Default behavior, drawing tools are rendered as they appear in the [ZOrder](../strategies/chart_zorder.md) index |
| DrawingToolZOrder.AlwaysDrawnFirst | Ensures the drawing tool is always the first to be rendered |
| DrawingToolZOrder.AlwaysDrawnLast | Ensures the drawing tool is always the last object to be rendered |

## Syntax

ZOrderType

## Examples

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        Name
        = @"My Drawing Tool";
        // always draw this last
        ZOrderType
        = DrawingToolZOrder.AlwaysDrawnLast;
    }
    else if (State == State.Configure)
    {
    }
}
```
