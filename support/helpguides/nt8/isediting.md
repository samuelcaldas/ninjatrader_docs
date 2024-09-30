
NinjaScript \> Language Reference \> Drawing Tool \> ChartAnchor \> IsEditing
IsEditing
| \<\< [Click to Display Table of Contents](isediting.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Drawing Tool](drawing_tools.md) \> [ChartAnchor](chartanchor.md) \> IsEditing | [Previous page](isbrowsable.md) [Return to chapter overview](chartanchor.md) [Next page](isninjascriptdrawn.md) |
| --- | --- |
Definition  

Determines if the anchor can be edited.
 
## Property Value
A bool value which when true determines if the chart anchor is currently in a state it can be edited.  Default is false.
 
## Syntax
# \<ChartAnchor\>.IsEditing
## 
## Examples
| ns |
| --- |
| public override void OnMouseDown(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, Point point) { if(DrawingState \=\= DrawingState.Building) {    // if drawing tool is currently editing, update to current mouse point if(MyAnchor.IsEditing) {  MyAnchor.UpdateFromPoint(point, chartControl, chartScale);    //set the anchor to disable editing when done updating  MyAnchor.IsEditing \= false;                                         } } } |
