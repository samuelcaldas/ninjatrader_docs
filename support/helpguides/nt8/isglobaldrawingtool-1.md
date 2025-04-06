



IsGlobalDrawingTool

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\isglobaldrawingtool.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Drawing Tool](drawing_tools-1.htm) >  IsGlobalDrawingTool | [Previous page](isattachedtoninjascript-1.htm) [Return to chapter overview](drawing_tools-1.htm) [Next page](islocked-1.htm) |

Definition
----------

Indicates if the drawing tool is currently set as a Global Drawing object. Global draw objects display on any chart which matches the parent chart's underlying instrument.

Property Value
--------------

A bool value which returns true if the drawing tool is currently attached as a global drawing object; otherwise false.

Syntax
------

IsGlobalDrawingTool

 

Examples
--------

| ns |
| --- |
| public override void OnMouseMove(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint)  {        // do not interact if attached to global chart     if (IsGlobalDrawingTool)       return;  } |