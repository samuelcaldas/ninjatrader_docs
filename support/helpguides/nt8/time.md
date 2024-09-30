
NinjaScript \> Language Reference \> Drawing Tool \> ChartAnchor \> Time
Time
| \<\< [Click to Display Table of Contents](time.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Drawing Tool](drawing_tools.md) \> [ChartAnchor](chartanchor.md) \> Time | [Previous page](barindex.md) [Return to chapter overview](chartanchor.md) [Next page](updatefrompoint.md) |
| --- | --- |
## Definition
Determines date/time value the chart anchor is drawn.
 
## Property Value
An DateTime value representing a time value
 
## Syntax
\<ChartAnchor\>.Time
 
## Examples
| ns |
| --- |
| public override void OnMouseDown(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, Point point) { Print(MyAnchor.Time); // prints the X axis datetime of the chart anchor  // 8/26/2014 6:55:00 PM } |
