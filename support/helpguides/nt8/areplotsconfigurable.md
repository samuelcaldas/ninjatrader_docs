
NinjaScript \> Language Reference \> Indicator \> AddPlot() \> ArePlotsConfigurable
ArePlotsConfigurable
| \<\< [Click to Display Table of Contents](areplotsconfigurable.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Indicator](indicator.md) \> [AddPlot()](addplot.md) \> ArePlotsConfigurable | [Previous page](addplot.md) [Return to chapter overview](addplot.md) [Next page](displacement.md) |
| --- | --- |
## Definition
Determines if the plot(s) used in an indicator are configurable within the indicator dialog window.
 
## Property Value
A bool which returns true if any indicator plot(s) are configurable; otherwise, false. Default set to true.
 
## Syntax
ArePlotsConfigurable
 
## Examples
| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          AddPlot(Brushes.Orange, "SMA");          ArePlotsConfigurable \= false; // Plots are not configurable in the indicator dialog      } } |

