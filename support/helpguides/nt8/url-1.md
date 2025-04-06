



Url

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\url.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Instruments](instruments_ninjascript-1.htm) > [Instrument](instrument-1.htm) > [MasterInstrument](masterinstrument-1.htm) >  Url | [Previous page](masterinstrument_ticksize-1.htm) [Return to chapter overview](masterinstrument-1.htm) [Next page](iseriest-1.htm) |

Definition
----------

Indicates the Url configured for the [Master Instrument properties](editing_instruments-1.htm).

Property Value
--------------

A string value representing the Url that is configured for the current master instrument.

Syntax
------

Bars.Instrument.MasterInstrument.Url

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()   {           // Displays the master instrument's URL at the bottom right of the chart           Draw.TextFixed(this, "tag1", "Instruments URL is " + Bars.Instrument.MasterInstrument.Url, TextPosition.BottomRight);   } |