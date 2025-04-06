



GetAtmStrategyPositionAveragePrice()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](getatmstrategypositionaveragep.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Strategy](strategy.htm) > [ATM Strategy Methods](atm_strategy_methods.htm) >  GetAtmStrategyPositionAveragePrice() | [Previous page](getatmstrategymarketposition.htm) [Return to chapter overview](atm_strategy_methods.htm) [Next page](getatmstrategypositionquantity.htm) |

Definition
----------

Gets the current position's average price of the specified ATM Strategy.

|  |
| --- |
| Note:  Changes to positions will not be reflected till at least the next [OnBarUpdate()](onbarupdate.htm) event after an order fill. |

Method Return Value
-------------------

A double value representing the average price.

Syntax
------

GetAtmStrategyPositionAveragePrice(string atmStrategyId)

 

Parameters
----------

|  |  |
| --- | --- |
| atmStrategyId | The unique identifier for the ATM strategy |

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Check if flat       if (GetAtmStrategyMarketPosition("id") != MarketPosition.Flat)            Print("Average price is " + GetAtmStrategyPositionAveragePrice("id").ToString());   } |