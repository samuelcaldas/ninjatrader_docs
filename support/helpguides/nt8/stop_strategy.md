



Stop Strategy

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](stop_strategy.htm) >>  **Navigation:**  [Operations](operations.htm) > [Advanced Trade Management (ATM)](advanced_trade_management_atm.htm) > [ATM Strategy](atm_strategy.htm) >  Stop Strategy | [Previous page](atm_strategy_selection_mode.htm) [Return to chapter overview](atm_strategy.htm) [Next page](auto_breakeven.htm) |

ATM Stop Strategies
-------------------

ATM Stop Strategies provide additional functionality for the stop losses placed by an ATM Strategy, including [auto-breakeven](auto_breakeven.htm), [auto-trail](auto_trail.htm), and [Simulated Stop](simulated_stop_orders.htm) orders.
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| playVideo |
|  |

A Stop Strategy is an extension of an ATM Strategy. It allows you to combine [Auto Breakeven](auto_breakeven.htm), [Auto Trail](auto_trail.htm), and [Simulated Stop](simulated_stop_orders.htm) strategies for the management and automatic adjustment of your Stop Loss orders.

When setting up an ATM Strategy, you can select either <Custom>, <None>, or any pre-defined Stop Strategy template from the Stop Strategy control list.

![ATM_16](atm_16.png)

If <Custom> or any template is selected ("Stop 1" in the image below is a template) a Stop Strategy Dialog window will appear.

![ATM_16_StopStrat](atm_16_stopstrat.png)

You can enter the appropriate values to enable any of the Stop Loss automation strategies. You can also save commonly used parameters as a Stop Strategy template.

|  |
| --- |
| Note: The parameter type of Currency or Price cannot be used for stop strategies. Tick will be used instead, which is indicated by the (t) next to Auto Breakeven and Auto Trail in the stop strategy parameters. |