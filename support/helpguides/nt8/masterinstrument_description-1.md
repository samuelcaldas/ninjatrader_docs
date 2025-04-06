



Description

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\masterinstrument_description.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Instruments](instruments_ninjascript-1.htm) > [Instrument](instrument-1.htm) > [MasterInstrument](masterinstrument-1.htm) >  Description | [Previous page](masterinstrument_currency-1.htm) [Return to chapter overview](masterinstrument-1.htm) [Next page](dividends-1.htm) |

Definition
----------

Indicates the description configured for the [Master Instrument properties](editing_instruments-1.htm).

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