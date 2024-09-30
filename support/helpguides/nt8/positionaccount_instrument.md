
NinjaScript \> Language Reference \> Strategy \> PositionAccount \> Instrument

Instrument

| \<\< [Click to Display Table of Contents](positionaccount_instrument.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [PositionAccount](positionaccount.md) \> Instrument | [Previous page](positionaccount_getunrealizedprofitloss.md) [Return to chapter overview](positionaccount.md) [Next page](positionaccount_marketposition.md) |
| --- | --- |
## Definition
Gets the instrument of an account position.
 
## Property Value
An [Instrument](instrument.md) representing the account's instrument position
## 
## Syntax
PositionAccount.Instrument
 
## 
## Examples

| ns |
| --- |
| protected override void OnPositionUpdate(Position position, double averagePrice, int quantity, MarketPosition marketPosition) {      // If the position is an AAPL position      if (PositionAccount.Instrument.MasterInstrument.Name \=\= "AAPL")    {          //do something        } } |
