


NinjaScript \> Language Reference \> Strategy \> ATM Strategy Methods \> GetAtmStrategyMarketPosition()






















GetAtmStrategyMarketPosition()







| \<\< [Click to Display Table of Contents](getatmstrategymarketposition.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [ATM Strategy Methods](atm_strategy_methods.md) \> GetAtmStrategyMarketPosition() | [Previous page](getatmstrategyentryorderstatus.md) [Return to chapter overview](atm_strategy_methods.md) [Next page](getatmstrategypositionaveragep.md) |
| --- | --- |











## Definition


Gets the current market position of the specified ATM Strategy.


 




| Notes:   1\. Changes to positions will not be reflected till at least the next [OnBarUpdate()](onbarupdate.md) event after an order fill. 2\. If the ATM Strategy does not exist then MarketPosition.Flat returns  3\. Please note this provides access to the current ATM strategy position, which should not be confused with the NinjaScript strategy position or account position. For more information please see the [Using ATM Strategies](using_atm_strategies.md) section. |
| --- |



 


 


## Method Return Value


MarketPosition.Flat


MarketPosition.Long


MarketPosition.Short


## 


## Syntax


GetAtmStrategyMarketPosition(string atmStrategyId)


## 


## Parameters




| atmStrategyId | The unique identifier for the ATM strategy |
| --- | --- |



## 


## 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {      // Check if flat      if (GetAtmStrategyMarketPosition("id") \=\= MarketPosition.Flat)          Print("ATM Strategy position is currently flat"); } |









