
NinjaScript > Language Reference > Chart Style > UpBrush
UpBrush
| << [Click to Display Table of Contents](upbrush.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Chart Style](chart_style-1.md) > UpBrush | [Previous page](transformbrush-1.md) [Return to chapter overview](chart_style-1.md) [Next page](upbrushdx-1.md) |
| --- | --- |
## Definition
A [Brush](https://msdn.microsoft.com/en-us/library/system.windows.media.brush(v=vs.110).aspx) object used to determine the color to paint the up bars for the ChartStyle.
 
| Note: This Windows Presentation Forms (WPF) implementation of the Brush class is not directly used to paint bars on the chart. Instead it is converted to a SharpDX Brush in the [UpBrushDX](upbrushdx-1.md) property. This property is used to capture user input for changing brush colors. |
| --- |

## Property  Value
A [WPF](https://msdn.microsoft.com/en-us/library/ms754130(v=vs.110).aspx) Brush object used to paint the up bars
 
## Syntax
UpBrush
## 
 
## Examples
| ns |
| --- |
| protected override void OnStateChange() {    if (State == State.Configure)    {        // Set a new name for the UpBrush property        SetPropertyName("UpBrush", "AdvancingBrush");    } } |
