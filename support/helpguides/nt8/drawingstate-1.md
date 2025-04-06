



DrawingState

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\drawingstate.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Drawing Tool](drawing_tools-1.htm) >  DrawingState | [Previous page](dispose-1.htm) [Return to chapter overview](drawing_tools-1.htm) [Next page](drawnby-1.htm) |

Definition
----------

Represents the current state of the drawing tool to perform various actions, such as building, editing, or moving.

 

Property Values
---------------

An enum representing the current state of the drawing tool.  Possible values are:

|  |  |
| --- | --- |
| DrawingState.Building | The initial state when a drawing tool is first being drawn, allowing for the anchors to be set for the drawing. |
| DrawingState.Editing | Allows for changing the values of any of the drawing tools anchors |
| DrawingState.Normal | The drawing tool is normal on the chart and is not in a state to allow for changes. |
| DrawingState.Moving | The entire drawing tool to be moved by a user. |

Syntax
------

DrawingState

Examples
--------

| ns |
| --- |
| public override void OnMouseDown(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, Point point)  {     switch(DrawingState)     {                               case DrawingState.Normal:           DrawingState = DrawingState.Editing; // set state to allow editing           break;                case DrawingState.Editing:           // do your edits here           break;       case DrawingState.Moving:           return; // don't allow move whe editing                 }          } |