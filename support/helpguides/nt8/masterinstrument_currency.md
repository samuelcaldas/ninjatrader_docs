
NinjaScript \> Language Reference \> Common \> Instruments \> Instrument \> MasterInstrument \> Currency

Currency

| \<\< [Click to Display Table of Contents](masterinstrument_currency.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Instruments](instruments_ninjascript.md) \> [Instrument](instrument.md) \> [MasterInstrument](masterinstrument.md) \> Currency | [Previous page](compare.md) [Return to chapter overview](masterinstrument.md) [Next page](masterinstrument_description.md) |
| --- | --- |
## Definition
Indicates the currency configured for the [Master Instrument properties](editing_instruments.md).
## 
## Property Value
A type of Currency which is configured for the current master instrument.
 
## Syntax
Bars.Instrument.MasterInstrument.Currency
 
## 
## Examples

| ns |
| --- |
| if (Bars.Instrument.MasterInstrument.Currency !\= Currency.UsDollar) {  //Prints if the currency is not UsDollar and indicates what currency it is  Print ("Warning: Instruments base currency is not UsDollar, it is " \+ Bars.Instrument.MasterInstrument.Currency); } |
