


NinjaScript \> Language Reference \> Common \> Instruments \> Instrument \> MasterInstrument \> Splits






















Splits







| \<\< [Click to Display Table of Contents](splits.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Instruments](instruments_ninjascript-1.md) \> [Instrument](instrument-1.md) \> [MasterInstrument](masterinstrument-1.md) \> Splits | [Previous page](rounddowntoticksize-1.md) [Return to chapter overview](masterinstrument-1.md) [Next page](masterinstrument_ticksize-1.md) |
| --- | --- |











## Definition


Indicates the Splits that have been configured for the [Master Instrument properties](editing_instruments-1.md) used in for stocks.


## 


## Property Value


A collection of Splits configured for the current instrument.


 


Possible values are:




| Date | A DateTime structure representing the date of the split |
| --- | --- |
| Factor | A double value representing the number of points the stock split |



 


 


## Syntax


Bars.Instrument.MasterInstrument.Splits


 


## Examples




| ns |
| --- |
| foreach (Split split in Bars.Instrument.MasterInstrument.Splits) {      Print(split.Date);      Print(split.Factor); } |









