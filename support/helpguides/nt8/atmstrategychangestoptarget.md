


NinjaScript \> Language Reference \> Strategy \> ATM Strategy Methods \> AtmStrategyChangeStopTarget()






















AtmStrategyChangeStopTarget()







| \<\< [Click to Display Table of Contents](atmstrategychangestoptarget.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [ATM Strategy Methods](atm_strategy_methods.md) \> AtmStrategyChangeStopTarget() | [Previous page](atmstrategychangeentryorder.md) [Return to chapter overview](atm_strategy_methods.md) [Next page](atmstrategyclose.md) |
| --- | --- |











## Definition


Changes the price of the specified order of the specified ATM strategy.


 


## Method Return Value


Returns true if the specified order was found; otherwise false.


## 


## Syntax


AtmStrategyChangeStopTarget(double limitPrice, double stopPrice, string orderName, string atmStrategyId)


## 


## Parameters




| limitPrice | Order limit price |
| --- | --- |
| stopPrice | Order stop price |
| orderName | The order name such as "Stop1" or "Target2" |
| atmStrategyId | The unique identifier for the ATM strategy |



 


 


## 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {      AtmStrategyChangeStopTarget(0, SMA(10)\[0], "Stop1", "AtmIdValue"); } |









