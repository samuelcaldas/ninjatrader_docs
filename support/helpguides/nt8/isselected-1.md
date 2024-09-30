
NinjaScript \> Language Reference \> Common \> Charts \> Rendering \> IsSelected

IsSelected

| \<\< [Click to Display Table of Contents](isselected.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Charts](chart-1.md) \> [Rendering](rendering-1.md) \> IsSelected | [Previous page](isinhittest-1.md) [Return to chapter overview](rendering-1.md) [Next page](isvisibleonchart-1.md) |
| --- | --- |
## Definition
Indicates a chart object is currently selected. When this property is set to true in a [DrawingTool](drawingtool-1.md), the [GetSelectionPoints()](getselectionpoints-1.md) will be called.  
 
## Property Value
This property returns true to indicate that the chart object is selected; otherwise, false. Default set to false.  
 

| Warning:  This property value is ONLY guaranteed to be settable by the object to which it belongs (e.g., from within a [DrawingTool](drawing_tools-1.md)).  Modifying its value from an external object (such as attempting to set a DrawingTool.IsSelected from an indicator) can result in the property automatically returning the value handled by its source.  In other words, unless you are working with a chart object type directly (e.g., building a custom drawing tool), the IsSelected property should be considered read\-only. |
| --- |

## Syntax
IsSelected
## 
## Examples

| ns Reading the IsSelected property from an indicator |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    foreach(DrawingTool drawTool in DrawObjects)    {      // only apply logic below to types of "Rectangle")      if(drawTool.GetType().ToString().Contains("Rectangle"))      {          // safely cast as dynamic type at run\-time          dynamic myRect \= drawTool;            // Changes the brush to pink to indicating selected          if(drawTool.IsSelected)          {                        myRect.AreaBrush \= Brushes.Pink;                }                         // otherwise, set back to default value on next render pass          else myRect.AreaBrush \= Brushes.CornflowerBlue;                }    } } |
## 
## 

| ns Explicitly setting the IsSelected property from a DrawingTool type |
| --- |
| public override void OnMouseDown(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint) {                if(DrawingState \=\= DrawingState.Building)    {      if(dataPoint.IsEditing)      {                         // do something                  }          // when done editing anchor, set the state to normal and unselect the drawing object      else if(dataPoint.IsEditing)      {          DrawingState \= DrawingState.Normal;          IsSelected \= false;      }    } } |
