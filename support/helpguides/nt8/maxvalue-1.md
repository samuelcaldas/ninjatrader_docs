



MaxValue

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\maxvalue.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Charts](chart-1.htm) > [Rendering](rendering-1.htm) >  MaxValue | [Previous page](isvisibleonchart-1.htm) [Return to chapter overview](rendering-1.htm) [Next page](minvalue-1.htm) |

Definition
----------

The maximum value used for the automatic scaling of the y axis.  This property will only be used when the chart object is set to [IsAutoScale](isautoscale-1.htm)

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