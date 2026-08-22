# SharpDX.Direct2D1.Color

> **Disclaimer:** The [SharpDX SDK Reference](sharpdx_sdk_reference.md) section was compiled from the official [SharpDX Documentation](http://sharpdx.org/) and was NOT authored by NinjaTrader.  The contents of this section are provided as-is and only cover a fraction of what is available from the SharpDX SDK.  This page was intended only as a reference guide to help you get started with some of the 2D Graphics concepts used in the NinjaTrader.Custom assembly.  Please refer to the official SharpDX Documentation for additional members not covered in this reference.  For more seasoned graphic developers, the original MSDN [Direct2D1](https://msdn.microsoft.com/en-us/library/windows/desktop/dd370990.aspx) and [DirectWrite](https://msdn.microsoft.com/en-us/library/windows/desktop/dd368038.aspx) unmanaged API documentation can also be helpful for understanding the DirectX/Direct2D run-time environment. For NinjaScript development purposes, we document only essential members in the structure of this page.

## Definition

Represents a 32-bit color (4 bytes) in the form of RGBA (in byte order: R, G, B, A).

> **Notes:** 1.The color of each pixel is represented as a 32-bit number: 8 bits each for alpha, red, green, and blue (ARGB). Each of the four components is a number from 0 through 255, with 0 representing no intensity and 255 representing full intensity. The alpha component specifies the transparency of the color: 0 is fully transparent, and 255 is fully opaque. To determine the alpha, red, green, or blue component of a color, use the A, R, G, or B property, respectively.  2.Named colors are represented by using the properties of the Color structure.  Please see the table of Static Named Colors below

## Syntax

struct Color

## Constructors

| Name / Option | Description |
| --- | --- |
| new Color() | Initializes a new instance of the Color struct |
| new Color(float red, float green, float blue) | Initializes a new instance of the Color struct using float values |
| new Color(float red, float green, float blue, float alpha) | Initializes a new instance of the Color struct using float values with alpha transparency |
| new Color(int red, int green, int blue) | Initializes a new instance of the Color struct using int values |
| new Color(int red, int green, int blue, int alpha) | Initializes a new instance of the Color struct using int values with alpha transparency |
| new Color(byte red, byte green, byte blue) | Initializes a new instance of the Color struct using byte values |
| new Color(byte red, byte green, byte blue, byte alpha) | Initializes a new instance of the Color struct using byte values with alpha transparency |

## Methods and Properties

| Name / Option | Description |
| --- | --- |
| R | The red component of the color |
| G | The green component of the color |
| B | The blue component of the color |
| A | The alpha component of the color |
| ToColor3() | Converts the color into a [three component](sharpdx_color3.md) color |
| ToColor4() | Converts the color into a [four component](sharpdx_color4.md) color |

| Color Constant / Option | Description |
| --- | --- |
| SharpDX.Color.Transparent | Transparent color |
| SharpDX.Color.AntiqueWhite | AntiqueWhite color |
| SharpDX.Color.Aquamarine | Aquamarine color |
| SharpDX.Color.Beige | Beige color |
| SharpDX.Color.Black | Black color |
| SharpDX.Color.Blue | Blue color |
| SharpDX.Color.Brown | Brown color |
| SharpDX.Color.CadetBlue | CadetBlue color |
| SharpDX.Color.Chocolate | Chocolate color |
| SharpDX.Color.CornflowerBlue | CornflowerBlue color |
| SharpDX.Color.Crimson | Crimson color |
| SharpDX.Color.DarkBlue | DarkBlue color |
| SharpDX.Color.DarkGoldenrod | DarkGoldenrod color |
| SharpDX.Color.DarkGreen | DarkGreen color |
| SharpDX.Color.DarkMagenta | DarkMagenta color |
| SharpDX.Color.DarkOrange | DarkOrange color |
| SharpDX.Color.DarkRed | DarkRed color |
| SharpDX.Color.DarkSeaGreen | DarkSeaGreen color |
| SharpDX.Color.DarkSlateGray | DarkSlateGray color |
| SharpDX.Color.DarkViolet | DarkViolet color |
| SharpDX.Color.DeepSkyBlue | DeepSkyBlue color |
| SharpDX.Color.DodgerBlue | DodgerBlue color |
| SharpDX.Color.FloralWhite | FloralWhite color |
| SharpDX.Color.Fuchsia | Fuchsia color |
| SharpDX.Color.GhostWhite | GhostWhite color |
| SharpDX.Color.Goldenrod | Goldenrod color |
| SharpDX.Color.Green | Green color |
| SharpDX.Color.Honeydew | Honeydew color |
| SharpDX.Color.IndianRed | IndianRed color |
| SharpDX.Color.Ivory | Ivory color |
| SharpDX.Color.Lavender | Lavender color |
| SharpDX.Color.LawnGreen | LawnGreen color |
| SharpDX.Color.LightBlue | LightBlue color |
| SharpDX.Color.LightCyan | LightCyan color |
| SharpDX.Color.LightGray | LightGray color |
| SharpDX.Color.LightPink | LightPink color |
| SharpDX.Color.LightSeaGreen | LightSeaGreen color |
| SharpDX.Color.LightSlateGray | LightSlateGray color |
| SharpDX.Color.LightYellow | LightYellow color |
| SharpDX.Color.LimeGreen | LimeGreen color |
| SharpDX.Color.Magenta | Magenta color |
| SharpDX.Color.MediumAquamarine | MediumAquamarine color |
| SharpDX.Color.MediumOrchid | MediumOrchid color |
| SharpDX.Color.MediumSeaGreen | MediumSeaGreen color |
| SharpDX.Color.MediumSpringGreen | MediumSpringGreen color |
| SharpDX.Color.MediumVioletRed | MediumVioletRed color |
| SharpDX.Color.MintCream | MintCream color |
| SharpDX.Color.Moccasin | Moccasin color |
| SharpDX.Color.Navy | Navy color |
| SharpDX.Color.Olive | Olive color |
| SharpDX.Color.Orange | Orange color |
| SharpDX.Color.Orchid | Orchid color |
| SharpDX.Color.PaleGreen | PaleGreen color |
| SharpDX.Color.PaleVioletRed | PaleVioletRed color |
| SharpDX.Color.PeachPuff | PeachPuff color |
| SharpDX.Color.Pink | Pink color |
| SharpDX.Color.PowderBlue | PowderBlue color |
| SharpDX.Color.Red | Red color |
| SharpDX.Color.RoyalBlue | RoyalBlue color |
| SharpDX.Color.Salmon | Salmon color |
| SharpDX.Color.SeaGreen | SeaGreen color |
| SharpDX.Color.Sienna | Sienna color |
| SharpDX.Color.SkyBlue | SkyBlue color |
| SharpDX.Color.SlateGray | SlateGray color |
| SharpDX.Color.SpringGreen | SpringGreen color |
| SharpDX.Color.Tan | Tan color |
| SharpDX.Color.Thistle | Thistle color |
| SharpDX.Color.Turquoise | Turquoise color |
| SharpDX.Color.Wheat | Wheat color |
| SharpDX.Color.WhiteSmoke | WhiteSmoke color |
| SharpDX.Color.YellowGreen | YellowGreen color |