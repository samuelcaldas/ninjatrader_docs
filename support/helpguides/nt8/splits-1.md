



Splits

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\splits.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Instruments](instruments_ninjascript-1.htm) > [Instrument](instrument-1.htm) > [MasterInstrument](masterinstrument-1.htm) >  Splits | [Previous page](rounddowntoticksize-1.htm) [Return to chapter overview](masterinstrument-1.htm) [Next page](masterinstrument_ticksize-1.htm) |

Definition
----------

Indicates the Splits that have been configured for the [Master Instrument properties](editing_instruments-1.htm) used in for stocks.

Property Value
--------------

A collection of Splits configured for the current instrument.

Possible values are:

|  |  |
| --- | --- |
| Date | A DateTime structure representing the date of the split |
| Factor | A double value representing the number of points the stock split |

Syntax
------

Bars.Instrument.MasterInstrument.Splits

Examples
--------

| ns |
| --- |
| foreach (Split split in Bars.Instrument.MasterInstrument.Splits)  {       Print(split.Date);       Print(split.Factor);  } |