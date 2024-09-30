
NinjaScript > Language Reference > Drawing Tool > IsAttachedToNinjaScript

IsAttachedToNinjaScript

| << [Click to Display Table of Contents](isattachedtoninjascript.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Drawing Tool](drawing_tools.md) > IsAttachedToNinjaScript | [Previous page](ignoresuserinput.md) [Return to chapter overview](drawing_tools.md) [Next page](isglobaldrawingtool.md) |
| --- | --- |
## Definition
Indicates if the drawing tool is currently [attached to](attachedto.md) a NinjaScript object (such an indicator or a strategy).
 
## Property Value
A bool value which when true if the drawing tool is attached to a NinjaScript object; otherwise false.  This property is read-only.
 
## Syntax
IsAttachedToNinjaScript
 
## Examples

| ns |
| --- |
| public override void OnMouseMove(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint) {       // do not interact if drawn by an indicator or strategy    if (IsAttachedToNinjaScript)      return; } |
