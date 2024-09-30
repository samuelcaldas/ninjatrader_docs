
NinjaScript \> Language Reference \> Common \> Charts \> Rendering \> DxExtensions \> ToVector2()

ToVector2()
| \<\< [Click to Display Table of Contents](dxextensions_tovector2.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Charts](chart-1.md) \> [Rendering](rendering-1.md) \> [DxExtensions](dxextensions-1.md) \> ToVector2() | [Previous page](dxextensions_todxbrush-1.md) [Return to chapter overview](dxextensions-1.md) [Next page](forcerefresh-1.md) |
| --- | --- |
## Definition
Converts a System.Windows.Point structure to a SharpDX.Vector2 used for [SharpDX rendering](using_sharpdx_for_custom_chart_rendering-1.md).
## 
## Method Return Value
A new [SharpDX.Vector2](sharpdx_vector2-1.md) constructed with the point parameters X and Y values
## 
## Syntax
DxExtensions.ToVector2(this System.Windows.Point point)  

\<point\>.ToVector2()
 
## Parameters
| point | The [System.Windows.Point](https://msdn.microsoft.com/en-us/library/system.windows.point(v=vs.110).aspx) point to convert |
| --- | --- |

## 
## 
## Example
| ns |
| --- |
| // gets the application/user WPF point and converts to a SharpDX Vector  System.Windows.Point wpfPoint \= ChartControl.MouseDownPoint;   SharpDX.Vector2 dxVector2 \= wpfPoint.ToVector2(); |
