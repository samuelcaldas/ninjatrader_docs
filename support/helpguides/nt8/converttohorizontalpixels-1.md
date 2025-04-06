



ConvertToHorizontalPixels

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\converttohorizontalpixels.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Charts](chart-1.htm) > [ChartingExtensions](chartingextensions-1.htm) >  ConvertToHorizontalPixels | [Previous page](convertfromverticalpixels-1.htm) [Return to chapter overview](chartingextensions-1.htm) [Next page](converttoverticalpixels2-1.htm) |

Definition
----------

Converts an x-axis pixel coordinate from application pixels to device pixels.

|  |
| --- |
| Note:  For more information concerning the differences between application pixels and device pixels, please see the [Working with Pixel Coordinates](working_with_pixel_coordinates-1.htm) educational resource. |

Method Return Value
-------------------

An int representing an x-coordinate value in terms of device pixels

Syntax
------

ChartingExtensions.ConvertToHorizontalPixels(this double x, PresentationSource target)  
<double>.ConvertToHorizontalPixels(PresentationSource target)

 

|  |  |
| --- | --- |
| x | The horizontal double coordinates in application pixels to convert |
| target | The [PresenationSource](https://msdn.microsoft.com/en-us/library/system.windows.presentationsource(v=vs.110).aspx) representing the display surface used for the conversion    Note:  For Charts, see [ChartControl.PresentationSource](presentationsource-1.htm) |

Example
-------

| ns |
| --- |
| int devicePixelX;     protected override void OnRender(ChartControl chartControl, ChartScale chartScale)  {     // Obtain the device-pixel coordinate corresponding to an application pixel X-value of 500     devicePixelX = ChartingExtensions.ConvertToHorizontalPixels(500, ChartControl.PresentationSource);  } |