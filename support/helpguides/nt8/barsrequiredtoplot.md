


NinjaScript \> Language Reference \> Indicator \> BarsRequiredToPlot






















BarsRequiredToPlot







| \<\< [Click to Display Table of Contents](barsrequiredtoplot.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Indicator](indicator.md) \> BarsRequiredToPlot | [Previous page](plots.md) [Return to chapter overview](indicator.md) [Next page](displayindatabox.md) |
| --- | --- |











## Definition


The number of bars on a chart required before the script plots. By default, the value is 20 bars.


## 




| Note:  This property is NOT the same as a minimum number of bars required to calculate the script values.  OnBarUpdate will always start calculating for the first bar on the chart (CurrentBar 0\) |
| --- |



 


 


## Property Value


An int value that represents the minimum number of bars required.


 


## Syntax


BarsRequiredToPlot


## 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {           BarsRequiredToPlot \= 10; // Do not plot until the 11th bar on the chart           AddPlot(Brushes.Orange, "SMA");      }      } |









