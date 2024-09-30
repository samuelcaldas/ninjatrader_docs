
NinjaScript \> Language Reference \> Common \> Instruments \> Instrument \> MasterInstrument \> Url
Url
| \<\< [Click to Display Table of Contents](url.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Instruments](instruments_ninjascript.md) \> [Instrument](instrument.md) \> [MasterInstrument](masterinstrument.md) \> Url | [Previous page](masterinstrument_ticksize.md) [Return to chapter overview](masterinstrument.md) [Next page](iseriest.md) |
| --- | --- |
## Definition
Indicates the Url configured for the [Master Instrument properties](editing_instruments.md).
## 
## Property Value
A string value representing the Url that is configured for the current master instrument.
 
## Syntax
Bars.Instrument.MasterInstrument.Url
 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate()  {          // Displays the master instrument's URL at the bottom right of the chart          Draw.TextFixed(this, "tag1", "Instruments URL is " \+ Bars.Instrument.MasterInstrument.Url, TextPosition.BottomRight);  } |
