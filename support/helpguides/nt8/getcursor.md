
NinjaScript > Language Reference > Drawing Tool > GetCursor()
GetCursor()
| << [Click to Display Table of Contents](getcursor.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Drawing Tool](drawing_tools.md) > GetCursor() | [Previous page](getclosestanchor.md) [Return to chapter overview](drawing_tools.md) [Next page](getselectionpoints.md) |
| --- | --- |
## Definition
An event driven method which is called when a chart object is selected.  This method can be used to change the cursor image used in various states.
 
## Method Return Value
This method returns a [Cursor](https://msdn.microsoft.com/en-us/library/system.windows.forms.cursor(v=vs.110).aspx) used to paint the mouse pointer.
## 
## Syntax
You must override the method in your Drawing Tool with the following syntax:
 
public override Cursor GetCursor(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, Point point)
{
 
}
## 
## Method Parameters
| chartControl | A [ChartControl](chartcontrol.md) representing the x-axis |
| --- | --- |
| chartPanel | A [ChartPanel](chartpanel.md) representing the the panel for the chart |
| chartScale | A [ChartScale](chartscale.md) representing the y-axis |
| point | A Point in device pixels representing the current mouse cursor position |
## 
## 
## Examples
| ns |
| --- |
| public override Cursor GetCursor(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, Point point) {    switch (DrawingState)    {      //when drawing, display the cursor as a pen      case DrawingState.Building:   return Cursors.Pen;        // when moving, display a four-headed sizing cursor      case DrawingState.Moving:   return Cursors.SizeAll;        default: return Cursors.Pen;    } } |

