﻿
NinjaScript > Language Reference > Indicator > IsChartOnly
IsChartOnly
| << [Click to Display Table of Contents](ischartonly.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Indicator](indicator.md) > IsChartOnly | [Previous page](indicatorbaseconverter.md) [Return to chapter overview](indicator.md) [Next page](issuspendedwhileinactive.md) |
| --- | --- |
## Definition
If true, any indicator will be only available for charting usage - indicators with this property enabled would for example not be expected to show if called in a SuperDOM or MarketAnalyzer window.
 
## Property Value
This property returns true if the indicator can only be used on a chart; otherwise, false. Default set to false.
 
| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults or State.Configure |
| --- |

## Syntax
IsChartOnly
 
## Examples
| ns |
| --- |
| protected override void OnStateChange() {      if (State == State.SetDefaults)      {          IsChartOnly = true; // Allow the indicator to work in charting environment only            } } |
