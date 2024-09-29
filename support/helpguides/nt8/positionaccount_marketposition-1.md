


NinjaScript \> Language Reference \> Strategy \> PositionAccount \> MarketPosition






















MarketPosition







| \<\< [Click to Display Table of Contents](positionaccount_marketposition.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [PositionAccount](positionaccount-1.md) \> MarketPosition | [Previous page](positionaccount_instrument-1.md) [Return to chapter overview](positionaccount-1.md) [Next page](positionaccount_quantity-1.md) |
| --- | --- |











## Definition


Gets the account's current market position


 


## Property Value


MarketPosition.Flat


MarketPosition.Long


MarketPosition.Short


## 


## Syntax


PositionAccount.MarketPosition  

 


## 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {       // If not flat print our open PnL      if (PositionAccount.MarketPosition !\= MarketPosition.Flat)           Print("Open PnL: " \+ PositionAccount.GetUnrealizedProfitLoss(PerformanceUnit.Points, Close\[0])); } |









