
NinjaScript \> Language Reference \> Strategy \> ATM Strategy Methods \> GetAtmStrategyUnrealizedProfitLoss()
GetAtmStrategyUnrealizedProfitLoss()
| \<\< [Click to Display Table of Contents](getatmstrategyunrealizedprofit.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [ATM Strategy Methods](atm_strategy_methods.md) \> GetAtmStrategyUnrealizedProfitLoss() | [Previous page](getatmstrategystoptargetorders.md) [Return to chapter overview](atm_strategy_methods.md) [Next page](getatmstrategyuniqueid.md) |
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
| protected override void OnBarUpdate() {      Print("Unrealized PnL is " \+ GetAtmStrategyUnrealizedProfitLoss("id").ToString()); } |

