


Operations \> Advanced Trade Management (ATM) \> ATM Strategy \> Stop Strategy \> Auto Trail






















Auto Trail







| \<\< [Click to Display Table of Contents](auto_trail.md) \>\> **Navigation:**     [Operations](operations.md) \> [Advanced Trade Management (ATM)](advanced_trade_management_atm.md) \> [ATM Strategy](atm_strategy.md) \> [Stop Strategy](stop_strategy.md) \> Auto Trail | [Previous page](auto_breakeven.md) [Return to chapter overview](stop_strategy.md) [Next page](manage_atm_strategy_templates.md) |
| --- | --- |




[Show/Hide Hidden Text](javascript:HMToggleExpandAll(!HMAnyToggleOpen()) "Click to open/close expanding sections")









Auto Trail is a powerful stop strategy that allows you to be more liberal with your Stop Loss at the early stage of your trade and tighten your Stop Loss as your profits in your trade increase.


 


![tog_minus](tog_minus.gif)




| Auto Trail Parameters   | Stop Loss | Sets the value of the Stop Loss order as an offset behind the Profit Trigger/Frequency | | --- | --- | | Profit Trigger | Sets the amount of profit required to trigger the initial Stop Loss adjustment for the step | | Frequency | Sets the value of how frequent the Stop Loss order is adjusted after the Profit Trigger |      ATM_19   There are 3 available steps for Auto Trail parameters. Each step can have unique parameters providing you with the flexibility to tighten your Stop Loss automatically as your profits increase. Auto Trail can be set before entering a position as part of a Stop Strategy. You can also enable or disable it on a working Stop Loss order.   If you move your mouse over an active Stop Loss order in the buy cell for a buy order or sell cell for a sell order and press down on your right mouse button, you will see a menu of all working orders. Each working order menu has a sub menu that displays any applicable strategies that can be enabled or disabled. In the image below, you can see that Auto Trail is currently enabled. By selecting the "Enable" menu item, you can enable or in this example disable the Auto Trail. You can change the parameters by selecting the "Auto Trail Properties" menu item when Auto Trail is disabled.   ATM_20 |
| --- | --- | --- | --- | --- | --- | --- |



![tog_minus](tog_minus.gif)        [Auto Trail Examples](javascript:HMToggle('toggle','AutoTrailExamples','AutoTrailExamples_ICON'))




| Auto Trail Example \#1: The settings in the image below are saying:   1\."Once our trade has 4 ticks in profit..."  2\."...move our Stop Loss back 6 ticks..."3\."...and also move it up for every additional 2 ticks in profit."  ATM_21   Average Entry \- 1000 Long (SP Emini contract)   The market moves up to 1001 and the Auto Trail is triggered (Average Entry \+ Profit Trigger \= 1000 \+ 4 ticks \= 1001\) and the Stop Loss is adjusted to 999\.50 (1001 \- Stop Loss \= 1001 \- 6 ticks \= 999\.50\). For every additional 2 ticks (Frequency of 2 ticks) the Stop Loss will be adjusted by 2 ticks.   Auto Trail Example \#2 building on top of Example \#1: The settings in the image below are saying:   Step 1 1\."Once our trade has 4 ticks in profit..."2\."...move our Stop Loss back 6 ticks..."3\."...and also move it up for every additional 2 ticks in profit."Step 2 4\."Then once our trade has 10 ticks in profit...5\."...tighten and move our Stop Loss back 3 ticks..."6\."...and increase the rate at which the Stop Loss is adjusted and move it up for every additional 1 tick in profit."  ATM_22   Average Entry \- 1000 Long (SP Emini contract)   The market moves up to 1001 and the Auto Trail is triggered (Average Entry \+ Profit Trigger \= 1000 \+ 4 ticks \= 1001\) and the Stop Loss is adjusted to 999\.50 (1001 \- Stop Loss \= 1001 \- 6 ticks \= 999\.50\). For every additional 2 ticks (Frequency of 2 ticks) the Stop Loss will be adjusted by 2 ticks (same as Example \#1\). Then the market moves to 1002\.50 and the 2nd step of the Auto Trail strategy is triggered and the Stop Loss is adjusted to 1001\.75 and moves up by 1 tick with every additional tick in profit. |
| --- |










