# ChartObjects

## Definition

A collection of objects configured on the chart panel

## Property Value

An [IList](https://msdn.microsoft.com/en-us/library/system.collections.ilist(v=vs.110).aspx) of Gui.NinjaScript.IChartObject instances containing references to the objects configured on the panel

## Syntax

ChartPanel.ChartObjects

## Example

```csharp
protected override void OnRender(ChartControl chartControl, ChartScale chartScale)
{
    base.OnRender(chartControl, chartScale);
    IList<Gui.NinjaScript.IChartObject> myObjects = ChartPanel.ChartObjects;
    foreach (Gui.NinjaScript.IChartObject thisObject in myObjects)
    {
        Print(String.Format("{0} is of type {1}", thisObject.Name, thisObject.GetType()));
    }
}
```

 

 

The image below shows the output of the code example above, while applied in a chart panel with three objects.

![Ns](../images/ns.png)

 

![ChartPanel_ChartObjects](../images/chartpanel_chartobjects.png)