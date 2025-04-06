



ToChartString()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\tochartstring.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Bars](bars-1.htm) >  ToChartString() | [Previous page](tickcount-1.htm) [Return to chapter overview](bars-1.htm) [Next page](chart-1.htm) |

Definition
----------

Returns the bars series as a formatted string, including the [Instrument.FullName](instrument_fullname-1.htm), [BarsPeriod](barsperiod-1.htm) Value, and BarsPeriodType name.

 

|  |
| --- |
| Note:  To obtain a return value which matches the user configured [ChartBars Label property](chartbars_properties-1.htm), please see the [ChartBars.ToChartString()](chartbars_tochartstring()-1.htm) method |

Syntax
------

Bars.ToChartString()

Return Value
------------

A string value that represents the bars series

Parameters
----------

This method does not accept any parameters

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {     // print the chart string on start up     if(CurrentBar == 0)       Print(Bars.ToChartString()); // ES 09-15 (60 Minute)        } |