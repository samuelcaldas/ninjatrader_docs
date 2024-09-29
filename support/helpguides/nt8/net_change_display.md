


NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Net Change Display






















Net Change Display







| \<\< [Click to Display Table of Contents](net_change_display.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [System Indicator Methods](indicators.md) \> Net Change Display | [Previous page](moving_average_ribbon.md) [Return to chapter overview](indicators.md) [Next page](n_bars_down.md) |
| --- | --- |











## Description


Displays net change on the chart.


 


## Syntax


NetChangeDisplay(PerformanceUnit, NetChangePosition location)


NetChangeDisplay(ISeries\<double\> input, PerformanceUnit, NetChangePosition location)


 


## Return Value


double


 


## Parameters




| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| --- | --- |
| PerformanceUnit | Format of the calculation of net change |
| NetChangePosition | Location to display net change on the chart |



 


## 


## Examples




| ns |
| --- |
| // Runs on realtime since there is no historical data for this indicator if (State \=\= State.Historical)  return;  else if (State \>\= State.Realtime) { // Prints the current tick value of the net change var ncd \= NetChangeDisplay(PerformanceUnit.Ticks, NetChangePosition.BottomRight); Print("The current Net Change value is " \+ ncd.NetChange); } |



 


 




| Note: This indicator only plots real\-time. Historical values will print as 0\. |
| --- |



## 








