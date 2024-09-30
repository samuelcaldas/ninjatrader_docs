
NinjaScript > Language Reference > Common > Instruments > Instrument > MasterInstrument > Exchanges
Exchanges
| << [Click to Display Table of Contents](exchanges.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Instruments](instruments_ninjascript-1.md) > [Instrument](instrument-1.md) > [MasterInstrument](masterinstrument-1.md) > Exchanges | [Previous page](dividends-1.md) [Return to chapter overview](masterinstrument-1.md) [Next page](formatprice-1.md) |
| --- | --- |
## Definition
A collection of exchange(s) configured for the [Master Instrument properties](editing_instruments-1.md).
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

