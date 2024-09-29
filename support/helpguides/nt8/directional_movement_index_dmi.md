


NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Directional Movement Index (DMI)






















Directional Movement Index (DMI)







| \<\< [Click to Display Table of Contents](directional_movement_index_dmi.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [System Indicator Methods](indicators.md) \> Directional Movement Index (DMI) | [Previous page](directional_movement_dm.md) [Return to chapter overview](indicators.md) [Next page](disparity_index.md) |
| --- | --- |











## Description


An indicator developed by J. Welles Wilder for identifying when a definable trend is present in an instrument. That is, the DMI tells whether an instrument is trending or not.


 


...Courtesy of [FMLabs](http://www.fmlabs.com/reference/default.htm?url=DX.md)


 


## Syntax


DMI(int period)  

DMI(ISeries\<double\> input, int period)


 


Returns default value  

DMI(int period)\[int barsAgo]  

DMI(ISeries\<double\> input, int period)\[int barsAgo]


 


 


## Return Value


double; Accessing this method via an index value \[int barsAgo] returns the indicator value of the referenced bar.


 


 


## Parameters




| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| --- | --- |
| period | Number of bars used in the calculation |



 


## 


## Example




| ns |
| --- |
| // Prints the current value of a 20 period DMI using default price type double value \= DMI(20)\[0]; Print("The current DMI value is " \+ value.ToString()); |



 


 


## Source Code


You can view this indicator method source code by selecting the menu New \> NinjaScript Editor \> Indicators within the NinjaTrader Control Center window.








