



GetNextExpiry()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\getnextexpiry.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Instruments](instruments_ninjascript-1.htm) > [Instrument](instrument-1.htm) > [MasterInstrument](masterinstrument-1.htm) >  GetNextExpiry() | [Previous page](masterinstrument_name-1.htm) [Return to chapter overview](masterinstrument-1.htm) [Next page](pointvalue-1.htm) |

Definition
----------

Returns the current futures expiry compared to the time of the input value used for the method.

Method Return Value
-------------------

A [DateTime](http://msdn2.microsoft.com/en-us/library/system.datetime.aspx) structure

Syntax
------

Bars.Instrument.MasterInstrument.GetNextExpiry(DateTime afterDate)

Parameters
----------

|  |  |
| --- | --- |
| afterDate | A DateTime value representing to be compared |

Examples
--------

| ns |
| --- |
| // Indicates what the current expiry is in the bottom right of the chart  Draw.TextFixed(this, "tag1", "The current expiry is " + Bars.Instrument.MasterInstrument.GetNextExpiry(DateTime.Now).ToString("MM-yy"), TextPosition.BottomRight); |