
NinjaScript \> Language Reference \> Common \> Instruments \> Instrument \> MasterInstrument \> Name

Name

| \<\< [Click to Display Table of Contents](masterinstrument_name.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Instruments](instruments_ninjascript.md) \> [Instrument](instrument.md) \> [MasterInstrument](masterinstrument.md) \> Name | [Previous page](mergepolicy.md) [Return to chapter overview](masterinstrument.md) [Next page](getnextexpiry.md) |
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
