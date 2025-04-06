



DrawingTool

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\drawingtool.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Drawing Tool](drawing_tools-1.htm) > [ChartAnchor](chartanchor-1.htm) >  DrawingTool | [Previous page](displayname-1.htm) [Return to chapter overview](chartanchor-1.htm) [Next page](drawnonbar-1.htm) |

Definition
----------

The DrawingTool object which owns a chart anchor.

Property Value
--------------

A IDrawingTool object representing the owner of the chart anchor

Syntax
------

<ChartAnchor>.DrawingTool
=========================

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()  {       if (State == State.SetDefaults)      {    Name = "SampleDrawingTool";        MyAnchor = new ChartAnchor();  MyAnchor.DrawingTool = this; //NinjaTrader.NinjaScript.DrawingTools.SampleDrawingTool      }      else if (State == State.Configure)      {         }  } |