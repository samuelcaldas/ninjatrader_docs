
NinjaScript > Language Reference > Indicator > DisplayInDataBox
DisplayInDataBox
| << [Click to Display Table of Contents](displayindatabox.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Indicator](indicator.md) > DisplayInDataBox | [Previous page](barsrequiredtoplot.md) [Return to chapter overview](indicator.md) [Next page](drawhorizontalgridlines.md) |
| --- | --- |
## Definition
Determines if plot(s) display in the chart data box.
 
## Property Value
This property returns true if the indicator plot(s) values display in the chart data box; otherwise, false. Default set to true.
 
| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults or State.Configure |
| --- |

## Syntax
DisplayInDataBox
## 
## Examples
| ns |
| --- |
| protected override void OnStateChange() {      if (State == State.SetDefaults)      {          DisplayInDataBox = false;             AddPlot(Brushes.Orange, "SMA");      } } |

