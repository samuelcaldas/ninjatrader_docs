
NinjaScript \> Language Reference \> Common \> Instruments \> Instrument \> MasterInstrument \> PointValue

PointValue

| \<\< [Click to Display Table of Contents](pointvalue.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Instruments](instruments_ninjascript.md) \> [Instrument](instrument.md) \> [MasterInstrument](masterinstrument.md) \> PointValue | [Previous page](getnextexpiry.md) [Return to chapter overview](masterinstrument.md) [Next page](rollovercollection.md) |
| --- | --- |
## Definition
Indicates the currency value of 1 full point of movement. For example, 1 point in the S\&P 500 Emini futures contract (ES) is $50 USD which is equal to $12\.50 USD per tick.
## 
## Property Value
A double value representing the currency value of 1 point of movement.
 
## Syntax
Instrument.MasterInstrument.PointValue
 
## Examples

| ns |
| --- |
| protected override void OnBarUpdate()          {                  // Displays the master instrument's point value at the bottom right of the chart                  Draw.TextFixed(this, "Point value: ", Bars.Instrument.MasterInstrument.PointValue.ToString(), TextPosition.BottomRight);          } |
## 
 
## Additional Access Information
This property can be accessed without a null reference check in the OnBarUpdate() event handler. When the OnBarUpdate() event is triggered, there will always be an Instrument object. Should you wish to access this property elsewhere, check for null reference first. e.g. if (Instrument !\= null)
