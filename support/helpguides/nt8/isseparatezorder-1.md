


NinjaScript \> Language Reference \> Common \> Charts \> IsSeparateZOrder






















IsSeparateZOrder







| \<\< [Click to Display Table of Contents](isseparatezorder.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Charts](chart-1.md) \> IsSeparateZOrder | [Previous page](isoverlay-1.md) [Return to chapter overview](chart-1.md) [Next page](scalejustification-1.md) |
| --- | --- |











## Definition


Determines the [ZOrder](chart_zorder-1.md) of the drawing object will be different than the NinjaScript object that drew it.  When false the drawing object will share the same ZOrder.


 


## Property Value


This property returns true if the object is drawn on a separate ZOrder; otherwise, false. Default set to false.


 


## Syntax


IsSeparateZOrder


 


 


## Example




| ns |
| --- |
| protected override void OnBarUpdate() {    // Instantiate a Dot object    Dot myDot \= Draw.Dot(this, "NewDot", true, 5, High\[5], Brushes.Black);      // Set the Dot object to use a separate Z\-Order than the indicator that created it    myDot.IsSeparateZOrder \= true; } |









