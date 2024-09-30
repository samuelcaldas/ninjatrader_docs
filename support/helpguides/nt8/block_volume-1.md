
NinjaScript \> Language Reference \> Common \> System Indicator Methods \> Block Volume

Block Volume
| \<\< [Click to Display Table of Contents](block_volume.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [System Indicator Methods](indicators-1.md) \> Block Volume | [Previous page](balance_of_power_bop-1.md) [Return to chapter overview](indicators-1.md) [Next page](bollinger_bands-1.md) |
| --- | --- |
## Description
Block volume detects block trades and display how many occurred per bar. This can be displayed either as trades or volume. Historical tick data is required to plot historically.
 
## Syntax
BlockVolume(int blockSize, CountType countType)
BlockVolume(ISeries\<double\> input, int blockSize, CountType countType)
 
## Return Value
double; Accessing this method via an index value \[int barsAgo] returns the indicator value of the referenced bar.
 
## Parameters
| input | Indicator source data ([?](valid_input_data_for_indicator-1.md)) |
| --- | --- |
| blockSize | The minimum volume a trade must be to be considered a block trade |
| countType | The format to count the block trades. By number of block trades that occurred or total block trade volume |

 
## 
## Examples
| ns |
| --- |
| // A 1 tick data series must be added to OnStateChange() as this indicator runs off of tick data else if (State \=\= State.Configure) {    AddDataSeries(Data.BarsPeriodType.Tick, 1); }   // Prints the current value of an 80 block trade size counted in volume for the Block Volume if (BarsInProgress \=\= 0) { double value \= BlockVolume(80, CountType.Volume)\[0]; Print("The current Block Volume value is " \+ value.ToString()); } |
