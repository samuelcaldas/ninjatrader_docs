
NinjaScript > Language Reference > Common > Charts > ChartingExtensions > ConvertToVerticalPixels

ConvertToVerticalPixels
| << [Click to Display Table of Contents](converttoverticalpixels2.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Charts](chart.md) > [ChartingExtensions](chartingextensions.md) > ConvertToVerticalPixels | [Previous page](converttohorizontalpixels.md) [Return to chapter overview](chartingextensions.md) [Next page](chartpanel.md) |
| --- | --- |
## Definition
Converts a y-axis pixel coordinate from application pixels to device pixels.
## 
| Note:  For more information concerning the differences between application pixels and device pixels, please see the [Working with Pixel Coordinates](working_with_pixel_coordinates.md) educational resource. |
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
| target | The [PresenationSource](https://msdn.microsoft.com/en-us/library/system.windows.presentationsource(v=vs.110).aspx) representing the display surface used for the conversion   Note:  For Charts, see [ChartControl.PresentationSource](presentationsource.md) |

## 
## 
## Example
| ns |
| --- |
| int devicePixelY;   protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    // Obtain the device-pixel coordinate corresponding to an application-pixel Y value of 500    devicePixelY = ChartingExtensions.ConvertToVerticalPixels(500, ChartControl.PresentationSource); } |
