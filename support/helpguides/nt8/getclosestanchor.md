
NinjaScript > Language Reference > Drawing Tool > GetClosestAnchor()
GetClosestAnchor()
| << [Click to Display Table of Contents](getclosestanchor.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Drawing Tool](drawing_tools.md) > GetClosestAnchor() | [Previous page](getattachedtochartbars.md) [Return to chapter overview](drawing_tools.md) [Next page](getcursor.md) |
| --- | --- |
## Definition
Returns the closest chart anchor within a specified maximum distance from the mouse cursor.
 
## Method Return Value
This method returns an existing [ChartAnchor](chartanchor.md)
## 
## Syntax
GetClosestAnchor(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, double maxDist, Point point)
## 
## Method Parameters
| chartControl | A ChartControl representing the x-axis |
| --- | --- |
| chartPanel | A ChartPanel representing the the panel for the chart |
| chartScale | A ChartScale representing the y-axis |
| maxDist | A double value representing the cursor's sensitivity used to detect the nearest anchor |
| point | A Point in device pixels representing the current mouse cursor position |

## Examples
| ns |
| --- |
| public override Cursor GetCursor(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, Point point) {             // get the closest anchor to where the user has clicked    ChartAnchor   closest = GetClosestAnchor(chartControl, chartPanel, chartScale, 10, point);      if (closest != null)    {      // set cursor to indicate that it can be moved      return Cursors.SizeNWSE;    }       // otherwise set cursor back to arrow    else return Cursors.Arrow; } |

