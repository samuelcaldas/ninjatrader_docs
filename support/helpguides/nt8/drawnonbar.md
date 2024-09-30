
NinjaScript > Language Reference > Drawing Tool > ChartAnchor > DrawnOnBar

DrawnOnBar
| << [Click to Display Table of Contents](drawnonbar.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Drawing Tool](drawing_tools.md) > [ChartAnchor](chartanchor.md) > DrawnOnBar | [Previous page](drawingtool.md) [Return to chapter overview](chartanchor.md) [Next page](getpoint.md) |
| --- | --- |
## Definition
Gets the current bar value that the chart anchor is drawn by a NinjaScript object.  Please see the [Drawing](drawing.md) section for more information.
## 
| Note:  This value will NOT work on manually drawn objects.  This property is reserved for chart anchors which were drawn by another NinjaScript object (e.g, using a Draw method in an indicator).  For manually drawn objects, please see the [SlotIndex](barindex.md) property |
| --- |

## Property Value
A int value that value which the current bar the chart anchor is drawn.  This property is read-only.
 
## Syntax
# <ChartAnchor>.DrawnOnBar
 
## Examples
| ns |
| --- |
| //Places text if high is 2419 and prints what bar the text was drawn on if (High[0] == 2419) {  Text myText = Draw.Text(this, @"Text " + CurrentBar, @"High is 2419" , 0, High[0]);  Print("Text is on bar " + myText.Anchor.DrawnOnBar); } |
