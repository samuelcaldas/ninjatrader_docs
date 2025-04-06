



ConvertFromHorizontalPixels

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](convertfromhorizontalpixels.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [Charts](chart.htm) > [ChartingExtensions](chartingextensions.htm) >  ConvertFromHorizontalPixels | [Previous page](chartingextensions.htm) [Return to chapter overview](chartingextensions.htm) [Next page](convertfromverticalpixels.htm) |

Definition
----------

Converts an x-axis pixel coordinate from device pixels to application pixels.

|  |
| --- |
| Note:  For more information concerning the differences between application pixels and device pixels, please see the [Working with Pixel Coordinates](working_with_pixel_coordinates.htm) educational resource. |

Method Return Value
-------------------

A double representing an x-coordinate value in terms of application pixels

Syntax
------

ChartingExtensions.ConvertFromHorizontalPixels(this int x, PresentationSource target)  
<int>.ConvertFromHorizontalPixels(PresentationSource target)

 

Parameters
----------

|  |  |
| --- | --- |
| x | The horizontal int coordinates in device pixels to convert |
| target | The [PresenationSource](https://msdn.microsoft.com/en-us/library/system.windows.presentationsource(v=vs.110).aspx) representing the display surface used for the conversion    Note:  For Charts, see [ChartControl.PresentationSource](presentationsource.htm) |

Example
-------

| ns |
| --- |
| int applicationPixelX;     protected override void OnRender(ChartControl chartControl, ChartScale chartScale)  {     // Obtain the application-pixel coordinate corresponding to a device-pixel X value of 500     applicationPixelX = ChartingExtensions.ConvertFromHorizontalPixels(500, ChartControl.PresentationSource);  } |