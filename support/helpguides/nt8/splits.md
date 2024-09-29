


NinjaScript \> Language Reference \> Common \> Instruments \> Instrument \> MasterInstrument \> Splits






















Splits







| \<\< [Click to Display Table of Contents](splits.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Instruments](instruments_ninjascript.md) \> [Instrument](instrument.md) \> [MasterInstrument](masterinstrument.md) \> Splits | [Previous page](rounddowntoticksize.md) [Return to chapter overview](masterinstrument.md) [Next page](masterinstrument_ticksize.md) |
| --- | --- |











## Definition


Indicates the Splits that have been configured for the [Master Instrument properties](editing_instruments.md) used in for stocks.


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









