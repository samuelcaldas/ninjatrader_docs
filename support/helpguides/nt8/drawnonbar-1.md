



DrawnOnBar

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\drawnonbar.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Drawing Tool](drawing_tools-1.htm) > [ChartAnchor](chartanchor-1.htm) >  DrawnOnBar | [Previous page](drawingtool-1.htm) [Return to chapter overview](chartanchor-1.htm) [Next page](getpoint-1.htm) |

Definition
----------

Gets the current bar value that the chart anchor is drawn by a NinjaScript object.  Please see the [Drawing](drawing-1.htm) section for more information.

|  |
| --- |
| Note:  This value will NOT work on manually drawn objects.  This property is reserved for chart anchors which were drawn by another NinjaScript object (e.g, using a Draw method in an indicator).  For manually drawn objects, please see the [SlotIndex](barindex-1.htm) property |

Property Value
--------------

A int value that value which the current bar the chart anchor is drawn.  This property is read-only.

Syntax
------

<ChartAnchor>.DrawnOnBar
========================

Examples
--------

| ns |
| --- |
| //Places text if high is 2419 and prints what bar the text was drawn on  if (High[0] == 2419)  {   Text myText = Draw.Text(this, @"Text " + CurrentBar, @"High is 2419" , 0, High[0]);   Print("Text is on bar " + myText.Anchor.DrawnOnBar);  } |