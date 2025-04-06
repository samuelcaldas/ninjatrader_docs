



Description

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](masterinstrument_description.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [Instruments](instruments_ninjascript.htm) > [Instrument](instrument.htm) > [MasterInstrument](masterinstrument.htm) >  Description | [Previous page](masterinstrument_currency.htm) [Return to chapter overview](masterinstrument.htm) [Next page](dividends.htm) |

Definition
----------

Indicates the description configured for the [Master Instrument properties](editing_instruments.htm).

Property Value
--------------

A string value which is configured for the current master instrument.

Syntax
------

Bars.Instrument.MasterInstrument.Description

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()           {                   // Displays the master instrument's description at the bottom right of the chart                   Draw.TextFixed(this, "tag1", Bars.Instrument.MasterInstrument.Description, TextPosition.BottomRight);           } |