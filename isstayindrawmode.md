# IsStayInDrawMode

## Definition

Indicates [Stay in Draw Mode](working_with_drawing_tools__ob.md) is currently enabled on the chart.

## Property Value

A bool value. When True, indicates that Stay in Draw Mode is enabled on the chart; otherwise False.

## Syntax

<ChartControl>.IsStayInDrawMode

## Examples

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
    // Print a message if Stay in Draw Mode is enabled
    if(chartControl.IsStayInDrawMode);
    Print("Stay in Draw Mode is currently enabled");
}
```
