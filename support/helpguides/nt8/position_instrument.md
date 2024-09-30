
NinjaScript \> Language Reference \> Strategy \> Position \> Instrument

Instrument

| \<\< [Click to Display Table of Contents](position_instrument.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [Position](position.md) \> Instrument | [Previous page](position_getunrealizedprofitloss.md) [Return to chapter overview](position.md) [Next page](position_marketposition.md) |
| --- | --- |
## Definition
Gets the instrument of a strategy position.
 
## Property Value
An [Instrument](instrument.md) representing the position's instrument.
## 
## Syntax
Position.Instrument
 
## 
## Examples

| ns |
| --- |
| protected override void OnPositionUpdate(Position position, double averagePrice, int quantity, MarketPosition marketPosition) {      // If the position is an AAPL position      if (position.Instrument.MasterInstrument.Name \=\= "AAPL")    {          //do something        } } |
