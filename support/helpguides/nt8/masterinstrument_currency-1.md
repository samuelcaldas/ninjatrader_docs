
NinjaScript \> Language Reference \> Common \> Instruments \> Instrument \> MasterInstrument \> Currency

Currency

| \<\< [Click to Display Table of Contents](masterinstrument_currency.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Instruments](instruments_ninjascript-1.md) \> [Instrument](instrument-1.md) \> [MasterInstrument](masterinstrument-1.md) \> Currency | [Previous page](compare-1.md) [Return to chapter overview](masterinstrument-1.md) [Next page](masterinstrument_description-1.md) |
| --- | --- |
## Definition
Indicates the currency configured for the [Master Instrument properties](editing_instruments-1.md).
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
