


NinjaScript \> Language Reference \> Chart Style \> DownBrush






















DownBrush







| \<\< [Click to Display Table of Contents](downbrush.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Chart Style](chart_style.md) \> DownBrush | [Previous page](chartstyletype.md) [Return to chapter overview](chart_style.md) [Next page](downbrushdx.md) |
| --- | --- |











## Definition


A [Brush](https://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object used to determine the color to paint the down bars for the ChartStyle.


 




| Note: This Windows Presentation Forms (WPF) implementation of the Brush class is not directly used to paint bars on the chart. Instead it is converted to a SharpDX Brush in the [DownBrushDX](downbrushdx.md) property. This property is used to capture user input for changing brush colors. |
| --- |



 


 


## Property  Value


A [WPF](https://msdn.microsoft.com/en-us/library/ms754130(v=vs.110).aspx) Brush object used to paint the down bars


 


## Syntax


DownBrush


 


## Example




| ns |
| --- |
| protected override void OnStateChange() {    if (State \=\= State.Configure)    {        // Set a new name for the DownBrush property        SetPropertyName("DownBrush", "DecliningBrush");    } } |









