


NinjaScript \> Language Reference \> Strategy \> PositionAccount \> Quantity






















Quantity







| \<\< [Click to Display Table of Contents](positionaccount_quantity.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [PositionAccount](positionaccount-1.md) \> Quantity | [Previous page](positionaccount_marketposition-1.md) [Return to chapter overview](positionaccount-1.md) [Next page](positions-1.md) |
| --- | --- |











## Definition


Gets the current account's position size.


## 


## Property Value


An int value representing the account's position size.


## 


## Syntax


PositionAccount.Quantity   

 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {       // Prints out the current market position      Print(PositionAccount.MarketPosition.ToString() \+ " " \+ PositionAccount.Quantity.ToString()); } |









