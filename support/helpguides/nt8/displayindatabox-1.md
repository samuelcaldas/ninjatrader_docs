


NinjaScript \> Language Reference \> Indicator \> DisplayInDataBox






















DisplayInDataBox







| \<\< [Click to Display Table of Contents](displayindatabox.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Indicator](indicator-1.md) \> DisplayInDataBox | [Previous page](barsrequiredtoplot-1.md) [Return to chapter overview](indicator-1.md) [Next page](drawhorizontalgridlines-1.md) |
| --- | --- |











## Definition


Determines if plot(s) display in the chart data box.


 


## Property Value


This property returns true if the indicator plot(s) values display in the chart data box; otherwise, false. Default set to true.


 




| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange-1.md) method during State.SetDefaults or State.Configure |
| --- |



 


 


## Syntax


DisplayInDataBox


## 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          DisplayInDataBox \= false;             AddPlot(Brushes.Orange, "SMA");      } } |









