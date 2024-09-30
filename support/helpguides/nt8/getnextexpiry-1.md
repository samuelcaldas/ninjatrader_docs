
NinjaScript \> Language Reference \> Common \> Instruments \> Instrument \> MasterInstrument \> GetNextExpiry()
GetNextExpiry()
| \<\< [Click to Display Table of Contents](getnextexpiry.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Instruments](instruments_ninjascript-1.md) \> [Instrument](instrument-1.md) \> [MasterInstrument](masterinstrument-1.md) \> GetNextExpiry() | [Previous page](masterinstrument_name-1.md) [Return to chapter overview](masterinstrument-1.md) [Next page](pointvalue-1.md) |
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

