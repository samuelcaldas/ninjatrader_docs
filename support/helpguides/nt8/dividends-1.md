



Dividends

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\dividends.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Instruments](instruments_ninjascript-1.htm) > [Instrument](instrument-1.htm) > [MasterInstrument](masterinstrument-1.htm) >  Dividends | [Previous page](masterinstrument_description-1.htm) [Return to chapter overview](masterinstrument-1.htm) [Next page](exchanges-1.htm) |

Definition
----------

An collection of Dividends configured for the [Master Instrument properties](editing_instruments-1.htm) used in for stocks.

Property Value
--------------

A collection of Dividends configured for the current instrument.

Possible values are:

|  |  |
| --- | --- |
| Amount | A double value representing the amount in dollars which was paid on the date of the dividend |
| Date | A DateTime structure representing the date of the dividend |

Syntax
------

Bars.Instrument.MasterInstrument.Dividends

Examples
--------

| ns |
| --- |
| foreach(Dividend dividends in Bars.Instrument.MasterInstrument.Dividends)  {     Print(dividends.Amount);     Print(dividends.Date);  } |