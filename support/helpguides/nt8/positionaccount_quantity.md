
NinjaScript > Language Reference > Strategy > PositionAccount > Quantity

Quantity

| << [Click to Display Table of Contents](positionaccount_quantity.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > [PositionAccount](positionaccount.md) > Quantity | [Previous page](positionaccount_marketposition.md) [Return to chapter overview](positionaccount.md) [Next page](positions.md) |
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
| protected override void OnBarUpdate() {       // Prints out the current market position      Print(PositionAccount.MarketPosition.ToString() + " " + PositionAccount.Quantity.ToString()); } |
