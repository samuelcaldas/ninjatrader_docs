


NinjaScript \> Language Reference \> Common \> Charts \> ChartingExtensions \> ConvertFromHorizontalPixels






















ConvertFromHorizontalPixels







| \<\< [Click to Display Table of Contents](convertfromhorizontalpixels.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Charts](chart.md) \> [ChartingExtensions](chartingextensions.md) \> ConvertFromHorizontalPixels | [Previous page](chartingextensions.md) [Return to chapter overview](chartingextensions.md) [Next page](convertfromverticalpixels.md) |
| --- | --- |











## Definition


Converts an x\-axis pixel coordinate from device pixels to application pixels.


## 




| Note:  For more information concerning the differences between application pixels and device pixels, please see the [Working with Pixel Coordinates](working_with_pixel_coordinates.md) educational resource. |
| --- |



## 


## 


## Method Return Value


A double representing an x\-coordinate value in terms of application pixels


## 


## Syntax


ChartingExtensions.ConvertFromHorizontalPixels(this int x, PresentationSource target)  

\<int\>.ConvertFromHorizontalPixels(PresentationSource target)


 


## Parameters




| x | The horizontal int coordinates in device pixels to convert |
| --- | --- |
| target | The [PresenationSource](https://msdn.microsoft.com/en-us/library/system.windows.presentationsource(v=vs.110).aspx) representing the display surface used for the conversion   Note:  For Charts, see [ChartControl.PresentationSource](presentationsource.md) |



## 


## 


## Example




| ns |
| --- |
| int applicationPixelX;   protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    // Obtain the application\-pixel coordinate corresponding to a device\-pixel X value of 500    applicationPixelX \= ChartingExtensions.ConvertFromHorizontalPixels(500, ChartControl.PresentationSource); } |









