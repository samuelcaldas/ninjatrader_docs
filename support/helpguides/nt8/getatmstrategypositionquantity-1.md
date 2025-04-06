



GetAtmStrategyPositionQuantity()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\getatmstrategypositionquantity.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) > [ATM Strategy Methods](atm_strategy_methods-1.htm) >  GetAtmStrategyPositionQuantity() | [Previous page](getatmstrategypositionaveragep-1.htm) [Return to chapter overview](atm_strategy_methods-1.htm) [Next page](getatmstrategyrealizedprofitlo-1.htm) |

Definition
----------

Gets the current position quantity of the specified ATM Strategy.

|  |
| --- |
| Note:  Changes to positions will not be reflected till at least the next [OnBarUpdate()](onbarupdate-1.htm) event after an order fill. |

Method Return Value
-------------------

An int value representing the quantity.

Syntax
------

GetAtmStrategyPositionQuantity(string atmStrategyId)

 

Parameters
----------

|  |  |
| --- | --- |
| atmStrategyId | The unique identifier for the ATM strategy |

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Check if flat       if (GetAtmStrategyMarketPosition("idValue") != MarketPosition.Flat)           Print("Position size is " + GetAtmStrategyPositionQuantity("id").ToString());  } |