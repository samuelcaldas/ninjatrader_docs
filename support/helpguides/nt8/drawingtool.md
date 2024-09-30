
NinjaScript \> Language Reference \> Drawing Tool \> ChartAnchor \> DrawingTool

DrawingTool
| \<\< [Click to Display Table of Contents](drawingtool.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Drawing Tool](drawing_tools.md) \> [ChartAnchor](chartanchor.md) \> DrawingTool | [Previous page](displayname.md) [Return to chapter overview](chartanchor.md) [Next page](drawnonbar.md) |
| --- | --- |
## Definition
The DrawingTool object which owns a chart anchor.
 
## Property Value
A IDrawingTool object representing the owner of the chart anchor
 
## Syntax
# \<ChartAnchor\>.DrawingTool
## 
## Examples
| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {    Name \= "SampleDrawingTool";        MyAnchor \= new ChartAnchor(); MyAnchor.DrawingTool \= this; //NinjaTrader.NinjaScript.DrawingTools.SampleDrawingTool      }      else if (State \=\= State.Configure)      {        } } |
