
NinjaScript \> Language Reference \> Strategy \> Position \> Instrument

Instrument

| \<\< [Click to Display Table of Contents](position_instrument.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [Position](position-1.md) \> Instrument | [Previous page](position_getunrealizedprofitloss-1.md) [Return to chapter overview](position-1.md) [Next page](position_marketposition-1.md) |
| --- | --- |
## Definition
Gets the instrument of a strategy position.
 
## Property Value
An [Instrument](instrument-1.md) representing the position's instrument.
## 
## Syntax
Position.Instrument
 
## 
## Examples

| ns |
| --- |
| protected override void OnPositionUpdate(Position position, double averagePrice, int quantity, MarketPosition marketPosition) {      // If the position is an AAPL position      if (position.Instrument.MasterInstrument.Name \=\= "AAPL")    {          //do something        } } |
