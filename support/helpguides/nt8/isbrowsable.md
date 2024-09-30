
NinjaScript \> Language Reference \> Drawing Tool \> ChartAnchor \> IsBrowsable
IsBrowsable
| \<\< [Click to Display Table of Contents](isbrowsable.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Drawing Tool](drawing_tools.md) \> [ChartAnchor](chartanchor.md) \> IsBrowsable | [Previous page](getpoint.md) [Return to chapter overview](chartanchor.md) [Next page](isediting.md) |
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
