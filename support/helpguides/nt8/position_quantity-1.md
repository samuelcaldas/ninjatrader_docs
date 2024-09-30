
NinjaScript \> Language Reference \> Strategy \> Position \> Quantity

Quantity

| \<\< [Click to Display Table of Contents](position_quantity.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [Position](position-1.md) \> Quantity | [Previous page](position_marketposition-1.md) [Return to chapter overview](position-1.md) [Next page](positionaccount-1.md) |
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
| protected override void OnBarUpdate() {       // Prints out the current market position      Print(Position.MarketPosition.ToString() \+ " " \+ Position.Quantity.ToString()); } |
