


NinjaScript \> Language Reference \> Common \> Bars \> ToChartString()






















ToChartString()







| \<\< [Click to Display Table of Contents](tochartstring.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Bars](bars.md) \> ToChartString() | [Previous page](tickcount.md) [Return to chapter overview](bars.md) [Next page](chart.md) |
| --- | --- |











## Definition


Returns the bars series as a formatted string, including the [Instrument.FullName](instrument_fullname.md), [BarsPeriod](barsperiod.md) Value, and BarsPeriodType name. 


 




| Note:  To obtain a return value which matches the user configured [ChartBars Label property](chartbars_properties.md), please see the [ChartBars.ToChartString()](chartbars_tochartstring().md) method |
| --- |



 


 


## Syntax


Bars.ToChartString()


 


## Return Value


A string value that represents the bars series


 


## Parameters


This method does not accept any parameters


## 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {    // print the chart string on start up    if(CurrentBar \=\= 0)      Print(Bars.ToChartString()); // ES 09\-15 (60 Minute)       } |









