
NinjaScript > Language Reference > Strategy > ATM Strategy Methods > GetAtmStrategyUnrealizedProfitLoss()
GetAtmStrategyUnrealizedProfitLoss()
| << [Click to Display Table of Contents](getatmstrategyunrealizedprofit.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Strategy](strategy-1.md) > [ATM Strategy Methods](atm_strategy_methods-1.md) > GetAtmStrategyUnrealizedProfitLoss() | [Previous page](getatmstrategystoptargetorders-1.md) [Return to chapter overview](atm_strategy_methods-1.md) [Next page](getatmstrategyuniqueid-1.md) |
| --- | --- |
## Definition
Gets the unrealized profit and loss value of the specified ATM Strategy.
## 
## Method Return Value
A double value representing the unrealized profit and loss.
 
## Syntax
GetAtmStrategyUnrealizedProfitLoss(string atmStrategyId)
 
## 
## Parameters
| atmStrategyId | The unique identifier for the ATM strategy |
| --- | --- |
## 
## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {      Print("Unrealized PnL is " + GetAtmStrategyUnrealizedProfitLoss("id").ToString()); } |

