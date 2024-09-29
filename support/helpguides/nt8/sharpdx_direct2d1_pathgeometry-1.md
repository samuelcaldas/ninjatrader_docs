


NinjaScript \> SharpDX SDK Reference \> SharpDX.Direct2D1 \> PathGeometry






















SharpDX.Direct2D1\.PathGeometry







| \<\< [Click to Display Table of Contents](sharpdx_direct2d1_pathgeometry.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [SharpDX SDK Reference](sharpdx_sdk_reference-1.md) \> [SharpDX.Direct2D1](sharpdx_direct2d1-1.md) \> SharpDX.Direct2D1\.PathGeometry | [Previous page](sharpdx_direct2d1_measuringmode-1.md) [Return to chapter overview](sharpdx_direct2d1-1.md) [Next page](sharpdx_direct2d1_pathgeometry_figurecount-1.md) |
| --- | --- |













| Disclaimer: The [SharpDX SDK Reference](sharpdx_sdk_reference-1.md) section was compiled from the official [SharpDX Documentation](http://sharpdx.org/) and was NOT authored by NinjaTrader.  The contents of this section are provided as\-is and only cover a fraction of what is available from the SharpDX SDK.  This page was intended only as a reference guide to help you get started with some of the 2D Graphics concepts used in the NinjaTrader.Custom assembly.  Please refer to the official SharpDX Documentation for additional members not covered in this reference.  For more seasoned graphic developers, the original MSDN [Direct2D1](https://msdn.microsoft.com/en-us/library/windows/desktop/dd370990.aspx) and [DirectWrite](https://msdn.microsoft.com/en-us/library/windows/desktop/dd368038.aspx) unmanaged API documentation can also be helpful for understanding the DirectX/Direct2D run\-time environment. For NinjaScript development purposes, we document only essential members in the structure of this page. |
| --- |



 


 


## Definition


Represents a complex shape that may be composed of arcs, curves, and lines. 


(See also [unmanaged API documentation](http://msdn.microsoft.com/en-us/library/dd371512.aspx))


 




| Notes:    1\.A PathGeometry object enables you to describe a geometric path. To describe an PathGeometry object's path, use the object's [Open](sharpdx_direct2d1_pathgeometry_open-1.md) method to retrieve an [GeometrySink](sharpdx_direct2d1_geometrysink-1.md). Use the sink to populate the path geometry with figures and segments.2\.PathGeometry objects are device\-independent resources created by Factory. In general, you should create geometries once and retain them for the life of the application, or until they need to be modified. Please see the [MSDN Direct2D Resources Overview](https://msdn.microsoft.com/en-us/library/dd756757(v=vs.85).aspx) for more information. |
| --- |



 


## Syntax


class PathGeometry


## Constructors




| new PathGeometry(Factory factory) | Creates an empty PathGeometry. |
| --- | --- |



## 


## 




| Tips:   1\.For NinjaScript development purposes, when creating a PathGemeory object you should use the [NinjaTrader.Core.Globals.D2DFactory](d2dfactory-1.md) property2\.General information Direct2D Path Geometries can be found  on the [MSDN Path Geometries Overview](https://msdn.microsoft.com/en-us/library/ee264309(v=vs.85).aspx) |
| --- |



## 


## 


## Methods and Properties




| [Dispose()](sharpdx_disposebase_dispose-1.md) | Performs application\-defined tasks associated with freeing, releasing, or resetting unmanaged resources. (Inherited from [SharpDX.DisposeBase](sharpdx_disposebase-1.md).) |
| --- | --- |
| [FigureCount](sharpdx_direct2d1_pathgeometry_figurecount-1.md) | Retrieves the number of figures in the path geometry. |
| [FillContainsPoint()](sharpdx_direct2d1_pathgeometry_fillcontainspoint-1.md) | Indicates whether the area filled by the geometry would contain the specified point given the specified flattening tolerance. |
| [GetBounds()](sharpdx_direct2d1_pathgeometry_getbounds-1.md) | Retrieves the bounds of the geometry. |
| [IsDisposed](sharpdx_disposebase_isdisposed-1.md) | Gets a value indicating whether this instance is disposed.  (Inherited from [SharpDX.DisposeBase](sharpdx_disposebase-1.md).) |
| [Open()](sharpdx_direct2d1_pathgeometry_open-1.md) | Retrieves the geometry sink that is used to populate the path geometry with figures and segments. |
| [SegmentCount](sharpdx_direct2d1_pathgeometry_segmentcount-1.md) | Retrieves the number of segments in the path geometry. |
| [StrokeContainsPoint()](sharpdx_direct2d1_pathgeometry_strokecontainspoint-1.md) | Determines whether the geometry's stroke contains the specified point given the specified stroke thickness, style, and transform. |









