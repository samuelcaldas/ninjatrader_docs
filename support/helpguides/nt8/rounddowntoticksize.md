



RoundDownToTickSize()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](rounddowntoticksize.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [Instruments](instruments_ninjascript.htm) > [Instrument](instrument.htm) > [MasterInstrument](masterinstrument.htm) >  RoundDownToTickSize() | [Previous page](roundtoticksize.htm) [Return to chapter overview](masterinstrument.htm) [Next page](splits.htm) |

Definition
----------

Returns a value that is rounded down to the nearest valid value evenly divisible by the instrument's tick size.

Method Return Value
-------------------

A double value.

Syntax
------

Instrument.MasterInstrument.RoundDownToTickSize(double price)

Parameters
----------

|  |  |
| --- | --- |
| price | A double value representing a price |

Examples
--------

| ns |
| --- |
| //Takes the last 3 closes, divides them by 3, and rounds the value down to the nearest valid tick size  Value[0] = Instrument.MasterInstrument.RoundDownToTickSize((Close[0] + Close[1] + Close[2]) / 3); |