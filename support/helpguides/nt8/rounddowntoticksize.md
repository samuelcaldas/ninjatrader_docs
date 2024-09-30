
NinjaScript \> Language Reference \> Common \> Instruments \> Instrument \> MasterInstrument \> RoundDownToTickSize()

RoundDownToTickSize()

| \<\< [Click to Display Table of Contents](rounddowntoticksize.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Instruments](instruments_ninjascript.md) \> [Instrument](instrument.md) \> [MasterInstrument](masterinstrument.md) \> RoundDownToTickSize() | [Previous page](roundtoticksize.md) [Return to chapter overview](masterinstrument.md) [Next page](splits.md) |
| --- | --- |
## Definition
Returns a value that is rounded down to the nearest valid value evenly divisible by the instrument's tick size.
## 
## Method Return Value
A double value.
 
## Syntax
Instrument.MasterInstrument.RoundDownToTickSize(double price)
 
## Parameters

| price | A double value representing a price |
| --- | --- |

## Examples

| ns |
| --- |
| //Takes the last 3 closes, divides them by 3, and rounds the value down to the nearest valid tick size Value\[0] \= Instrument.MasterInstrument.RoundDownToTickSize((Close\[0] \+ Close\[1] \+ Close\[2]) / 3\); |
