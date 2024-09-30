
NinjaScript \> Language Reference \> Indicator \> PaintPriceMarkers
PaintPriceMarkers
| \<\< [Click to Display Table of Contents](paintpricemarkers.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Indicator](indicator.md) \> PaintPriceMarkers | [Previous page](issuspendedwhileinactive.md) [Return to chapter overview](indicator.md) [Next page](showtransparentplotsindatabox.md) |
| --- | --- |
## Definition
If true, any indicator plot values display price markers in the y\-axis.
 
## Property Value
This property returns true if the indicator plot values display in the y\-axis; otherwise, false. Default set to true.
 
| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults or State.Configure |
| --- |

## Syntax
PaintPriceMarkers
 
## Examples
| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          PaintPriceMarkers \= true; // Indicator plots values display in the y\-axis               AddPlot(Brushes.Orange, "SMA");      } } |
