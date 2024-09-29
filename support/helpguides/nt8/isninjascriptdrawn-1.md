


NinjaScript \> Language Reference \> Drawing Tool \> ChartAnchor \> IsNinjaScriptDrawn






















IsNinjaScriptDrawn







| \<\< [Click to Display Table of Contents](isninjascriptdrawn.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Drawing Tool](drawing_tools-1.md) \> [ChartAnchor](chartanchor-1.md) \> IsNinjaScriptDrawn | [Previous page](isediting-1.md) [Return to chapter overview](chartanchor-1.md) [Next page](isxpropertiesvisible-1.md) |
| --- | --- |











## Definition


Indicates if the chart anchor was drawn by a NinjaScript object (such as an indicator or strategy).


 


## Property Value


A bool value which returns true of the object was drawn by other NinjaScript object; otherwise false.  This property is read\-only.


 


## Syntax


# \<ChartAnchor\>.IsNinjaScriptDrawn


 


## Examples




| ns |
| --- |
| //unlocks the NinjaScript drawn object and allows the user to modify the anchor, while the NinjaScript object still 'owns' the object protected override void OnBarUpdate() {      foreach(IDrawingTool dt in DrawObjects)          {            DrawingTools.Line sampleLine \= dt as DrawingTools.Line;                         if (sampleLine !\= null \&\& sampleLine.StartAnchor.IsNinjaScriptDrawn)            {                sampleLine.IsLocked \= false;                Print(sampleLine.StartAnchor.ToString());            }          } } |









