
NinjaScript \> Language Reference \> Strategy \> PositionAccount \> Instrument

Instrument

| \<\< [Click to Display Table of Contents](positionaccount_instrument.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [PositionAccount](positionaccount-1.md) \> Instrument | [Previous page](positionaccount_getunrealizedprofitloss-1.md) [Return to chapter overview](positionaccount-1.md) [Next page](positionaccount_marketposition-1.md) |
| --- | --- |
## Definition
Gets the instrument of an account position.
 
## Property Value
An [Instrument](instrument-1.md) representing the account's instrument position
## 
## Syntax
PositionAccount.Instrument
 
## 
## Examples

| ns |
| --- |
| protected override void OnPositionUpdate(Position position, double averagePrice, int quantity, MarketPosition marketPosition) {      // If the position is an AAPL position      if (PositionAccount.Instrument.MasterInstrument.Name \=\= "AAPL")    {          //do something        } } |
