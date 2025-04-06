



Price

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\price.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Drawing Tool](drawing_tools-1.htm) > [ChartAnchor](chartanchor-1.htm) >  Price | [Previous page](moveanchory-1.htm) [Return to chapter overview](chartanchor-1.htm) [Next page](barindex-1.htm) |

Definition
----------

Determines price value the chart anchor is drawn.

Property Value
--------------

An double value representing a price value

Syntax
------

<ChartAnchor>.Price

Examples
--------

| ns |
| --- |
| public override void OnMouseDown(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, Point point)  {     Print(MyAnchor.Price); // prints the Y axis data point of the chart anchor      // 1999.25  } |