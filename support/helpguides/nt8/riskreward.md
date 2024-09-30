
NinjaScript \> Language Reference \> Common \> Drawing \> Draw.RiskReward() \> RiskReward
RiskReward
| \<\< [Click to Display Table of Contents](riskreward.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Drawing](drawing.md) \> [Draw.RiskReward()](draw_riskreward.md) \> RiskReward | [Previous page](draw_riskreward.md) [Return to chapter overview](draw_riskreward.md) [Next page](draw_ruler.md) |
| --- | --- |
## Definition
Represents an interface that exposes information regarding a Risk Reward [IDrawingTool](idrawingtool.md).
 
## Methods and Properties
| EntryAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the entry point of the drawing object |
| --- | --- |
| RiskAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the stop loss point of the drawing object |
| RewardAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.htm#chartanchor) representing the profit target point of the drawing object |
| Ratio | An int value determining the calculated ratio between the risk or reward based on the entry point |

## 
## 
## Example
| ns |
| --- |
| // Instantiate a RiskReward object RiskReward myRR \= Draw.RiskReward(this, "tag1", false, 0, High\[0], 10, Low\[0], 2, true);   // Change the object's risk/reward ratio to 2:1 myRR.Ratio \= 2; |
