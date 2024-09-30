
NinjaScript \> Language Reference \> Common \> Bars \> ToChartString()
ToChartString()

| \<\< [Click to Display Table of Contents](tochartstring.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Bars](bars-1.md) \> ToChartString() | [Previous page](tickcount-1.md) [Return to chapter overview](bars-1.md) [Next page](chart-1.md) |
| --- | --- |

## Definition
Returns the bars series as a formatted string, including the [Instrument.FullName](instrument_fullname-1.md), [BarsPeriod](barsperiod-1.md) Value, and BarsPeriodType name. 
 
| Note:  To obtain a return value which matches the user configured [ChartBars Label property](chartbars_properties-1.md), please see the [ChartBars.ToChartString()](chartbars_tochartstring()-1.md) method |
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

