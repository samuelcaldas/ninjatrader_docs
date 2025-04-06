



CopyDataValues()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\copydatavalues.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Drawing Tool](drawing_tools-1.htm) > [ChartAnchor](chartanchor-1.htm) >  CopyDataValues() | [Previous page](chartanchor-1.htm) [Return to chapter overview](chartanchor-1.htm) [Next page](displayname-1.htm) |

Definition  
Copies the ChartAnchor time and price values from on anchor to another.  This includes the [BarsAgo](barsago.htm), [SlotIndex](barindex-1.htm), [Time](time-1.htm), [Price](price-1.htm), and [DrawnOnBar](drawnonbar-1.htm) values.  This method is useful for updating a chart anchor to a recent data point when the user interacts with the drawing chart anchor.

Method Return Value
-------------------

This method does not return a value.

Syntax
------

<chartAnchor>.CopyDataValues(ChartAnchor toAnchor)

Method Parameters
-----------------

|  |  |
| --- | --- |
| toAnchor | The ChartAnchor to copy |

Examples
--------

| ns |
| --- |
| public override void OnMouseMove(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint)  {        // if the user is moving the draw object, copy the most recent dataPoint to MyAnchor     if (DrawingState == DrawingState.Moving)                dataPoint.CopyDataValues(Anchor);  } |