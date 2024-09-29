


NinjaScript \> Language Reference \> Strategy \> PositionAccount \> MarketPosition






















MarketPosition







| \<\< [Click to Display Table of Contents](positionaccount_marketposition.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [PositionAccount](positionaccount.md) \> MarketPosition | [Previous page](positionaccount_instrument.md) [Return to chapter overview](positionaccount.md) [Next page](positionaccount_quantity.md) |
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









