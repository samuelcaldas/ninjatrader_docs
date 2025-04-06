



GetAtmStrategyEntryOrderStatus()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\getatmstrategyentryorderstatus.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) > [ATM Strategy Methods](atm_strategy_methods-1.htm) >  GetAtmStrategyEntryOrderStatus() | [Previous page](atmstrategycreate-1.htm) [Return to chapter overview](atm_strategy_methods-1.htm) [Next page](getatmstrategymarketposition-1.htm) |

Definition
----------

Gets the current state of the specified entry order.

 

|  |
| --- |
| Note:  If the method can't find the specified order, an empty array is returned. |

Method Return Value
-------------------

A string[] array holding three elements that represent average fill price, filled amount and order state.

Syntax
------

GetAtmStrategyEntryOrderStatus(string orderId)

Parameters
----------

|  |  |
| --- | --- |
| orderId | The unique identifier for the entry order |

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       string[] entryOrder = GetAtmStrategyEntryOrderStatus("orderId");          // Check length to ensure that returned array holds order information       if (entryOrder.Length > 0)       {           Print("Average fill price is " + entryOrder[0].ToString());           Print("Filled amount is " + entryOrder[1].ToString());           Print("Current state is " + entryOrder[2].ToString());       }  } |