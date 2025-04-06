



IsXPropertiesVisible

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\isxpropertiesvisible.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Drawing Tool](drawing_tools-1.htm) > [ChartAnchor](chartanchor-1.htm) >  IsXPropertiesVisible | [Previous page](isninjascriptdrawn-1.htm) [Return to chapter overview](chartanchor-1.htm) [Next page](isypropertyvisibile-1.htm) |

Definition
----------

Indicates the anchor's X properties are visible on the UI.  When set to true, the X values can be viewed from the Drawing Objects properties.

Property Value
--------------

A bool value which when true will display the anchor's X (time) data values from the drawing object properties; otherwise false.  Default value is true.

Syntax
------

<ChartAnchor>.IsXPropertiesVisibile
===================================

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()  {       if (State == State.SetDefaults)      {  MyAnchor = new ChartAnchor();  MyAnchor.IsXPropertiesVisible = true;      }      else if (State == State.Configure)      {         }  } |