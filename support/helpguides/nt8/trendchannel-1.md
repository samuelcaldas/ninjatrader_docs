
NinjaScript > Language Reference > Common > Drawing > Draw.TrendChannel() > TrendChannel
TrendChannel
| << [Click to Display Table of Contents](trendchannel.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Drawing](drawing-1.md) > [Draw.TrendChannel()](draw_trendchannel-1.md) > TrendChannel | [Previous page](draw_trendchannel-1.md) [Return to chapter overview](draw_trendchannel-1.md) [Next page](draw_triangle-1.md) |
| --- | --- |
## Definition
Represents an interface that exposes information regarding a Trend Channel [IDrawingTool](idrawingtool-1.md).
 
## Methods and Properties
| TrendStartAnchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the starting point of the drawing object |
| --- | --- |
| TrendEndAnchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the end point of the drawing object |
| ParallelStartAnchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the starting point of the second line used in the trend channel |
| [PriceLevels](pricelevels-1.md) | A collection of prices calculated by the drawing object |

## 
## 
## 
## Example
| ns |
| --- |
| // Instantiate a TrendChannel object TrendChannel myTC = Draw.TrendChannel(this, "tag1", true, 10, Low[10], 0, High[0], 10, High[10] + 5 * TickSize);              // Increase the y-axis position of the object's TrendEndAnchor myTC.TrendEndAnchor.Price += 15; |
