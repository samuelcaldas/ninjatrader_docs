



ZOrderType

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\zordertype.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Drawing Tool](drawing_tools-1.htm) >  ZOrderType | [Previous page](supportsalerts-1.htm) [Return to chapter overview](drawing_tools-1.htm) [Next page](import_type-1.htm) |

Definition
----------

Determines the order in which the drawing tool will be rendered. This will help control the [ZOrder](chart_zorder-1.htm) index between chart objects

Property Value
--------------

An enum determining the drawing tool's ZOrder type.  Possible values are:

|  |  |
| --- | --- |
| DrawingToolZOrder.Normal | Default behavior, drawing tools are rendered as they appear in the [ZOrder](chart_zorder-1.htm) index |
| DrawingToolZOrder.AlwaysDrawnFirst | Ensures the drawing tool is always the first to be rendered |
| DrawingToolZOrder.AlwaysDrawnLast | Ensures the drawing tool is always the last object to be rendered |

Syntax
------

ZOrderType

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()  {     if (State == State.SetDefaults)     {       Name               = @"My Drawing Tool";                   // always draw this last        ZOrderType           = DrawingToolZOrder.AlwaysDrawnLast;     }     else if (State == State.Configure)     {     }  } |