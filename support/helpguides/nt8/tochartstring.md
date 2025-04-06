



ToChartString()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](tochartstring.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [Bars](bars.htm) >  ToChartString() | [Previous page](tickcount.htm) [Return to chapter overview](bars.htm) [Next page](chart.htm) |

Definition
----------

Returns the bars series as a formatted string, including the [Instrument.FullName](instrument_fullname.htm), [BarsPeriod](barsperiod.htm) Value, and BarsPeriodType name.

 

|  |
| --- |
| Note:  To obtain a return value which matches the user configured [ChartBars Label property](chartbars_properties.htm), please see the [ChartBars.ToChartString()](chartbars_tochartstring().htm) method |

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