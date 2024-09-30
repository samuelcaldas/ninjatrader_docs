
NinjaScript > Language Reference > Common > Drawing > IDrawingTool

IDrawingTool
| << [Click to Display Table of Contents](idrawingtool.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Drawing](drawing-1.md) > IDrawingTool | [Previous page](drawingtools_drawobjects-1.md) [Return to chapter overview](drawing-1.md) [Next page](pricelevels-1.md) |
| --- | --- |
## Definition
Represents an interface that exposes information regarding a drawn chart object.
 
IDrawingTool Properties are standard properties that are shared by all drawing tools.  
## 
## Each specific IDrawingTool will have its own uniquely named ChartAnchor representing where the object was drawn on the chart.  The name and number of ChartAnchors will be specific to that drawing tool (e.g., StartAnchor, EndAnchor, etc), however the fields available will be the same (e.g., BarsAgo, DrawnOnBar, etc).  Details on those shared fields are outlined in the ChartAnchor Properties section toward the bottom of this topic.
## 
| Note:  For implementing a custom Drawing Tool project, please see the [DrawingTools](drawing_tools-1.md) section of this help guide. |
| --- |

## 
## 
## IDrawingTool Properties
| Anchors | A read-only collection of all of the [IDrawingTool's ChartAnchors](idrawingtool-1.htm#chartanchor) |
| --- | --- |
| AttachedTo | An enum determining where the drawing tool is attached.     Possible values are: - AttachedToType.Bars,- AttachedToType.GlobalInstrument,- AttachedToType.Indicator,- AttachedToType.Strategy |
| DrawingState | The current [DrawingState](drawingstate-1.md) of the drawing tool |
| DrawnBy | An object value indicating which type of NinjaScript the drawing tool originated (null if user drawn) |
| IsAttachedToNinjaScript | A read-only bool indicating if the drawing tool is attached to an indicator or strategy |
| IgnoresUserInput | A read-only bool determining if the drawing tool can be interacted with by the user. |
| IsGlobalDrawingTool | A bool determining if the drawing tool displays on all charts of the instrument |
| IsLocked | A bool determining if the drawing tool can be moved |
| IsSeparateZOrder | A bool determining if the drawing tool will reside on a different ZOrder from the NinjaScript object it was drawn |
| IsUserDrawn | A read-only bool indicating if drawing tool was manually drawn by a user |
| PanelIndex | An int value representing the panel the drawing tool resides |
| SupportsAlerts | A read-only bool indicating if the drawing tool can be used for creating an alert |
| Tag | A string value representing the unique ID of the draw object. (Global draw objects will have an "@" added as a prefix to the string) |
| ZOrderType | An enum indicating the order in which the drawing tool will be drawn.    Possible values are: - DrawingToolZOrder.Normal,- DrawingToolZOrder.AlwaysDrawnFirst,- DrawingToolZOrder.AlwaysDrawnLast |

## ChartAnchor Properties
| <ChartAnchor>.BarsAgo | An int representing the "barsAgo" value that was passed to the Draw method    Note:  This value will NOT be set for objects drawn manually |
| --- | --- |
| <ChartAnchor>.DisplayName | A string representing name of the DrawingTool's chart anchor that is displaying on the UI |
| <ChartAnchor>.DrawingTool | The IDrawingTool object which created the DrawingTool's chart anchor object |
| <ChartAnchor>.DrawnOnBar | An int representing the [CurrentBar](currentbar-1.md) value that the DrawingTool's chart anchor was drawn |
| <ChartAnchor>.IsNinjaScriptDrawn | A bool indicating the object was drawn programmatically |
| <ChartAnchor>.Price | A double representing the price the  DrawingTool's chart anchor was drawn |
| <ChartAnchor>.SlotIndex | A double representing the DrawingTool's chart anchor index value the anchor was drawn |
| <ChartAnchor>.Time | A DateTime representing the time value the DrawingTool's chart anchor was drawn |

 
## 
## Examples
| ns |
| --- |
| Text myText; protected override void OnBarUpdate() {       if(CurrentBar == 50)      myText = Draw.Text(this, "tag", "test", 0, High[0]);             if(myText != null)    {                 Print(myText.Anchor.DrawnOnBar); // drawn on bar 50    }     } |
