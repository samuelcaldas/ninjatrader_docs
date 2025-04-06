



GetAtmStrategyRealizedProfitLoss()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\getatmstrategyrealizedprofitlo.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) > [ATM Strategy Methods](atm_strategy_methods-1.htm) >  GetAtmStrategyRealizedProfitLoss() | [Previous page](getatmstrategypositionquantity-1.htm) [Return to chapter overview](atm_strategy_methods-1.htm) [Next page](getatmstrategystoptargetorders-1.htm) |

Definition
----------

Gets the realized profit and loss value of the specified ATM Strategy.

Method Return Value
-------------------

A double value representing the realized profit and loss.

Syntax
------

GetAtmStrategyRealizedProfitLoss(string atmStrategyId)

 

Parameters
----------

|  |  |
| --- | --- |
| atmStrategyId | The unique identifier for the ATM strategy |

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       Print("PnL is " + GetAtmStrategyRealizedProfitLoss("id").ToString());  } |