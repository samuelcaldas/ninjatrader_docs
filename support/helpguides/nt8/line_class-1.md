



Line Class

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\line_class.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Indicator](indicator-1.htm) > [AddLine()](addline-1.htm) >  Line Class | [Previous page](arelinesconfigurable-1.htm) [Return to chapter overview](addline-1.htm) [Next page](lines-1.htm) |

Definition
----------

Objects derived from the Line class are used to characterize how an oscillator line is visually displayed (plotted) on a chart.

Properties
----------

|  |  |
| --- | --- |
| Brush | The System.Windows.Media.Brush used to construct the line ([reference](https://msdn.microsoft.com/en-us/library/system.windows.media.brushes%28v=vs.110%29.aspx)) |
| BrushDX | A [SharpDX.Direct2D1.Brush](sharpdx_direct2d1_brush-1.htm) used to actually render the line    Note:  To avoid and resolve access violation exceptions, please see Warning and examples remarked below |
| DashStyleDX | A [SharpDX.Direct2D1.DashStyle](sharpdx_direct2d1_strokestyle_dashstyle-1.htm) used to render the stroke style    Note:  To avoid and resolve access violation exceptions, please see Warning and examples remarked below |
| DashStyleHelper | A dashstyle used to construct the stroke. Possible values are:    •DashStyleHelper.Dash  •DashStyleHelper.DashDot  •DashStyleHelper.DashDotDot  •DashStyleHelper.Dot  •DashStyleHelper.Solid |
| Name | A string representing the name of the line |
| RenderTarget | The [RenderTarget](rendertarget-1.htm) drawing context used for the line.    Note: This property must be set before accessing a stroke's BrushDX property. Please see Warning and examples remarked below |
| StrokeStyle | A [SharpDX.Direct2D1.StrokeStyle](sharpdx_direct2d1_strokestyle-1.htm) |
| Value | A double representing the value of the line |
| Width | A float representing the width in pixels |

Examples
--------

See the [AddLine(](addline-1.htm)) method for examples.