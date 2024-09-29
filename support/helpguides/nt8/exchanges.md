


NinjaScript \> Language Reference \> Common \> Instruments \> Instrument \> MasterInstrument \> Exchanges






















Exchanges







| \<\< [Click to Display Table of Contents](exchanges.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Instruments](instruments_ninjascript.md) \> [Instrument](instrument.md) \> [MasterInstrument](masterinstrument.md) \> Exchanges | [Previous page](dividends.md) [Return to chapter overview](masterinstrument.md) [Next page](formatprice.md) |
| --- | --- |











## Definition


A collection of exchange(s) configured for the [Master Instrument properties](editing_instruments.md).


## 


## Property Value


A collection of Exchanges which represent the exchanges configured for the current instrument.


 


## Syntax


Bars.Instrument.MasterInstrument.Exchanges


## 


## Examples




| ns |
| --- |
| foreach(Exchange exchange in Bars.Instrument.MasterInstrument.Exchanges) {  Print(exchange); // Default, Nasdaq, NYSE } |









