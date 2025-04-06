



AtmStrategyChangeEntryOrder()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\atmstrategychangeentryorder.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) > [ATM Strategy Methods](atm_strategy_methods-1.htm) >  AtmStrategyChangeEntryOrder() | [Previous page](atmstrategycancelentryorder-1.htm) [Return to chapter overview](atm_strategy_methods-1.htm) [Next page](atmstrategychangestoptarget-1.htm) |

Definition
----------

Changes the price of the specified entry order.

Method Return Value
-------------------

Returns true if the specified order was found; otherwise false.

Syntax
------

AtmStrategyChangeEntryOrder(double limitPrice, double stopPrice, string orderId)

 

Parameters
----------

|  |  |
| --- | --- |
| limitPrice | Order limit price |
| stopPrice | Order stop price |
| orderId | The unique identifier for the entry order |

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       AtmStrategyChangeEntryOrder(GetCurrentBid(), 0, "orderIdValue");  } |