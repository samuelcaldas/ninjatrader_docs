
NinjaScript \> Language Reference \> Common \> System Indicator Methods \> On Balance Volume (OBV)
On Balance Volume (OBV)
| \<\< [Click to Display Table of Contents](on_balance_volume_obv.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [System Indicator Methods](indicators-1.md) \> On Balance Volume (OBV) | [Previous page](n_bars_up-1.md) [Return to chapter overview](indicators-1.md) [Next page](order_flow_cumulative_delta2-1.md) |
| --- | --- |
## Description
OBV is a simple indicator that adds a period's volume when the close is up and subtracts the period's volume when the close is down. A cumulative total of the volume additions and subtractions forms the OBV line. This line can then be compared with the price chart of the underlying security to look for divergences or confirmation.
 
... Courtesy of [StockCharts](http://stockcharts.com/education/IndicatorAnalysis/indic-obv.md)

## Syntax
OBV()  

OBV(ISeries\<double\> input)
 
Returns default value  

OBV()\[int barsAgo]  

OBV(ISeries\<double\> input)\[int barsAgo]

## Return Value
double; Accessing this method via an index value \[int barsAgo] returns the indicator value of the referenced bar.

## Parameters
| input | Indicator source data ([?](valid_input_data_for_indicator-1.md)) |
| --- | --- |

 
## Example
| ns |
| --- |
| // Prints the current value of OBV double value \= OBV()\[0]; Print("The current OBV value is " \+ value.ToString()); |

## Source Code
You can view this indicator method source code by selecting the menu New \> NinjaScript Editor \> Indicators within the NinjaTrader Control Center window.
