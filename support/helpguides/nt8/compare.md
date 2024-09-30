
NinjaScript \> Language Reference \> Common \> Instruments \> Instrument \> MasterInstrument \> Compare()
Compare()
| \<\< [Click to Display Table of Contents](compare.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Instruments](instruments_ninjascript.md) \> [Instrument](instrument.md) \> [MasterInstrument](masterinstrument.md) \> Compare() | [Previous page](masterinstrument.md) [Return to chapter overview](masterinstrument.md) [Next page](masterinstrument_currency.md) |
| --- | --- |
## Definition
Compares two price values with respect to the Instrument [TickSize](ticksize.md) to ensure accuracy when dealing with floating point math.
## 
## Method Return Value
An int value.
 
A value of "1" is returned if price1 is greater than price2
A value of "\-1" is returned if price1 is less than price2   

A value of "0" if price1 is equal to price2
 
## Syntax
Instrument.MasterInstrument.Compare(double price1, double price2)
## Parameters
| price1 | A double value representing a price |
| --- | --- |
| price2 | A double value representing a price |
 
## Examples
| ns |
| --- |
| double newPrice \= Close\[0] \+ High\[0] \+ Open\[0]; if (Instrument.MasterInstrument.Compare(newPrice, Close\[1]) \=\= 1)      // Do something since price1 is greater than price2 |

