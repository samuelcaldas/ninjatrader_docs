



Exchanges

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\exchanges.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Instruments](instruments_ninjascript-1.htm) > [Instrument](instrument-1.htm) > [MasterInstrument](masterinstrument-1.htm) >  Exchanges | [Previous page](dividends-1.htm) [Return to chapter overview](masterinstrument-1.htm) [Next page](formatprice-1.htm) |

Definition
----------

A collection of exchange(s) configured for the [Master Instrument properties](editing_instruments-1.htm).

Property Value
--------------

A collection of Exchanges which represent the exchanges configured for the current instrument.

Syntax
------

Bars.Instrument.MasterInstrument.Exchanges

Examples
--------

| ns |
| --- |
| foreach(Exchange exchange in Bars.Instrument.MasterInstrument.Exchanges)  {   Print(exchange); // Default, Nasdaq, NYSE  } |