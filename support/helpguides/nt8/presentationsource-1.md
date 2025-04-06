



PresentationSource

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\presentationsource.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Charts](chart-1.htm) > [ChartControl](chartcontrol-1.htm) >  PresentationSource | [Previous page](mousedownpoint-1.htm) [Return to chapter overview](chartcontrol-1.htm) [Next page](chartcontrol_properties-1.htm) |

Definition
----------

Provides a reference to the base window in which the chart is rendered. PresentationSource can be used when converting application pixels to/from device pixels via the helper methods in the [ChartingExtensions](chartingextensions-1.htm) class.

Property Value
--------------

A [PresentationSource](https://msdn.microsoft.com/en-us/library/system.windows.presentationsource(v=vs.110).aspx) object representing the base window in which the chart is rendered.

Syntax
------

ChartControl.PresentationSource

Example
-------

| ns |
| --- |
| int devicePixelX;     protected override void OnRender(ChartControl chartControl, ChartScale chartScale)  {     // Obtain the device-pixel coordinate corresponding to an application-pixel X value of 500     devicePixelX = ChartingExtensions.ConvertToHorizontalPixels(500, ChartControl.PresentationSource);  } |