


NinjaScript \> Language Reference \> Strategy \> PositionAccount \> AveragePrice






















AveragePrice







| \<\< [Click to Display Table of Contents](positionaccount_averageprice.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [PositionAccount](positionaccount.md) \> AveragePrice | [Previous page](positionaccount.md) [Return to chapter overview](positionaccount.md) [Next page](positionaccount_getunrealizedprofitloss.md) |
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
| protected override void OnBarUpdate() {      // Raise stop loss to breakeven when there is at least 10 ticks in profit      if (Close\[0] \>\= PositionAccount.AveragePrice \+ 10 \* TickSize)          ExitLongStopMarket(PositionAccount.Quantity, PositionAccount.AveragePrice); } |









