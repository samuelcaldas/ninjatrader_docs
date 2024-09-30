
NinjaScript > Language Reference > Drawing Tool > GetAttachedToChartBars()
GetAttachedToChartBars()
| << [Click to Display Table of Contents](getattachedtochartbars.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Drawing Tool](drawing_tools.md) > GetAttachedToChartBars() | [Previous page](drawnby.md) [Return to chapter overview](drawing_tools.md) [Next page](getclosestanchor.md) |
| --- | --- |
## Definition
Returns information which relate to the underlying bars series in which the drawing tool is attached.  If the drawing tool is attached to an indicator rather than a bar series, the indicator's bars series used for input will be returned.
 
| Note: For drawing tools made global, this method will not be returning meaningful values - since those are not attached to a specific bars series |
| --- |
## 
## Method Return Value
A [ChartBars](chartbars.md) object
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

