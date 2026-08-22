# FillRectangle()

Definition 
## Draws a rectangle between two points.

## Syntax

## RenderTarget.FillRectangle(RectangleF rect, Brush brush)

## Parameters

| Name / Option | Description |
| --- | --- |
| rect | A RectangleF representing the rectangle to be drawn |
| brush | A Brush representing the brush to draw with |

## Examples

```csharp
RectangleF rect = new RectangleF();
rect.X
= rectX;
rect.Y
= rectY;
rect.Width
= rectWidth;
rect.Height = rectHeight;
RenderTarget.FillRectangle(rect, brush);
```
