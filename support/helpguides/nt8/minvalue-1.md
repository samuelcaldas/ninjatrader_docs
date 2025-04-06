



MinValue

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\minvalue.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Charts](chart-1.htm) > [Rendering](rendering-1.htm) >  MinValue | [Previous page](maxvalue-1.htm) [Return to chapter overview](rendering-1.htm) [Next page](oncalculateminmax-1.htm) |

Definition
----------

The minimum value used for the automatic scaling of the y axis.  This property will only be used when the chart object is set to [IsAutoScale](isautoscale-1.htm)

Property Value
--------------

A double value

Syntax
------

MinValue

Examples
--------

| ns |
| --- |
| public override void OnCalculateMinMax()  {     if (DrawingState != DrawingState.Building)     {       //set the minimum value to the chart anchors price       MinValue = Anchor.Price;     }  } |