


NinjaScript \> Language Reference \> Common \> Instruments \> Instrument \> MasterInstrument \> TickSize






















TickSize







| \<\< [Click to Display Table of Contents](masterinstrument_ticksize.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Instruments](instruments_ninjascript-1.md) \> [Instrument](instrument-1.md) \> [MasterInstrument](masterinstrument-1.md) \> TickSize | [Previous page](splits-1.md) [Return to chapter overview](masterinstrument-1.md) [Next page](url-1.md) |
| --- | --- |











## Definition


Indicates the tick size configured for the [Master Instrument properties](editing_instruments-1.md).


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









