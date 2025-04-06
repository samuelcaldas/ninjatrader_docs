



GannFan

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\gannfan.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Drawing](drawing-1.htm) > [Draw.GannFan()](draw_gannfan-1.htm) >  GannFan | [Previous page](draw_gannfan-1.htm) [Return to chapter overview](draw_gannfan-1.htm) [Next page](draw_horizontalline-1.htm) |

Definition
----------

Represents an interface that exposes information regarding a Gann Fan [IDrawingTool.](idrawingtool-1.htm)

Methods and Properties
----------------------

|  |  |
| --- | --- |
| Anchor | An [IDrawingTool's ChartAnchor](idrawingtool-1.htm#chartanchor) representing the starting point of the drawing object |
| [PriceLevels](pricelevels-1.htm) | A collection of prices calculated by the drawing object |
| GannFanDirection | Possible values:    GannFanDirection.DownLeft  GannFanDirection.DownRight  GannFanDirection.UpLeft  GannFanDirection.UpRight |
| PointsPerBar | A double value representing the number of points per bar |
| IsTextDisplayed | A bool value representing if text will be drawn along with the draw object |

Example
-------

| ns |
| --- |
| // Instantiate a GannFan object  GannFan myFan = Draw.GannFan(this, "tag1", true, 0, Low[0]);     // Instantiate a new PriceLevel to be used in the step below  PriceLevel myLevel = new PriceLevel(99, Brushes.Black);     // Change the object's price level at index 3  myFan.PriceLevels[3] = myLevel; |