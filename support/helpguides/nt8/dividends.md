
NinjaScript > Language Reference > Common > Instruments > Instrument > MasterInstrument > Dividends
Dividends
| << [Click to Display Table of Contents](dividends.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Instruments](instruments_ninjascript.md) > [Instrument](instrument.md) > [MasterInstrument](masterinstrument.md) > Dividends | [Previous page](masterinstrument_description.md) [Return to chapter overview](masterinstrument.md) [Next page](exchanges.md) |
| --- | --- |
## Definition
An collection of Dividends configured for the [Master Instrument properties](editing_instruments.md) used in for stocks.
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

