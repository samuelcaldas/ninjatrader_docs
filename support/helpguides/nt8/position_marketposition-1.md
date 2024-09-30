
NinjaScript > Language Reference > Strategy > Position > MarketPosition

MarketPosition

| << [Click to Display Table of Contents](position_marketposition.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Strategy](strategy-1.md) > [Position](position-1.md) > MarketPosition | [Previous page](position_instrument-1.md) [Return to chapter overview](position-1.md) [Next page](position_quantity-1.md) |
| --- | --- |
## Definition
Gets the strategy's current market position
 
## Property Value
MarketPosition.Flat
MarketPosition.Long
MarketPosition.Short
## 
## Syntax
Position.MarketPosition  

 
## 
## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {       // If not flat print our open PnL      if (Position.MarketPosition != MarketPosition.Flat)           Print("Open PnL: " + Position.GetUnrealizedProfitLoss(PerformanceUnit.Points, Close[0])); } |
