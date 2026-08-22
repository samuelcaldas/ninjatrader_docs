# RiskReward

## Definition

Represents an interface that exposes information regarding a Risk Reward [IDrawingTool](idrawingtool.md).

## Methods and Properties

| Name / Option | Description |
| --- | --- |
| EntryAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.md#chartanchor) representing the entry point of the drawing object |
| RiskAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.md#chartanchor) representing the stop loss point of the drawing object |
| RewardAnchor | An [IDrawingTool's ChartAnchor](idrawingtool.md#chartanchor) representing the profit target point of the drawing object |
| Ratio | An int value determining the calculated ratio between the risk or reward based on the entry point |

## Example

![Ns](../images/ns.png)

```csharp
// Instantiate a RiskReward object
RiskReward myRR = Draw.RiskReward(this, "tag1", false, 0, High[0], 10, Low[0], 2, true);
// Change the object's risk/reward ratio to 2:1
myRR.Ratio = 2;
```