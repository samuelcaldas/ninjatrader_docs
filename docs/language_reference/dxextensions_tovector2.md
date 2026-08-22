# ToVector2()

## Definition

Converts a System.Windows.Point structure to a SharpDX.Vector2 used for [SharpDX rendering](../drawing_tools/using_sharpdx_for_custom_chart_rendering.md).

## Method Return Value

A new [SharpDX.Vector2](../drawing_tools/sharpdx_vector2.md) constructed with the point parameters X and Y values

## Syntax

DxExtensions.ToVector2(this System.Windows.Point point)  
<point>.ToVector2()

 

## Parameters

| Name / Option | Description |
| --- | --- |
| point | The [System.Windows.Point](https://msdn.microsoft.com/en-us/library/system.windows.point(v=vs.110).aspx) point to convert |

## Example

![Ns](../images/ns.png)

```csharp
// gets the application/user WPF point and converts to a SharpDX Vector
System.Windows.Point wpfPoint = ChartControl.MouseDownPoint;
SharpDX.Vector2 dxVector2 = wpfPoint.ToVector2();
```