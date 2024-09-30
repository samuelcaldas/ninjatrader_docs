
NinjaScript \> Language Reference \> Common \> Charts \> IsOverlay

IsOverlay

| \<\< [Click to Display Table of Contents](isoverlay.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Charts](chart-1.md) \> IsOverlay | [Previous page](isautoscale-1.md) [Return to chapter overview](chart-1.md) [Next page](isseparatezorder-1.md) |
| --- | --- |
## Definition
Determines if indicator plot(s) are drawn on the chart panel over top of price.  Setting this value to true will also allow an Indicator to be used as a [SuperDOM Indicator](working_with_indicators_superdom-1.md).
 
## Property Value
This property returns true if any indicator plot(s) are drawn on the chart panel; otherwise, false. Default set to false.
 

| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange-1.md) method during State.SetDefaults |
| --- |
 
## Syntax
IsOverlay
 
## Examples

| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          IsOverlay \= true; // Indicator plots are drawn on the chart panel on top of price              AddPlot(Brushes.Orange, "SMA");      } } |
