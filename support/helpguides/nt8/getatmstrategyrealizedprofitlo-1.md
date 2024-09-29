


NinjaScript \> Language Reference \> Strategy \> ATM Strategy Methods \> GetAtmStrategyRealizedProfitLoss()






















GetAtmStrategyRealizedProfitLoss()







| \<\< [Click to Display Table of Contents](getatmstrategyrealizedprofitlo.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [ATM Strategy Methods](atm_strategy_methods-1.md) \> GetAtmStrategyRealizedProfitLoss() | [Previous page](getatmstrategypositionquantity-1.md) [Return to chapter overview](atm_strategy_methods-1.md) [Next page](getatmstrategystoptargetorders-1.md) |
| --- | --- |











## Definition


Gets the realized profit and loss value of the specified ATM Strategy.


 


## Method Return Value


A double value representing the realized profit and loss.


## 


## Syntax


GetAtmStrategyRealizedProfitLoss(string atmStrategyId)


 


## 


## Parameters




| atmStrategyId | The unique identifier for the ATM strategy |
| --- | --- |



## 


## 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {      Print("PnL is " \+ GetAtmStrategyRealizedProfitLoss("id").ToString()); } |









