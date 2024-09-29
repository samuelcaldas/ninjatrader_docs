


NinjaScript \> Language Reference \> Common \> Charts \> ChartControl \> PresentationSource






















PresentationSource







| \<\< [Click to Display Table of Contents](presentationsource.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Charts](chart-1.md) \> [ChartControl](chartcontrol-1.md) \> PresentationSource | [Previous page](mousedownpoint-1.md) [Return to chapter overview](chartcontrol-1.md) [Next page](chartcontrol_properties-1.md) |
| --- | --- |











## Definition


Provides a reference to the base window in which the chart is rendered. PresentationSource can be used when converting application pixels to/from device pixels via the helper methods in the [ChartingExtensions](chartingextensions-1.md) class.


## 


## Property Value


A [PresentationSource](https://msdn.microsoft.com/en-us/library/system.windows.presentationsource(v=vs.110).aspx) object representing the base window in which the chart is rendered.


## 


## Syntax


ChartControl.PresentationSource


## 


## Example




| ns |
| --- |
| int devicePixelX;   protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    // Obtain the device\-pixel coordinate corresponding to an application\-pixel X value of 500    devicePixelX \= ChartingExtensions.ConvertToHorizontalPixels(500, ChartControl.PresentationSource); } |









