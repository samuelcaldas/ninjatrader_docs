
NinjaScript > Language Reference > Strategy > Position > MarketPosition

MarketPosition

| << [Click to Display Table of Contents](position_marketposition.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > [Position](position.md) > MarketPosition | [Previous page](position_instrument.md) [Return to chapter overview](position.md) [Next page](position_quantity.md) |
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
