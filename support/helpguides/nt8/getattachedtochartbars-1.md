
NinjaScript > Language Reference > Drawing Tool > GetAttachedToChartBars()
GetAttachedToChartBars()
| << [Click to Display Table of Contents](getattachedtochartbars.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Drawing Tool](drawing_tools-1.md) > GetAttachedToChartBars() | [Previous page](drawnby-1.md) [Return to chapter overview](drawing_tools-1.md) [Next page](getclosestanchor-1.md) |
| --- | --- |
## Definition
Returns information which relate to the underlying bars series in which the drawing tool is attached.  If the drawing tool is attached to an indicator rather than a bar series, the indicator's bars series used for input will be returned.
 
| Note: For drawing tools made global, this method will not be returning meaningful values - since those are not attached to a specific bars series |
| --- |
## 
## Method Return Value
A [ChartBars](chartbars-1.md) object
## 
## Syntax
GetAttachedToChartBars()
## 
## Method Parameters
This method does not accept any parameters
## 
## Examples
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {       // get the attached chart bars    ChartBars myBars = GetAttachedToChartBars();        Print(myBars.Bars.ToChartString()); // NQ 03-15 (1 Minute) } |

