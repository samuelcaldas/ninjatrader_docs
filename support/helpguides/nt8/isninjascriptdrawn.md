



IsNinjaScriptDrawn

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](isninjascriptdrawn.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Drawing Tool](drawing_tools.htm) > [ChartAnchor](chartanchor.htm) >  IsNinjaScriptDrawn | [Previous page](isediting.htm) [Return to chapter overview](chartanchor.htm) [Next page](isxpropertiesvisible.htm) |

Definition
----------

Indicates if the chart anchor was drawn by a NinjaScript object (such as an indicator or strategy).

Property Value
--------------

A bool value which returns true of the object was drawn by other NinjaScript object; otherwise false.  This property is read-only.

Syntax
------

<ChartAnchor>.IsNinjaScriptDrawn
================================

Examples
--------

| ns |
| --- |
| //unlocks the NinjaScript drawn object and allows the user to modify the anchor, while the NinjaScript object still 'owns' the object  protected override void OnBarUpdate()  {       foreach(IDrawingTool dt in DrawObjects)           {             DrawingTools.Line sampleLine = dt as DrawingTools.Line;                           if (sampleLine != null && sampleLine.StartAnchor.IsNinjaScriptDrawn)             {                 sampleLine.IsLocked = false;                 Print(sampleLine.StartAnchor.ToString());             }           }  } |