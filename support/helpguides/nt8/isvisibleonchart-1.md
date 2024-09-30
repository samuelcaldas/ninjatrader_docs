
NinjaScript > Language Reference > Common > Charts > Rendering > IsVisibleOnChart()
IsVisibleOnChart()
| << [Click to Display Table of Contents](isvisibleonchart.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Charts](chart-1.md) > [Rendering](rendering-1.md) > IsVisibleOnChart() | [Previous page](isselected-1.md) [Return to chapter overview](rendering-1.md) [Next page](maxvalue-1.md) |
| --- | --- |
## Definition
Indicates a chart object is visible on the chart. When the IsVisibleOnChart() method determines a chart object is not visible and returns false, the object will not be used in a render pass, will not be considered in a hit test, and will not be used for alerting.  The base implementation is to always return true on all chart objects, however this behavior can be overridden for your custom object if desired.  
## 
## Method Return Value
A virtual bool value which when true, the object will be rendered and can be interacted with by a user; otherwise false.  Default value is true.
 
## Syntax
You must override this method using the following syntax:
## 
public override bool IsVisibleOnChart(ChartControl chartControl, ChartScale chartScale, DateTime firstTimeOnChart, DateTime lastTimeOnChart)  

{  

   return true;  

}
 
## Method Parameters
| chartControl | A [ChartControl](chartcontrol-1.md) representing the x-axis |
| --- | --- |
| chartScale | A [ChartScale](chartscale-1.md) representing the y-axis |
| firstTimeOnChart | A DateTime representing the first painted bar displayed on the chart |
| lastTimeOnChart | A DateTime representing the last painted bar displayed on the chart |

 
## 
## Examples
| ns |
| --- |
| public override bool IsVisibleOnChart(ChartControl chartControl, ChartScale chartScale, DateTime firstTimeOnChart, DateTime lastTimeOnChart) {    // check if any chart anchors are visible    foreach (ChartAnchor anchor in Anchors)    {      if (anchor.Time >= firstTimeOnChart && anchor.Time <= lastTimeOnChart)          return true;    }    return false; // otherwise the object should not be displayed          } |
