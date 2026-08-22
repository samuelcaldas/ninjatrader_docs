# Commitment of Traders (COT)

﻿

    NinjaScript > Language Reference > Common > System Indicator Methods > Commitment Of Traders (COT)

Commitment Of Traders (COT)

## Description

The COT indicator plots weekly data from the Commitment Of Traders report, indicating holdings of different participants in the U.S. futures market.

 

[](../language_reference/calculate.md)

[](../ninjascript/intelliprompt.md)

> **Note:** Notes:  
 
1. Since the underlying COT reports are a weekly figure updated every Friday, it would not be meaningful to run this study outside Calculate.OnBarClose
2. Default values of the 5 hard-coded plots are : 1 - Futures Non Commercial Net, 2 - Futures Commercial Net, 3 - Futures Non Reportable Positions Net, 4 - Futures Open Interest, 5 - Futures Total Net
3. To access other reports and report fields, please see the 2nd example below. All fields available could be seen via Intelliprompt in the NinjaScript editor.
4. In the CotReportField enum, "Pmpu" represents : "Producer/merchant/processor/user" where CotReportField.PmpuNet would represent : "Producer/merchant/processor/user Net"
5. If a CotReportField enum is used that is not supported by the ReportType, OpenInterest will be seen.

 

## Syntax

COT(int number)

 

Returns Cot1 value

COT(int number).Cot1[int barsAgo]

 

Returns Cot2 value

COT(int number).Cot2[int barsAgo]

 

Returns Cot3 value

COT(int number).Cot3[int barsAgo]

 

Returns Cot4 value

COT(int number).Cot4[int barsAgo]

 

Returns Cot5 value

COT(int number).Cot5[int barsAgo]

 

 

## Return Value

double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

 

 

## Parameters

| number | Sets the number of plots enabled |
| --- | --- |

 

##  

## Examples

##

|  |
| --- |
| // Prints the current value of COT 4th plot (default Futures Open Interest), the COT(4) would allow us to access the Cot1, Cot2, Cot3 and Cot4 plots, but not Cot5 (since not enabled)<br>double value = COT(4).Cot4[0];<br>Print("The current COT Futures Open Interest value is " + value.ToString()); |

 

##

|  |
| --- |
| // Advanced example where two plots in total are enabled (COT(2)). Next, the ReportType and Field are custom set per each plot. <br>else if (State == State.DataLoaded)<br>{<br>   cot1 = COT(2);<br>   cot1.CotReport1.ReportType = CotReportType.Combined;<br>   cot1.CotReport2.ReportType = CotReportType.Combined;<br>   cot1.CotReport1.Field = CotReportField.OpenInterest;<br>   cot1.CotReport2.Field = CotReportField.TotalNet;<br>} |

 

 

## Source Code

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.