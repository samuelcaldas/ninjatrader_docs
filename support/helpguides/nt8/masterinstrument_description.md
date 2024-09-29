


NinjaScript \> Language Reference \> Common \> Instruments \> Instrument \> MasterInstrument \> Description






















Description







| \<\< [Click to Display Table of Contents](masterinstrument_description.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Instruments](instruments_ninjascript.md) \> [Instrument](instrument.md) \> [MasterInstrument](masterinstrument.md) \> Description | [Previous page](masterinstrument_currency.md) [Return to chapter overview](masterinstrument.md) [Next page](dividends.md) |
| --- | --- |











## Definition


Indicates the description configured for the [Master Instrument properties](editing_instruments.md).


## 


## Property Value


A string value which is configured for the current master instrument.


 


## Syntax


Bars.Instrument.MasterInstrument.Description


 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate()          {                  // Displays the master instrument's description at the bottom right of the chart                  Draw.TextFixed(this, "tag1", Bars.Instrument.MasterInstrument.Description, TextPosition.BottomRight);          } |









