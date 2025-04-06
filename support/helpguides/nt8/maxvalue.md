



MaxValue

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](maxvalue.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [Charts](chart.htm) > [Rendering](rendering.htm) >  MaxValue | [Previous page](isvisibleonchart.htm) [Return to chapter overview](rendering.htm) [Next page](minvalue.htm) |

Definition
----------

The maximum value used for the automatic scaling of the y axis.  This property will only be used when the chart object is set to [IsAutoScale](isautoscale.htm)

Property Value
--------------

A double value

Syntax
------

MaxValue

Examples
--------

| ns |
| --- |
| public override void OnCalculateMinMax()  {     if (DrawingState != DrawingState.Building)     {       //set the maximum value to the chart anchors price       MaxValue = Anchor.Price;     }  } |