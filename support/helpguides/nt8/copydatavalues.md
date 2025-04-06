



CopyDataValues()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](copydatavalues.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Drawing Tool](drawing_tools.htm) > [ChartAnchor](chartanchor.htm) >  CopyDataValues() | [Previous page](chartanchor.htm) [Return to chapter overview](chartanchor.htm) [Next page](displayname.htm) |

Definition  
Copies the ChartAnchor time and price values from on anchor to another.  This includes the [BarsAgo](barsago.htm), [SlotIndex](barindex.htm), [Time](time.htm), [Price](price.htm), and [DrawnOnBar](drawnonbar.htm) values.  This method is useful for updating a chart anchor to a recent data point when the user interacts with the drawing chart anchor.

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