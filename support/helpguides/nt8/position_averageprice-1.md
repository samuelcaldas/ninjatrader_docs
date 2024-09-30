
NinjaScript \> Language Reference \> Strategy \> Position \> AveragePrice

AveragePrice

| \<\< [Click to Display Table of Contents](position_averageprice.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [Position](position-1.md) \> AveragePrice | [Previous page](position-1.md) [Return to chapter overview](position-1.md) [Next page](position_getunrealizedprofitloss-1.md) |
| --- | --- |
## Definition
Gets the average price of a strategy position.
 
## Property Value
A double value representing the position's average price per unit.
## 
## Syntax
Position.AveragePrice
 
## 
## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {      // Raise stop loss to breakeven when there is at least 10 ticks in profit      if (Close\[0] \>\= Position.AveragePrice \+ 10 \* TickSize)          ExitLongStopMarket(Position.Quantity, Position.AveragePrice); } |
