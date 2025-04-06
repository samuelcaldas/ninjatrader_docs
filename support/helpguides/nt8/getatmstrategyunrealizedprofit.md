



GetAtmStrategyUnrealizedProfitLoss()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](getatmstrategyunrealizedprofit.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Strategy](strategy.htm) > [ATM Strategy Methods](atm_strategy_methods.htm) >  GetAtmStrategyUnrealizedProfitLoss() | [Previous page](getatmstrategystoptargetorders.htm) [Return to chapter overview](atm_strategy_methods.htm) [Next page](getatmstrategyuniqueid.htm) |

Definition
----------

Gets the unrealized profit and loss value of the specified ATM Strategy.

Method Return Value
-------------------

A double value representing the unrealized profit and loss.

Syntax
------

GetAtmStrategyUnrealizedProfitLoss(string atmStrategyId)

 

Parameters
----------

|  |  |
| --- | --- |
| atmStrategyId | The unique identifier for the ATM strategy |

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       Print("Unrealized PnL is " + GetAtmStrategyUnrealizedProfitLoss("id").ToString());  } |