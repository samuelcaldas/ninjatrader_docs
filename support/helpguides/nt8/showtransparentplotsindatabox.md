


NinjaScript \> Language Reference \> Indicator \> ShowTransparentPlotsInDataBox






















ShowTransparentPlotsInDataBox







| \<\< [Click to Display Table of Contents](showtransparentplotsindatabox.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Indicator](indicator.md) \> ShowTransparentPlotsInDataBox | [Previous page](paintpricemarkers.md) [Return to chapter overview](indicator.md) [Next page](market_analyzer_column.md) |
| --- | --- |











## Definition


Determines if plot(s) values which are set to a Transparent brush display in the chart data box.  The default behavior is to hide any plots which have been configured as a Transparent brush, however this behavior can be changed by setting ShowTransparentPlotsInDataBox to true on the indicator.


 


## Property Value


This property returns true if transparent indicator plot(s) values display in the chart data box; otherwise, false. Default set to false.


 




| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults or State.Configure |
| --- |



 


 


## Syntax


ShowTransparentPlotsInDataBox


## 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          ShowTransparentPlotsInDataBox \= true;             AddPlot(Brushes.Transparent, "MyPlot");      } } |









