
NinjaScript \> Language Reference \> Common \> Instruments \> Instrument \> MasterInstrument \> Url
Url
| \<\< [Click to Display Table of Contents](url.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Instruments](instruments_ninjascript-1.md) \> [Instrument](instrument-1.md) \> [MasterInstrument](masterinstrument-1.md) \> Url | [Previous page](masterinstrument_ticksize-1.md) [Return to chapter overview](masterinstrument-1.md) [Next page](iseriest-1.md) |
| --- | --- |
## Definition
Indicates the Url configured for the [Master Instrument properties](editing_instruments-1.md).
## 
## Property Value
A string value representing the Url that is configured for the current master instrument.
 
## Syntax
Bars.Instrument.MasterInstrument.Url
 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate()  {          // Displays the master instrument's URL at the bottom right of the chart          Draw.TextFixed(this, "tag1", "Instruments URL is " \+ Bars.Instrument.MasterInstrument.Url, TextPosition.BottomRight);  } |
