


NinjaScript \> Language Reference \> Common \> Instruments \> Instrument \> MasterInstrument \> Dividends






















Dividends







| \<\< [Click to Display Table of Contents](dividends.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Instruments](instruments_ninjascript-1.md) \> [Instrument](instrument-1.md) \> [MasterInstrument](masterinstrument-1.md) \> Dividends | [Previous page](masterinstrument_description-1.md) [Return to chapter overview](masterinstrument-1.md) [Next page](exchanges-1.md) |
| --- | --- |











## Definition


An collection of Dividends configured for the [Master Instrument properties](editing_instruments-1.md) used in for stocks.


## 


## Property Value


A collection of Dividends configured for the current instrument.


 


Possible values are:




| Amount | A double value representing the amount in dollars which was paid on the date of the dividend |
| --- | --- |
| Date | A DateTime structure representing the date of the dividend |



 


## Syntax


Bars.Instrument.MasterInstrument.Dividends


 


## Examples




| ns |
| --- |
| foreach(Dividend dividends in Bars.Instrument.MasterInstrument.Dividends) {    Print(dividends.Amount);    Print(dividends.Date); } |









