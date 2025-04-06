



IsYPropertyVisibile

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\isypropertyvisibile.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Drawing Tool](drawing_tools-1.htm) > [ChartAnchor](chartanchor-1.htm) >  IsYPropertyVisibile | [Previous page](isxpropertiesvisible-1.htm) [Return to chapter overview](chartanchor-1.htm) [Next page](moveanchor-1.htm) |

Definition
----------

Indicates the anchor's Y properties are visible on the UI.  When set to true, the Y values can be viewed from the Drawing Objects properties.

Property Value
--------------

A bool value which when true will display the anchor's Y (price) data values from the drawing object properties; otherwise false.  Default value is true.

Syntax
------

<ChartAnchor>.IsYPropertyVisibile
=================================

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()  {       if (State == State.SetDefaults)      {  MyAnchor = new ChartAnchor();  MyAnchor.IsYPropertyVisibile = true;      }      else if (State == State.Configure)      {         }  } |