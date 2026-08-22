# GetOpen()

## Definition

Returns the open price at the selected bar index value.

## Method Return Value

A double value that represents the open price at the desired bar index.

## Syntax

Bars.GetOpen(int index)

## Parameters

| Name / Option | Description |
| --- | --- |
| index | An int representing an absolute bar index value |

## Examples

![Ns](../images/ns.png)

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
    base.OnRender(chartControl, chartScale);
    // loop through only the rendered bars on the chart
    for(int barIndex = ChartBars.FromIndex; barIndex <= ChartBars.ToIndex; barIndex++)
    {
        // get the open price at the selected bar index value
        double openPrice = Bars.GetOpen(barIndex);
        Print("Bar #" + barIndex + " open price is " + openPrice);
    }
}
```