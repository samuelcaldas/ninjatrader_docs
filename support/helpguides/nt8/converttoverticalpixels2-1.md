
NinjaScript > Language Reference > Common > Charts > ChartingExtensions > ConvertToVerticalPixels

ConvertToVerticalPixels
| << [Click to Display Table of Contents](converttoverticalpixels2.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Charts](chart-1.md) > [ChartingExtensions](chartingextensions-1.md) > ConvertToVerticalPixels | [Previous page](converttohorizontalpixels-1.md) [Return to chapter overview](chartingextensions-1.md) [Next page](chartpanel-1.md) |
| --- | --- |
## Definition
Converts a y-axis pixel coordinate from application pixels to device pixels.
## 
| Note:  For more information concerning the differences between application pixels and device pixels, please see the [Working with Pixel Coordinates](working_with_pixel_coordinates-1.md) educational resource. |
| --- |

## 
## 
## Method Return Value
An int representing a y-coordinate value in terms of device pixels
## 
## Syntax
ChartingExtensions.ConvertToVerticalPixels(this double x, PresentationSource target)  

<double>.ConvertToVerticalPixels(PresentationSource target)
 
| x | The vertical double coordinates in application pixels to convert |
| --- | --- |
| target | The [PresenationSource](https://msdn.microsoft.com/en-us/library/system.windows.presentationsource(v=vs.110).aspx) representing the display surface used for the conversion   Note:  For Charts, see [ChartControl.PresentationSource](presentationsource-1.md) |

## 
## 
## Example
| ns |
| --- |
| int devicePixelY;   protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    // Obtain the device-pixel coordinate corresponding to an application-pixel Y value of 500    devicePixelY = ChartingExtensions.ConvertToVerticalPixels(500, ChartControl.PresentationSource); } |
