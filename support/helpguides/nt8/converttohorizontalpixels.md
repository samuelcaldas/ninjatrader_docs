


NinjaScript \> Language Reference \> Common \> Charts \> ChartingExtensions \> ConvertToHorizontalPixels






















ConvertToHorizontalPixels







| \<\< [Click to Display Table of Contents](converttohorizontalpixels.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Charts](chart.md) \> [ChartingExtensions](chartingextensions.md) \> ConvertToHorizontalPixels | [Previous page](convertfromverticalpixels.md) [Return to chapter overview](chartingextensions.md) [Next page](converttoverticalpixels2.md) |
| --- | --- |











## Definition


Converts an x\-axis pixel coordinate from application pixels to device pixels.


## 




| Note:  For more information concerning the differences between application pixels and device pixels, please see the [Working with Pixel Coordinates](working_with_pixel_coordinates.md) educational resource. |
| --- |



## 


## 


## Method Return Value


An int representing an x\-coordinate value in terms of device pixels


## 


## Syntax


ChartingExtensions.ConvertToHorizontalPixels(this double x, PresentationSource target)  

\<double\>.ConvertToHorizontalPixels(PresentationSource target)


 




| x | The horizontal double coordinates in application pixels to convert |
| --- | --- |
| target | The [PresenationSource](https://msdn.microsoft.com/en-us/library/system.windows.presentationsource(v=vs.110).aspx) representing the display surface used for the conversion   Note:  For Charts, see [ChartControl.PresentationSource](presentationsource.md) |



## 


## Example




| ns |
| --- |
| int devicePixelX;   protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    // Obtain the device\-pixel coordinate corresponding to an application pixel X\-value of 500    devicePixelX \= ChartingExtensions.ConvertToHorizontalPixels(500, ChartControl.PresentationSource); } |









