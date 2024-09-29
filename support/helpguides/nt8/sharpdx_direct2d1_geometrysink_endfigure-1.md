


NinjaScript \> SharpDX SDK Reference \> SharpDX.Direct2D1 \> GeometrySink \> EndFigure()






















SharpDX.Direct2D1\.GeometrySink.EndFigure()







| \<\< [Click to Display Table of Contents](sharpdx_direct2d1_geometrysink_endfigure.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [SharpDX SDK Reference](sharpdx_sdk_reference-1.md) \> [SharpDX.Direct2D1](sharpdx_direct2d1-1.md) \> [GeometrySink](sharpdx_direct2d1_geometrysink-1.md) \> SharpDX.Direct2D1\.GeometrySink.EndFigure() | [Previous page](sharpdx_direct2d1_geometrysink_close-1.md) [Return to chapter overview](sharpdx_direct2d1_geometrysink-1.md) [Next page](sharpdx_direct2d1_geometrysink_setfillmode-1.md) |
| --- | --- |













| Disclaimer: The [SharpDX SDK Reference](sharpdx_sdk_reference-1.md) section was compiled from the official [SharpDX Documentation](http://sharpdx.org/) and was NOT authored by NinjaTrader.  The contents of this section are provided as\-is and only cover a fraction of what is available from the SharpDX SDK.  This page was intended only as a reference guide to help you get started with some of the 2D Graphics concepts used in the NinjaTrader.Custom assembly.  Please refer to the official SharpDX Documentation for additional members not covered in this reference.  For more seasoned graphic developers, the original MSDN [Direct2D1](https://msdn.microsoft.com/en-us/library/windows/desktop/dd370990.aspx) and [DirectWrite](https://msdn.microsoft.com/en-us/library/windows/desktop/dd368038.aspx) unmanaged API documentation can also be helpful for understanding the DirectX/Direct2D run\-time environment. For NinjaScript development purposes, we document only essential members in the structure of this page. |
| --- |



 


 


## Definition


Ends the current figure; optionally, closes it.


(See also [unmanaged API documentation](https://msdn.microsoft.com/en-us/library/dd316934.aspx))


 


## Method Return Value


This method does not return a value


 


## Syntax


\<GeometrySink\>.EndFigure(FigureEnd figureEnd)


## Parameters




| figureEnd | A [SharpDX.Direct2D1\.FigureEnd](sharpdx_direct2d1_figureend-1.md) value that indicates whether the current figure is closed. If the figure is closed, a line is drawn between the current point and the start point specified by [BeginFigure()](sharpdx_direct2d1_geometrysink_beginfigure-1.md). |
| --- | --- |









