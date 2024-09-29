


NinjaScript \> Language Reference \> Common \> Instruments \> Instrument \> MasterInstrument \> GetNextExpiry()






















GetNextExpiry()







| \<\< [Click to Display Table of Contents](getnextexpiry.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Instruments](instruments_ninjascript.md) \> [Instrument](instrument.md) \> [MasterInstrument](masterinstrument.md) \> GetNextExpiry() | [Previous page](masterinstrument_name.md) [Return to chapter overview](masterinstrument.md) [Next page](pointvalue.md) |
| --- | --- |











## Definition


Returns the current futures expiry compared to the time of the input value used for the method.


## 


## Method Return Value


A [DateTime](http://msdn2.microsoft.com/en-us/library/system.datetime.aspx) structure


 


## Syntax


Bars.Instrument.MasterInstrument.GetNextExpiry(DateTime afterDate)


 


## Parameters




| afterDate | A DateTime value representing to be compared |
| --- | --- |



 


## Examples




| ns |
| --- |
| // Indicates what the current expiry is in the bottom right of the chart Draw.TextFixed(this, "tag1", "The current expiry is " \+ Bars.Instrument.MasterInstrument.GetNextExpiry(DateTime.Now).ToString("MM\-yy"), TextPosition.BottomRight); |









