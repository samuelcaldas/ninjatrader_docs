


NinjaScript \> Language Reference \> Strategy \> ATM Strategy Methods \> GetAtmStrategyStopTargetOrderStatus()






















GetAtmStrategyStopTargetOrderStatus()







| \<\< [Click to Display Table of Contents](getatmstrategystoptargetorders.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> [ATM Strategy Methods](atm_strategy_methods-1.md) \> GetAtmStrategyStopTargetOrderStatus() | [Previous page](getatmstrategyrealizedprofitlo-1.md) [Return to chapter overview](atm_strategy_methods-1.md) [Next page](getatmstrategyunrealizedprofit-1.md) |
| --- | --- |











## Definition


Gets the current order state(s) of the specified stop or target order of a still\-active ATM strategy.


 




| Notes:   1\.If the method can't find the specified order(s), an empty array is returned.2\.A specified stop or target within an ATM strategy can actually hold multiple orders. For example, if your ATM strategy submits a stop and target and you receive multiple partial fills on entry with a delay of a few seconds or more between entry fills, the ATM strategy will submit stop and target orders for each partial fill all with the same price and order type. |
| --- |



 


## Method Return Value


A string\[,] multi\-dimensional array holding three dimensions that represent average fill price, filled amount and [order state](order_state_definitions-1.md). The length (number of elements) represents the number of orders that represent the specified name.


## 


## Syntax


GetAtmStrategyStopTargetOrderStatus(string orderName, string atmStrategyId)


 


## 


## Parameters




| orderName | The order name such as "Stop1" or "Target2" |
| --- | --- |
| atmStrategyId | The unique identifier for the ATM strategy |



 


 


## 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {      string\[,] orders \= GetAtmStrategyStopTargetOrderStatus("Target1", "idValue");        // Check length to ensure that returned array holds order information      if (orders.Length \> 0)      {          for (int i \= 0; i \< orders.GetLength(0); i\+\+)          {                Print("Average fill price is " \+ orders\[i, 0].ToString());                Print("Filled amount is " \+ orders\[i, 1].ToString());                Print("Current state is " \+ orders\[i, 2].ToString());          }      } } |









