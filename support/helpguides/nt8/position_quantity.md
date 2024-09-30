
NinjaScript > Language Reference > Strategy > Position > Quantity

Quantity

| << [Click to Display Table of Contents](position_quantity.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > [Position](position.md) > Quantity | [Previous page](position_marketposition.md) [Return to chapter overview](position.md) [Next page](positionaccount.md) |
| --- | --- |
## Definition
Gets the strategy's current position size.
## 
## Property Value
An int value representing the position size.
## 
## Syntax
Position.Quantity   

 
## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {       // Prints out the current market position      Print(Position.MarketPosition.ToString() + " " + Position.Quantity.ToString()); } |
