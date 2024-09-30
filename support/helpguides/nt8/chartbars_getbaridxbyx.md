
NinjaScript \> Language Reference \> Common \> Charts \> ChartBars \> GetBarIdxByX()
GetBarIdxByX()
| \<\< [Click to Display Table of Contents](chartbars_getbaridxbyx.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Charts](chart.md) \> [ChartBars](chartbars.md) \> GetBarIdxByX() | [Previous page](chartbars_getbaridxbytime.md) [Return to chapter overview](chartbars.md) [Next page](chartbars_gettimebybaridx.md) |
| --- | --- |
## Definition
Returns the [ChartBars](chartbars.md) index value at a specified x\-coordinate relative to the ChartControl.
 
## Method Return Value
An int value representing the bar index
## 
## Syntax
ChartBars.GetBarIdxByX(ChartControl chartControl, int x)
## 
## Method Parameters
| chartControl | The [ChartControl](chartcontrol.md) object used to determine the chart's time axis |
| --- | --- |
| x | The x\-coordinate used to find a bar index value |
## 
## 
## Examples
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    // get the users mouse down point and convert to device pixels for DPI accuracy    int mousePoint \= chartControl.MouseDownPoint.X.ConvertToHorizontalPixels(chartControl.PresentationSource);        // convert mouse point to bar index    int barIdx \= ChartBars.GetBarIdxByX(chartControl, mousePoint);        Print("User clicked on Bar \#" \+ barIdx); } |

