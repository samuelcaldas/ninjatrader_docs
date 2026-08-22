# CrosshairType

## Definition

Indicates the [[[Cross Hair](../operations/cross_hair.md) type currently enabled on the chart.

## Property Value

An enum specifying the type of Cross Hair currently enabled on the chart. Possible values are listed below:

|  |  |
| --- | --- |
| Local | The local (single-chart) Cross Hair is enabled |
| Global | Global Cross Hair |
| GlobalNoTimeScroll | Global Cross Hair (No Time Scroll) is enabled |

## Syntax

<ChartControl>.CrosshairType

## Examples

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
    // Print a message if the user enables the Global Cross Hair without time scrolling
    if (chartControl.CrosshairType == CrosshairType.GlobalNoTimeScroll)
    Print("It is recommended to enable Global Cross Hair time scrolling with this indicator");
}
```

 

 

In the image below, CrosshairType reveals that Global Cross Hair (No Time Scroll) is enabled on the chart.

 

![[[ChartControl_CrosshairType](../images/chartcontrol_crosshairtype.png)
