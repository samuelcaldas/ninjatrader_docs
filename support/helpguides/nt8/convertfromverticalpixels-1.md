



ConvertFromVerticalPixels

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\convertfromverticalpixels.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Charts](chart-1.htm) > [ChartingExtensions](chartingextensions-1.htm) >  ConvertFromVerticalPixels | [Previous page](convertfromhorizontalpixels-1.htm) [Return to chapter overview](chartingextensions-1.htm) [Next page](converttohorizontalpixels-1.htm) |

Definition
----------

Converts a y-axis pixel coordinate from device pixels to application pixels.

|  |
| --- |
| Note:  For more information concerning the differences between application pixels and device pixels, please see the [Working with Pixel Coordinates](working_with_pixel_coordinates-1.htm) educational resource. |

Method Return Value
-------------------

A double representing a y-coordinate value in terms of application pixels

Syntax
------

ChartingExtensions.ConvertFromVerticalPixels(this int x, PresentationSource target)  
<int>.ConvertFromVerticalPixels(PresentationSource target)

 

|  |  |
| --- | --- |
| x | The vertical int coordinates in device pixels to convert |
| target | The [PresenationSource](https://msdn.microsoft.com/en-us/library/system.windows.presentationsource(v=vs.110).aspx) representing the display surface used for the conversion    Note:  For Charts, see [ChartControl.PresentationSource](presentationsource-1.htm) |

Example
-------

| ns |
| --- |
| int applicationPixelY;     protected override void OnRender(ChartControl chartControl, ChartScale chartScale)  {     // Obtain the application-pixel coordinate corresponding to a device-pixel Y value of 500     applicationPixelY = ChartingExtensions.ConvertFromVerticalPixels(500, ChartControl.PresentationSource);  } |