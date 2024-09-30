
NinjaScript > Language Reference > Common > Charts > ChartControl > CanvasRight
CanvasRight
| << [Click to Display Table of Contents](canvasright.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Charts](chart-1.md) > [ChartControl](chartcontrol-1.md) > CanvasRight | [Previous page](canvasleft-1.md) [Return to chapter overview](chartcontrol-1.md) [Next page](canvaszoomstate-1.md) |
| --- | --- |
## Definition
Indicates the x-coordinate (in pixels) of the end of the chart canvas area.
## 
## Property Value
A double representing the end of the chart canvas area.
## 
## Syntax
<ChartControl>.CanvasRight
## 
## Examples
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    // Store the beginning and ending x-coordinates of the canvas area    double canvasBeginCoordinate = chartControl.CanvasLeft;    double canvasEndCoordinate = chartControl.CanvasRight;      // Print the stored values    Print(String.Format("Chart canvas begins at x-coordinate {0} and ends at x-coordinate {1}", canvasBeginCoordinate, canvasEndCoordinate));  } |

Based on the image below, CanvasRight reveals that the chart canvas ends at x-coordinate 526.
 
![ChartControl_CanvasRight](chartcontrol_canvasright.png)Yes,

