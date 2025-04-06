



Exchanges

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](exchanges.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [Instruments](instruments_ninjascript.htm) > [Instrument](instrument.htm) > [MasterInstrument](masterinstrument.htm) >  Exchanges | [Previous page](dividends.htm) [Return to chapter overview](masterinstrument.htm) [Next page](formatprice.htm) |

Definition
----------

A collection of exchange(s) configured for the [Master Instrument properties](editing_instruments.htm).

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