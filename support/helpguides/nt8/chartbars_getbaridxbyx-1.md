
NinjaScript > Language Reference > Common > Charts > ChartBars > GetBarIdxByX()
GetBarIdxByX()
| << [Click to Display Table of Contents](chartbars_getbaridxbyx.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Charts](chart-1.md) > [ChartBars](chartbars-1.md) > GetBarIdxByX() | [Previous page](chartbars_getbaridxbytime-1.md) [Return to chapter overview](chartbars-1.md) [Next page](chartbars_gettimebybaridx-1.md) |
| --- | --- |
## Definition
Returns the [ChartBars](chartbars-1.md) index value at a specified x-coordinate relative to the ChartControl.
 
## Method Return Value
An int value representing the bar index
## 
## Syntax
ChartBars.GetBarIdxByX(ChartControl chartControl, int x)
## 
## Method Parameters
| chartControl | The [ChartControl](chartcontrol-1.md) object used to determine the chart's time axis |
| --- | --- |
| x | The x-coordinate used to find a bar index value |
## 
## 
## Examples
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    // get the users mouse down point and convert to device pixels for DPI accuracy    int mousePoint = chartControl.MouseDownPoint.X.ConvertToHorizontalPixels(chartControl.PresentationSource);        // convert mouse point to bar index    int barIdx = ChartBars.GetBarIdxByX(chartControl, mousePoint);        Print("User clicked on Bar #" + barIdx); } |

