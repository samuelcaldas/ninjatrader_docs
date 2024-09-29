


NinjaScript \> Language Reference \> Common \> Charts \> ChartControl \> MouseDownPoint






















MouseDownPoint







| \<\< [Click to Display Table of Contents](mousedownpoint.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Charts](chart-1.md) \> [ChartControl](chartcontrol-1.md) \> MouseDownPoint | [Previous page](lasttimepainted-1.md) [Return to chapter overview](chartcontrol-1.md) [Next page](presentationsource-1.md) |
| --- | --- |











## Definition


Indicates the WPF x\- and y\-coordinates of the mouse cursor at the most recent OnMouseDown() event.


## 


## Property Value


A [Point](https://msdn.microsoft.com/en-us/library/system.drawing.point(v=vs.110).aspx) object containing x\- and y\-coordinates of the mouse cursor when the left mouse button is clicked or held


## 


## Syntax


\<ChartControl\>.MouseDownPoint


## 


## Examples




| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    Point cursorPoint \= chartControl.MouseDownPoint;      // Print the x\- and y\-coordinates of the mouse cursor when clicked    Print(String.Format("Mouse clicked at coordinates {0},{1}", cursorPoint.X, cursorPoint.Y)); } |









