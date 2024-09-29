


NinjaScript \> Language Reference \> Indicator \> AddPlot() \> ArePlotsConfigurable






















ArePlotsConfigurable







| \<\< [Click to Display Table of Contents](areplotsconfigurable.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Indicator](indicator-1.md) \> [AddPlot()](addplot-1.md) \> ArePlotsConfigurable | [Previous page](addplot-1.md) [Return to chapter overview](addplot-1.md) [Next page](displacement-1.md) |
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









