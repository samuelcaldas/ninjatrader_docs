



ToDxBrush()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\dxextensions_todxbrush.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Charts](chart-1.htm) > [Rendering](rendering-1.htm) > [DxExtensions](dxextensions-1.htm) >  ToDxBrush() | [Previous page](dxextensions-1.htm) [Return to chapter overview](dxextensions-1.htm) [Next page](dxextensions_tovector2-1.htm) |

Definition
----------

Converts a WPF Brush to a SharpDX Brush used for [SharpDX rendering](using_sharpdx_for_custom_chart_rendering-1.htm). Supports SolidColorBrush, LinearGradientBrush, and RadialGradientBrush types.

|  |
| --- |
| Note: If you are using a large number of brushes, and are not tied to WPF resources, you should favor creating the SharpDX Brush directly since the ToDxBrush() method can lead to performance issues if called too frequently during a single render pass. |

Method Return Value
-------------------

A new [SharpDX.Direct2D1.Brush](sharpdx_direct2d1_brush-1.htm) constructed colors and brush properties of the WPF brush

Syntax
------

DxExtensions.ToDxBrush(this System.Windows.Media.Brush brush, RenderTarget renderTarget)  
<WPFBrush>.ToDxBrush(RenderTarget renderTarget)

 

Parameters
----------

|  |  |
| --- | --- |
| brush | The [System.Windows.Media.Brush](https://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) to convert |
| renderTarget | The [RenderTarget](rendertarget-1.htm) associated with the brush resource |

Example
-------

| ns |
| --- |
| protected override void OnStateChange()  {     if (State == State.SetDefaults)     {       Name = "Example ToDXBrush";          // pushes the WPF brush to the UI for user to configure       TextBrush = System.Windows.Media.Brushes.DodgerBlue;     }     }  protected override void OnRender(ChartControl chartControl, ChartScale chartScale)  {     // convert user WPF selection to a DX brush     SharpDX.Direct2D1.Brush dxBrush = TextBrush.ToDxBrush(RenderTarget);        using (dxBrush)     {       RenderTarget.FillRectangle(new RectangleF(ChartPanel.X, ChartPanel.Y, ChartPanel.W, ChartPanel.H), dxBrush);     }  }     // the WPF exposed to the UI which the user defines  [XmlIgnore]  public System.Windows.Media.Brush TextBrush { get; set; }     [Browsable(false)]  public string TextBrushSerialize  {     get { return Serialize.BrushToString(TextBrush); }     set { TextBrush = Serialize.StringToBrush(value); }  } |