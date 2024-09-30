
FillRectangle()
FillRectangle()
| \<\< [Click to Display Table of Contents](fillrectangle.md) \>\> **Navigation:**   »No topics above this level«   FillRectangle() | [Return to chapter overview](sharpdx_directwrite_textlayout-1.md) |
| --- | --- |
## Definition
Draws a rectangle between two points.
 
## Syntax
## RenderTarget.FillRectangle(RectangleF rect, Brush brush)
## 
## Parameters
| rect | A RectangleF representing the rectangle to be drawn |
| --- | --- |
| brush | A Brush representing the brush to draw with |
 
## 
## 
## Examples
| ns | |
| --- | --- |
|  | RectangleF rect \= new RectangleF();   rect.X      \= rectX; rect.Y      \= rectY; rect.Width  \= rectWidth; rect.Height \= rectHeight;   RenderTarget.FillRectangle(rect, brush); |

