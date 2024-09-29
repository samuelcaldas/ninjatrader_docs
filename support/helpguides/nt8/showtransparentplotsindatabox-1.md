


NinjaScript \> Language Reference \> Indicator \> ShowTransparentPlotsInDataBox






















ShowTransparentPlotsInDataBox







| \<\< [Click to Display Table of Contents](showtransparentplotsindatabox.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Indicator](indicator-1.md) \> ShowTransparentPlotsInDataBox | [Previous page](paintpricemarkers-1.md) [Return to chapter overview](indicator-1.md) [Next page](market_analyzer_column-1.md) |
| --- | --- |











## Definition


Determines if plot(s) values which are set to a Transparent brush display in the chart data box.  The default behavior is to hide any plots which have been configured as a Transparent brush, however this behavior can be changed by setting ShowTransparentPlotsInDataBox to true on the indicator.


 


## Property Value


This property returns true if transparent indicator plot(s) values display in the chart data box; otherwise, false. Default set to false.


 




| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange-1.md) method during State.SetDefaults or State.Configure |
| --- |



 


 


## Syntax


ShowTransparentPlotsInDataBox


## 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          ShowTransparentPlotsInDataBox \= true;             AddPlot(Brushes.Transparent, "MyPlot");      } } |









