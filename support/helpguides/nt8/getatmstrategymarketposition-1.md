



GetAtmStrategyMarketPosition()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\getatmstrategymarketposition.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) > [ATM Strategy Methods](atm_strategy_methods-1.htm) >  GetAtmStrategyMarketPosition() | [Previous page](getatmstrategyentryorderstatus-1.htm) [Return to chapter overview](atm_strategy_methods-1.htm) [Next page](getatmstrategypositionaveragep-1.htm) |

Definition
----------

Gets the current market position of the specified ATM Strategy.

 

|  |
| --- |
| Notes:    1. Changes to positions will not be reflected till at least the next [OnBarUpdate()](onbarupdate-1.htm) event after an order fill.  2. If the ATM Strategy does not exist then MarketPosition.Flat returns  3. Please note this provides access to the current ATM strategy position, which should not be confused with the NinjaScript strategy position or account position. For more information please see the [Using ATM Strategies](using_atm_strategies-1.htm) section. |

Method Return Value
-------------------

MarketPosition.Flat

MarketPosition.Long

MarketPosition.Short

Syntax
------

GetAtmStrategyMarketPosition(string atmStrategyId)

Parameters
----------

|  |  |
| --- | --- |
| atmStrategyId | The unique identifier for the ATM strategy |

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Check if flat       if (GetAtmStrategyMarketPosition("id") == MarketPosition.Flat)           Print("ATM Strategy position is currently flat");  } |