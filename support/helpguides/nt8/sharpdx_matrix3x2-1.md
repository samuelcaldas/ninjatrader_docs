﻿
NinjaScript > SharpDX SDK Reference > SharpDX > Matrix3x2

SharpDX.Matrix3x2

| << [Click to Display Table of Contents](sharpdx_matrix3x2.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [SharpDX SDK Reference](sharpdx_sdk_reference-1.md) > [SharpDX](sharpdx-1.md) > SharpDX.Matrix3x2 | [Previous page](sharpdx_disposebase_isdisposed-1.md) [Return to chapter overview](sharpdx-1.md) [Next page](sharpdx_rectanglef-1.md) |
| --- | --- |

| Disclaimer: The [SharpDX SDK Reference](sharpdx_sdk_reference-1.md) section was compiled from the official [SharpDX Documentation](http://sharpdx.org/) and was NOT authored by NinjaTrader.  The contents of this section are provided as-is and only cover a fraction of what is available from the SharpDX SDK.  This page was intended only as a reference guide to help you get started with some of the 2D Graphics concepts used in the NinjaTrader.Custom assembly.  Please refer to the official SharpDX Documentation for additional members not covered in this reference.  For more seasoned graphic developers, the original MSDN [Direct2D1](https://msdn.microsoft.com/en-us/library/windows/desktop/dd370990.aspx) and [DirectWrite](https://msdn.microsoft.com/en-us/library/windows/desktop/dd368038.aspx) unmanaged API documentation can also be helpful for understanding the DirectX/Direct2D run-time environment. For NinjaScript development purposes, we document only essential members in the structure of this page. |
| --- |

## Definition
Represents a 3x2 mathematical matrix. 
 

| Tip:  For more information on Direct2D transforms, please see the [MSDN Direct2D Transforms Overview](https://msdn.microsoft.com/en-us/library/dd756655(v=vs.85).aspx) |
| --- |

## Syntax
struct Matrix3x2
## Constructors

| new Matrix3x2() | Initializes a new instance of the Matrix3x2 struct |
| --- | --- |
## 
## 
## Methods and Properties

| Identity | Gets the identity matrix. |
| --- | --- |
| M11 | A float for the first element of the first row. |
| M12 | A float for the second element of the first row. |
| M21 | A float for the first element of the second row. |
| M22 | A float for the second element of the second row. |
| M31 | A float for the first element of the third row. |
| M32 | A float for the second element of the third row. |
| TranslationVector | A [SharpDX.Vector2](sharpdx_vector2-1.md) for the translation component of this matrix. |
| Matrix3x2.Rotation(float angle) | Creates a matrix that rotates. |
| Matrix3x2.Scaling(float scale) | Creates a matrix that uniformally scales along all three axis. |
| Translation([Vector2](sharpdx_vector2-1.md) value) | Creates a translation matrix using the specified offsets. |
