
NinjaScript \> Language Reference \> Common \> Drawing \> Draw.GannFan() \> GannFan
GannFan
| \<\< [Click to Display Table of Contents](gannfan.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Drawing](drawing.md) \> [Draw.GannFan()](draw_gannfan.md) \> GannFan | [Previous page](draw_gannfan.md) [Return to chapter overview](draw_gannfan.md) [Next page](draw_horizontalline.md) |
| --- | --- |
## Definition
Represents an interface that exposes information regarding a Gann Fan [IDrawingTool.](idrawingtool.md)
 
## Methods and Properties
| Anchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the starting point of the drawing object |
| --- | --- |
| [PriceLevels](pricelevels.md) | A collection of prices calculated by the drawing object |
| GannFanDirection | Possible values:   GannFanDirection.DownLeft GannFanDirection.DownRight GannFanDirection.UpLeft GannFanDirection.UpRight |
| PointsPerBar | A double value representing the number of points per bar |
| IsTextDisplayed | A bool value representing if text will be drawn along with the draw object |
## 
## 
## Example
| ns |
| --- |
| // Instantiate a GannFan object GannFan myFan \= Draw.GannFan(this, "tag1", true, 0, Low\[0]);   // Instantiate a new PriceLevel to be used in the step below PriceLevel myLevel \= new PriceLevel(99, Brushes.Black);   // Change the object's price level at index 3 myFan.PriceLevels\[3] \= myLevel; |

