
NinjaScript > Language Reference > Common > Instruments > Instrument > MasterInstrument > RolloverCollection

RolloverCollection

| << [Click to Display Table of Contents](rollovercollection.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Instruments](instruments_ninjascript-1.md) > [Instrument](instrument-1.md) > [MasterInstrument](masterinstrument-1.md) > RolloverCollection | [Previous page](pointvalue-1.md) [Return to chapter overview](masterinstrument-1.md) [Next page](roundtoticksize-1.md) |
| --- | --- |
## Definition
Indicates the rollovers that have been configured for the [Master Instrument properties](editing_instruments-1.md) used in for futures.
## 
## Property Value
A RolloversCollection configured for the current instrument.
 
Possible values are:

| ContractMonth | A DateTime structure representing the expiry month of a futures contract |
| --- | --- |
| Date | A DateTime structure representing the date of the rollover |
| Offset | A double value representing the number of points between contracts |
 
## Syntax
Bars.Instrument.MasterInstrument.RolloverCollection
 
## Examples

| ns |
| --- |
| foreach(var rollover in Bars.Instrument.MasterInstrument.RolloverCollection) {      Print(rollover.ContractMonth);      Print(rollover.Date);      Print(rollover.Offset); } |
