


NinjaScript \> Language Reference \> Common \> Instruments \> Instrument \> MasterInstrument \> Description






















Description







| \<\< [Click to Display Table of Contents](masterinstrument_description.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Instruments](instruments_ninjascript-1.md) \> [Instrument](instrument-1.md) \> [MasterInstrument](masterinstrument-1.md) \> Description | [Previous page](masterinstrument_currency-1.md) [Return to chapter overview](masterinstrument-1.md) [Next page](dividends-1.md) |
| --- | --- |











## Definition


Indicates the description configured for the [Master Instrument properties](editing_instruments-1.md).


## 


## Property Value


A string value which is configured for the current master instrument.


 


## Syntax


Bars.Instrument.MasterInstrument.Description


 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate()          {                  // Displays the master instrument's description at the bottom right of the chart                  Draw.TextFixed(this, "tag1", Bars.Instrument.MasterInstrument.Description, TextPosition.BottomRight);          } |









