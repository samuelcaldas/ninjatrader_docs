
NinjaScript \> Language Reference \> Common \> Instruments \> Instrument \> MasterInstrument \> Name

Name

| \<\< [Click to Display Table of Contents](masterinstrument_name.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Instruments](instruments_ninjascript-1.md) \> [Instrument](instrument-1.md) \> [MasterInstrument](masterinstrument-1.md) \> Name | [Previous page](mergepolicy-1.md) [Return to chapter overview](masterinstrument-1.md) [Next page](getnextexpiry-1.md) |
| --- | --- |
## Definition
Indicates the NinjaTrader database name of an instrument. For example, "MSFT", "ES", "NQ" etc...

## Property Value
A string representing the name of the instrument.
## 
## Syntax
Instrument.MasterInstrument.Name
 
## 
## Examples

| ns |
| --- |
| protected override void OnBarUpdate()          {                  // Displays the master instrument's name at the bottom right of the chart                  Draw.TextFixed(this, "tag1", Bars.Instrument.MasterInstrument.Name, TextPosition.BottomRight);          } |
## 
 
## Additional Access Information
This property can be accessed without a null reference check in the OnBarUpdate() event handler. When the OnBarUpdate() event is triggered, there will always be an Instrument object. Should you wish to access this property elsewhere, check for null reference first. e.g. if (Instrument !\= null)
