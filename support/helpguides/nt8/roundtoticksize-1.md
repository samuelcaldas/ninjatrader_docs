
NinjaScript \> Language Reference \> Common \> Instruments \> Instrument \> MasterInstrument \> RoundToTickSize()

RoundToTickSize()

| \<\< [Click to Display Table of Contents](roundtoticksize.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Instruments](instruments_ninjascript-1.md) \> [Instrument](instrument-1.md) \> [MasterInstrument](masterinstrument-1.md) \> RoundToTickSize() | [Previous page](rollovercollection-1.md) [Return to chapter overview](masterinstrument-1.md) [Next page](rounddowntoticksize-1.md) |
| --- | --- |
## Definition
Returns a value that is rounded up to the nearest valid value evenly divisible by the instrument's tick size.
## 
## Method Return Value
A double value.
 
## Syntax
Instrument.MasterInstrument.RoundToTickSize(double price)
 
## Parameters

| price | A double value representing a price |
| --- | --- |
 
## Examples

| ns |
| --- |
| //Takes the last 3 closes, divides them by 3, and rounds the value up to the nearest valid tick size Value\[0] \= Instrument.MasterInstrument.RoundToTickSize((Close\[0] \+ Close\[1] \+ Close\[2]) / 3\); |
