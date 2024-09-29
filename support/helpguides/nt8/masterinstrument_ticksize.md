


NinjaScript \> Language Reference \> Common \> Instruments \> Instrument \> MasterInstrument \> TickSize






















TickSize







| \<\< [Click to Display Table of Contents](masterinstrument_ticksize.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Instruments](instruments_ninjascript.md) \> [Instrument](instrument.md) \> [MasterInstrument](masterinstrument.md) \> TickSize | [Previous page](splits.md) [Return to chapter overview](masterinstrument.md) [Next page](url.md) |
| --- | --- |











## Definition


Indicates the tick size configured for the [Master Instrument properties](editing_instruments.md).


## 


## Property Value


A double value representing the tick size configured for the current master instrument.


 


## Syntax


Bars.Instrument.MasterInstrument.TickSize


 


## 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate()          {                  // Displays the master instrument's tick size at the bottom right of the chart                  Draw.TextFixed(this, "tag1", Bars.Instrument.MasterInstrument.TickSize.ToString(), TextPosition.BottomRight);          } |









