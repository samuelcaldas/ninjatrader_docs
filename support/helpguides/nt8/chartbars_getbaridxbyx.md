



GetBarIdxByX()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](chartbars_getbaridxbyx.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [Charts](chart.htm) > [ChartBars](chartbars.htm) >  GetBarIdxByX() | [Previous page](chartbars_getbaridxbytime.htm) [Return to chapter overview](chartbars.htm) [Next page](chartbars_gettimebybaridx.htm) |

Definition
----------

Returns the [ChartBars](chartbars.htm) index value at a specified x-coordinate relative to the ChartControl.

 

Method Return Value
-------------------

An int value representing the bar index

Syntax 
ChartBars.GetBarIdxByX(ChartControl chartControl, int x)
----------------------------------------------------------------

Method Parameters
-----------------

|  |  |
| --- | --- |
| chartControl | The [ChartControl](chartcontrol.htm) object used to determine the chart's time axis |
| x | The x-coordinate used to find a bar index value |

Examples
--------

| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale)  {     // get the users mouse down point and convert to device pixels for DPI accuracy     int mousePoint = chartControl.MouseDownPoint.X.ConvertToHorizontalPixels(chartControl.PresentationSource);          // convert mouse point to bar index     int barIdx = ChartBars.GetBarIdxByX(chartControl, mousePoint);          Print("User clicked on Bar #" + barIdx);  } |