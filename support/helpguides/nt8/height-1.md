


NinjaScript \> Language Reference \> Common \> Charts \> ChartScale \> Height






















Height







| \<\< [Click to Display Table of Contents](height.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Charts](chart-1.md) \> [ChartScale](chartscale-1.md) \> Height | [Previous page](getybyvaluewpf-1.md) [Return to chapter overview](chartscale-1.md) [Next page](chartscale_isvisible-1.md) |
| --- | --- |











## Definition


Indicates the overall distance (from top to bottom) of the chart scale.


 




| Note: Height does not return its value in terms of device pixels. However, using Height.ConvertToVerticalPixels or Height.ConvertToHorizontalPixels will convert the Height value to device pixels. Alternatively, RenderTarget.PixelSize.Height or ChartPanel.H will also provide the height in terms of device pixels. |
| --- |



## 


## 


## Property Value


A double value representing the height of the chart scale.


 


## Syntax


\<chartScale\>.Height


 


## Examples




| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    // the height of the entire chart scale    double   height       \= chartScale.Height;    Print("the height of the chart scale is: " \+ height);   } |



## 


## 


## In the image below, the entire of height of the chart scale is represented by the blue line which is calculated at 300 pixels.


 


![Height](height.png)








