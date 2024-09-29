


NinjaScript \> Language Reference \> Indicator \> DrawOnPricePanel






















DrawOnPricePanel







| \<\< [Click to Display Table of Contents](drawonpricepanel.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Indicator](indicator-1.md) \> DrawOnPricePanel | [Previous page](drawhorizontalgridlines-1.md) [Return to chapter overview](indicator-1.md) [Next page](drawverticalgridlines-1.md) |
| --- | --- |











## Definition


Determines the chart panel the draw objects renders


 


## Property Value


This property returns true if the indicator paints draw objects on the price panel; otherwise when false, draw objects are painted on the actual indicator panel itself. Default set to true.


 




| Warning:  This property should ONLY be set from the [OnStateChange()](onstatechange-1.md) method during State.SetDefaults. Dynamically using DrawOnPricePanel in an indicator outside of State.SetDefaults may show issues when working with that indicator through a hosting strategy via [AddChartIndicator()](addchartindicator-1.md). |
| --- |



 


## Syntax


DrawOnPricePanel


 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {           DrawOnPricePanel \= false; // Draw objects now paint on the indicator panel itself               AddPlot(Brushes.Orange, "SMA");      } } |









