
NinjaScript > Language Reference > Drawing Tool > ChartAnchor > DrawingTool

DrawingTool
| << [Click to Display Table of Contents](drawingtool.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Drawing Tool](drawing_tools-1.md) > [ChartAnchor](chartanchor-1.md) > DrawingTool | [Previous page](displayname-1.md) [Return to chapter overview](chartanchor-1.md) [Next page](drawnonbar-1.md) |
| --- | --- |
## Definition
The DrawingTool object which owns a chart anchor.
 
## Property Value
A IDrawingTool object representing the owner of the chart anchor
 
## Syntax
# <ChartAnchor>.DrawingTool
## 
## Examples
| ns |
| --- |
| protected override void OnStateChange() {      if (State == State.SetDefaults)      {    Name = "SampleDrawingTool";        MyAnchor = new ChartAnchor(); MyAnchor.DrawingTool = this; //NinjaTrader.NinjaScript.DrawingTools.SampleDrawingTool      }      else if (State == State.Configure)      {        } } |
