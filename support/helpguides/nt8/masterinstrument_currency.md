



Currency

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](masterinstrument_currency.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [Instruments](instruments_ninjascript.htm) > [Instrument](instrument.htm) > [MasterInstrument](masterinstrument.htm) >  Currency | [Previous page](compare.htm) [Return to chapter overview](masterinstrument.htm) [Next page](masterinstrument_description.htm) |

Definition
----------

Indicates the currency configured for the [Master Instrument properties](editing_instruments.htm).

Property Value
--------------

A type of Currency which is configured for the current master instrument.

Syntax
------

Bars.Instrument.MasterInstrument.Currency

Examples
--------

| ns |
| --- |
| if (Bars.Instrument.MasterInstrument.Currency != Currency.UsDollar)  {   //Prints if the currency is not UsDollar and indicates what currency it is   Print ("Warning: Instruments base currency is not UsDollar, it is " + Bars.Instrument.MasterInstrument.Currency);  } |