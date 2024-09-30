
NinjaScript > Language Reference > Indicator > PaintPriceMarkers
PaintPriceMarkers
| << [Click to Display Table of Contents](paintpricemarkers.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Indicator](indicator-1.md) > PaintPriceMarkers | [Previous page](issuspendedwhileinactive-1.md) [Return to chapter overview](indicator-1.md) [Next page](showtransparentplotsindatabox-1.md) |
| --- | --- |
## Definition
If true, any indicator plot values display price markers in the y-axis.
 
## Property Value
This property returns true if the indicator plot values display in the y-axis; otherwise, false. Default set to true.
 
| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange-1.md) method during State.SetDefaults or State.Configure |
| --- |

## Syntax
PaintPriceMarkers
 
## Examples
| ns |
| --- |
| protected override void OnStateChange() {      if (State == State.SetDefaults)      {          PaintPriceMarkers = true; // Indicator plots values display in the y-axis               AddPlot(Brushes.Orange, "SMA");      } } |
