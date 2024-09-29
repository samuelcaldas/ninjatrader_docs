


NinjaScript \> Language Reference \> Drawing Tool \> ChartAnchor \> IsBrowsable






















IsBrowsable







| \<\< [Click to Display Table of Contents](isbrowsable.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Drawing Tool](drawing_tools-1.md) \> [ChartAnchor](chartanchor-1.md) \> IsBrowsable | [Previous page](getpoint-1.md) [Return to chapter overview](chartanchor-1.md) [Next page](isediting-1.md) |
| --- | --- |











## Definition


Determines if the anchor are visible on the UI.  When set to true, the anchors Y and X values can be viewed from the Drawing Objects properties.


 


## Property Value


A bool value which when true will display the anchor data values from the drawing object properties; otherwise false.  Default value is true.


 


## Syntax


# \<ChartAnchor\>.IsBrowsable


## 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          MyAnchor \= new ChartAnchor(); MyAnchor.IsBrowsable \= true;      }      else if (State \=\= State.Configure)      {        } } |









