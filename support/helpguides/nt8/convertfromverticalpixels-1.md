
NinjaScript > Language Reference > Common > Charts > ChartingExtensions > ConvertFromVerticalPixels
ConvertFromVerticalPixels
| << [Click to Display Table of Contents](convertfromverticalpixels.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Charts](chart-1.md) > [ChartingExtensions](chartingextensions-1.md) > ConvertFromVerticalPixels | [Previous page](convertfromhorizontalpixels-1.md) [Return to chapter overview](chartingextensions-1.md) [Next page](converttohorizontalpixels-1.md) |
| --- | --- |
## Definition
Converts a y-axis pixel coordinate from device pixels to application pixels.
## 
| Note:  For more information concerning the differences between application pixels and device pixels, please see the [Working with Pixel Coordinates](working_with_pixel_coordinates-1.md) educational resource. |
| --- |
## 
## 
## Method Return Value
A double representing a y-coordinate value in terms of application pixels
## 
## Syntax
ChartingExtensions.ConvertFromVerticalPixels(this int x, PresentationSource target)  

<int>.ConvertFromVerticalPixels(PresentationSource target)
 
| x | The vertical int coordinates in device pixels to convert |
| --- | --- |
| target | The [PresenationSource](https://msdn.microsoft.com/en-us/library/system.windows.presentationsource(v=vs.110).aspx) representing the display surface used for the conversion   Note:  For Charts, see [ChartControl.PresentationSource](presentationsource-1.md) |
## 
## 
## Example
| ns |
| --- |
| int applicationPixelY;   protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    // Obtain the application-pixel coordinate corresponding to a device-pixel Y value of 500    applicationPixelY = ChartingExtensions.ConvertFromVerticalPixels(500, ChartControl.PresentationSource); } |

