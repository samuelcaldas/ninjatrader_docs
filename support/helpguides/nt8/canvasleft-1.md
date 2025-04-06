



CanvasLeft

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\canvasleft.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Charts](chart-1.htm) > [ChartControl](chartcontrol-1.htm) >  CanvasLeft | [Previous page](barwidtharray-1.htm) [Return to chapter overview](chartcontrol-1.htm) [Next page](canvasright-1.htm) |

Definition
----------

Indicates the x-coordinate (in pixels) of the beginning of the chart canvas area.

Property Value
--------------

A double representing the beginning of the chart canvas area.

Syntax
------

<ChartControl>.CanvasLeft

Examples
--------

| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale)  {     // Store the beginning and ending x-coordinates of the canvas area     double canvasBeginCoordinate = chartControl.CanvasLeft;     double canvasEndCoordinate = chartControl.CanvasRight;        // Print the stored values     Print(String.Format("Chart canvas begins at x-coordinate {0} and ends at x-coordinate {1}", canvasBeginCoordinate, canvasEndCoordinate));   } |

 

 

Based on the image below, CanvasLeft reveals that the chart canvas area begins at x-coordinate 53.

 

![ChartControl_CanvasLeft](chartcontrol_canvasleft.png)

|  |
| --- |
| Note: When no data series are left-aligned on a chart, CanvasLeft will return 0, representing the x-coordinate origin, because the chart canvas will begin at coordinate 0. |