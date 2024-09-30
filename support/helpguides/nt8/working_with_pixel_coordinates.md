
NinjaScript \> Educational Resources \> Working with Pixel Coordinates
Working with Pixel Coordinates

| \<\< [Click to Display Table of Contents](working_with_pixel_coordinates.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Educational Resources](educational_resources.md) \> Working with Pixel Coordinates | [Previous page](working_with_chart_object_coordinates.md) [Return to chapter overview](educational_resources.md) [Next page](working_with_price_series.md) |
| --- | --- |

## Understanding Device Pixels vs. Application Pixels (WPF)
When working with pixel coordinates (for example, when using SharpDX drawing methods for custom drawing), it is important to note if the coordinates specified in method arguments refer to application pixels (i.e., WPF coordinates), or the larger concept of [Device Independent Pixels (DIP)](https://msdn.microsoft.com/en-us/library/windows/desktop/ff684173(v=vs.85).aspx).
 
The physical size of an application\-specific pixel can vary based on PC hardware and operating\-system settings, which introduces a challenge for developers using pixel coordinates for processes such as custom drawing on a chart canvas. By specifying the number of pixels when defining a coordinate, the object placed at that coordinate could render in a very different position depending on the users display settings. Device Independent Pixels provide a way to measure or quantify pixel coordinates without being impacted by different sizes of application pixels. Specifying Device Independent Pixels can ensure that objects render in the intended location or position, regardless of these unpredictable factors.
 
## Converting to Device Pixels
NinjaScript provides helper methods to convert from application pixels to device pixels (or vice versa) within the [ChartingExtensions](chartingextensions.md) class. Since some NinjaScript methods and properties return application pixels where device pixels are needed, using these helper methods can provide great flexibility by allowing you to define physical application pixels, then converting them to device independent pixels before passing them to a method. Using this process, the application pixel values used will result in objects being rendered exactly where intended.
 
## Example
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    // get the point the user clicked, (which returns application pixel)    Point clickPoint \= chartControl.MouseDownPoint;      // Convert the clickPoint X and Y coordinates to device independent pixels (DIP)    // This will ensure that the MouseDownPoint will work across all screen displays    clickPoint.X \= ChartingExtensions.ConvertToHorizontalPixels(clickPoint.X, chartControl.PresentationSource);    clickPoint.Y \= ChartingExtensions.ConvertToVerticalPixels(clickPoint.Y, chartControl.PresentationSource);      // set the location (vector) from the user clickPoint    SharpDX.Vector2 vectorForEllipse \= clickPoint.ToVector2();        // create the shape (ellipse), and color (brush) for our object to render    SharpDX.Direct2D1\.Ellipse ellipse \= new SharpDX.Direct2D1\.Ellipse(vectorForEllipse, 10f, 10f);    SharpDX.Direct2D1\.Brush ellipseBrushDX \= Brushes.Blue.ToDxBrush(RenderTarget);      // finally, render a ellipse at the exact point the user clicked    RenderTarget.FillEllipse(ellipse, ellipseBrushDX); } |

