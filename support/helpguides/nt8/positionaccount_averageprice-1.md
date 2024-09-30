
NinjaScript > Language Reference > Strategy > PositionAccount > AveragePrice

AveragePrice

| << [Click to Display Table of Contents](positionaccount_averageprice.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Strategy](strategy-1.md) > [PositionAccount](positionaccount-1.md) > AveragePrice | [Previous page](positionaccount-1.md) [Return to chapter overview](positionaccount-1.md) [Next page](positionaccount_getunrealizedprofitloss-1.md) |
| --- | --- |
## Definition
Gets the average price of an account position.
 
## Property Value
A double value representing the account position's average price per unit.
## 
## Syntax
PositionAccount.AveragePrice
 
## 
## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {      // Raise stop loss to breakeven when there is at least 10 ticks in profit      if (Close[0] >= PositionAccount.AveragePrice + 10 * TickSize)          ExitLongStopMarket(PositionAccount.Quantity, PositionAccount.AveragePrice); } |
