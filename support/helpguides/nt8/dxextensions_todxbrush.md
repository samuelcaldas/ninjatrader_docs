


NinjaScript \> Language Reference \> Common \> Charts \> Rendering \> DxExtensions \> ToDxBrush()






















ToDxBrush()







| \<\< [Click to Display Table of Contents](dxextensions_todxbrush.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Charts](chart.md) \> [Rendering](rendering.md) \> [DxExtensions](dxextensions.md) \> ToDxBrush() | [Previous page](dxextensions.md) [Return to chapter overview](dxextensions.md) [Next page](dxextensions_tovector2.md) |
| --- | --- |











## Definition


Converts a WPF Brush to a SharpDX Brush used for [SharpDX rendering](using_sharpdx_for_custom_chart_rendering.md). Supports SolidColorBrush, LinearGradientBrush, and RadialGradientBrush types.


 




| Note: If you are using a large number of brushes, and are not tied to WPF resources, you should favor creating the SharpDX Brush directly since the ToDxBrush() method can lead to performance issues if called too frequently during a single render pass. |
| --- |



## 


## 


## Method Return Value


A new [SharpDX.Direct2D1\.Brush](sharpdx_direct2d1_brush.md) constructed colors and brush properties of the WPF brush


## 


## Syntax


DxExtensions.ToDxBrush(this System.Windows.Media.Brush brush, RenderTarget renderTarget)  

\<WPFBrush\>.ToDxBrush(RenderTarget renderTarget)


 


## Parameters




| brush | The [System.Windows.Media.Brush](https://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) to convert |
| --- | --- |
| renderTarget | The [RenderTarget](rendertarget.md) associated with the brush resource |



## 


## 


## Example




| ns |
| --- |
| protected override void OnStateChange() {    if (State \=\= State.SetDefaults)    {      Name \= "Example ToDXBrush";        // pushes the WPF brush to the UI for user to configure      TextBrush \= System.Windows.Media.Brushes.DodgerBlue;    }   } protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    // convert user WPF selection to a DX brush    SharpDX.Direct2D1\.Brush dxBrush \= TextBrush.ToDxBrush(RenderTarget);      using (dxBrush)    {      RenderTarget.FillRectangle(new RectangleF(ChartPanel.X, ChartPanel.Y, ChartPanel.W, ChartPanel.H), dxBrush);    } }   // the WPF exposed to the UI which the user defines \[XmlIgnore] public System.Windows.Media.Brush TextBrush { get; set; }   \[Browsable(false)] public string TextBrushSerialize {    get { return Serialize.BrushToString(TextBrush); }    set { TextBrush \= Serialize.StringToBrush(value); } } |









