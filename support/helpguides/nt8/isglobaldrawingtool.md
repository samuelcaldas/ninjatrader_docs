


NinjaScript \> Language Reference \> Drawing Tool \> IsGlobalDrawingTool






















IsGlobalDrawingTool







| \<\< [Click to Display Table of Contents](isglobaldrawingtool.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Drawing Tool](drawing_tools.md) \> IsGlobalDrawingTool | [Previous page](isattachedtoninjascript.md) [Return to chapter overview](drawing_tools.md) [Next page](islocked.md) |
| --- | --- |











## Definition


Indicates if the drawing tool is currently set as a Global Drawing object. Global draw objects display on any chart which matches the parent chart's underlying instrument.


 


## Property Value


A bool value which returns true if the drawing tool is currently attached as a global drawing object; otherwise false. 


 


## Syntax


IsGlobalDrawingTool


 


## Examples




| ns |
| --- |
| public override void OnMouseMove(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint) {       // do not interact if attached to global chart    if (IsGlobalDrawingTool)      return; } |









