
NinjaScript > Language Reference > Strategy > PositionAccount > GetUnrealizedProfitLoss()

GetUnrealizedProfitLoss()

| << [Click to Display Table of Contents](positionaccount_getunrealizedprofitloss.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Strategy](strategy-1.md) > [PositionAccount](positionaccount-1.md) > GetUnrealizedProfitLoss() | [Previous page](positionaccount_averageprice-1.md) [Return to chapter overview](positionaccount-1.md) [Next page](positionaccount_instrument-1.md) |
| --- | --- |
## Definition
Calculates the unrealized PnL for the account position.
## 
## Method Return Value
A double value representing the account's unrealized PnL.
## 
## Syntax
PositionAccount.GetUnrealizedProfitLoss(PerformanceUnit unit, [double price])
 

| Note:  - If no double argument is provided in the call, the current (real-time) Last price will be substituted in. In case Tools > Options > Trading > 'Use last price for Pnl' is unchecked or the instrument type is Forex / CFD the bid (for a long position) / ask (for a short position) would be used as a substitute. - For back-testing a double price to compare against should be provided like in our example below. |
| --- |

## Parameters

| unit | Possible values: PerformanceUnit.Currency PerformanceUnit.Percent PerformanceUnit.Pips PerformanceUnit.Points PerformanceUnit.Ticks |
| --- | --- |
| price | Optional price passed in used to calculate the PnL such as Close[0]. This value is used as the current price and compared against your entry price for the PnL. |
 
## 
## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {      // If not flat print our unrealized PnL      if (PositionAccount.MarketPosition != MarketPosition.Flat)          Print("Open PnL: " + PositionAccount.GetUnrealizedProfitLoss(PerformanceUnit.Points, Close[0])); } |
