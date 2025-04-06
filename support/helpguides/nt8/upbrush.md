



UpBrush

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](upbrush.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Chart Style](chart_style.htm) >  UpBrush | [Previous page](transformbrush.htm) [Return to chapter overview](chart_style.htm) [Next page](upbrushdx.htm) |

Definition
----------

A [Brush](https://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object used to determine the color to paint the up bars for the ChartStyle.

|  |
| --- |
| Note: This Windows Presentation Forms (WPF) implementation of the Brush class is not directly used to paint bars on the chart. Instead it is converted to a SharpDX Brush in the [UpBrushDX](upbrushdx.htm) property. This property is used to capture user input for changing brush colors. |

Property  Value
---------------

A [WPF](https://msdn.microsoft.com/en-us/library/ms754130(v=vs.110).aspx) Brush object used to paint the up bars

Syntax
------

UpBrush

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()  {     if (State == State.Configure)     {         // Set a new name for the UpBrush property         SetPropertyName("UpBrush", "AdvancingBrush");     }  } |