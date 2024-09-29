


NinjaScript \> Language Reference \> Indicator \> IsChartOnly






















IsChartOnly







| \<\< [Click to Display Table of Contents](ischartonly.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Indicator](indicator-1.md) \> IsChartOnly | [Previous page](indicatorbaseconverter-1.md) [Return to chapter overview](indicator-1.md) [Next page](issuspendedwhileinactive-1.md) |
| --- | --- |











## Definition


If true, any indicator will be only available for charting usage \- indicators with this property enabled would for example not be expected to show if called in a SuperDOM or MarketAnalyzer window.


 


## Property Value


This property returns true if the indicator can only be used on a chart; otherwise, false. Default set to false.


 




| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange-1.md) method during State.SetDefaults or State.Configure |
| --- |



 


 


## Syntax


IsChartOnly


 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          IsChartOnly \= true; // Allow the indicator to work in charting environment only            } } |









