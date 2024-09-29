


Operations \> Order Entry \> Chart Trader \> Submitting Orders






















Submitting Orders







| \<\< [Click to Display Table of Contents](submitting_orders4.md) \>\> **Navigation:**     [Operations](operations.md) \> [Order Entry](order_entry.md) \> [Chart Trader](chart_trader.md) \> Submitting Orders | [Previous page](collapsed_view.md) [Return to chapter overview](chart_trader.md) [Next page](modifying_and_cancelling_orde2.md) |
| --- | --- |




[Show/Hide Hidden Text](javascript:HMToggleExpandAll(!HMAnyToggleOpen()) "Click to open/close expanding sections")









There are several methods that can be used to submit orders directly from a chart using Chart Trader. 


![tog_minus](tog_minus.gif)




| Submitting Orders To submit an order via the Chart Trader panel:   1\. If you have more than one instrument applied to the chart, select an instrument on which to place the order via the Instrument dropdown menu   2\. Select the order time\-in\-force via the TIF dropdown menu   3\. Select an account via the Account dropdown menu   4\. Enter an order quantity in the Order Qty field   5\. If you would like to use an [Advanced Trade Management (ATM)](advanced_trade_management_atm.md) strategy with the order, set the ATM Strategy options via the ATM Strategy dropdown menu. Options in this menu include: a)None: Orders are submitted without an attached ATM Strategyb)Custom: This will open the Custom Strategy Parameters window, in which you can create and save a new ATM Strategy. c)\<Strategy Name\> \- X: A strategy template name followed by a number represents an active instance of an ATM Strategy on the chart.d)User Defined Strategy Template: Stops and targets are submitted from a predefined user template  A more thorough explanation of these concepts can be found on the [ATM Strategy Parameters](atm_strategy_parameters.md) page.   With these parameters set, you can then enter an order with any of the methods described in the sections below. |
| --- |



![tog_minus](tog_minus.gif)




| Order Options Order options will appear in the right click menu when Chart Trader is enabled. These options provide the ability to select pre\-defined order types and prices based on the location of your mouse cursor. After right mouse clicking in the chart panel to view the right click menu, left mouse click on the desired order option to submit an order. After an order has been submitted in this way, it can be moved or canceled at will before it is filled.   ChartTrader4     | Note: Available order types in the right click menu will be limited to those which will be accepted by a brokerage, based on the side of the market on which you right click. For example, in the image above, Buy Limit is not an option, since the right mouse button was clicked above the market price, and Buy Limit orders cannot be placed above the market price. Sell Stop Market and Sell Stop Limit are missing in the image above, as well, for the same reason. | | --- |      Stop\-Limit Offset When submitting a stop\-limit order, a numeric field will appear, allowing you to set the limit offset of the order (the number of ticks away at which you wish to place the Limit price of the Stop\-Limit order). Either by using your mouse scroll wheel or clicking on the up/down arrows in the numeric field, set the number of ticks and press the checkmark button to complete the order submission. For example, if you intend to place an order with a buy Stop price of 1000 and a Limit price of 1001 (4 ticks for the S\&P E\-mini contract), you would set the numeric field value to 4\. Following the same example and submitting a sell stop\-limit order, setting the numeric field value to 4 would result in a stop price of 1000 and a limit price of 999\. Pressing the "X" button will cancel the order submission operation.   The numeric field also supports negative values. When a negative value is entered, a Simulated Stop order will be place (see the "Understanding Simulated Stop Orders" section below). |
| --- | --- |



![tog_minus](tog_minus.gif)        [Understanding the Quick Buttons](javascript:HMToggle('toggle','UnderstandingTheQuickButtons','UnderstandingTheQuickButtons_ICON'))




| Quick Buttons You can quickly submit orders via the Chart Trader panel's Quick Buttons.   ChartTrader5   Button Actions   Buy Mkt \- Submits Buy order at market   Sell Mkt \- Submits Sell order at market   Buy Ask \- Submits a Buy Limit order at the Ask price   Sell Ask \- Submits a Sell Limit order at the Ask price   Buy Bid \- Submits a Buy Limit order at the Bid price   Sell Bid \- Submits a Sell Limit order at the Bid price |
| --- |



![tog_minus](tog_minus.gif)        [How to scale in or out of an active ATM strategy](javascript:HMToggle('toggle','HowToScaleInOrOutOfAnActiveATMStrategy','HowToScaleInOrOutOfAnActiveATMStrategy_ICON'))




| Scaling In or Out of an Active ATM Strategy When you have an active strategy selected in the ATM Strategy dropdown menu, any new orders submitted will scale into or out of that active strategy instance. Once filled or partially filled, existing stop loss and profit target orders will be modified to reflect the new position strategy size. You can preset a default scale in or out quantity via the "Scale Quantity" property accessible via the Chart Trader [properties](properties3.md) window. As an example, your initial strategy may call for opening a position of four contracts, but you want subsequent scale orders to be only one contract. If the Chart Trader's "Scale Quantity" property is set to a value of 1, the Qty (Quantity) field will be set to a value of 1 automatically when an active strategy is selected in the list.     | Note: For a complete understanding of order submission and subsequent actions that you can have NinjaTrader automate, see the [ATM Strategy Parameters](atm_strategy_parameters.md) page. | | --- | |
| --- | --- |



![tog_minus](tog_minus.gif)        [Understanding "One Cancels Other" (OCO) orders](javascript:HMToggle('toggle','UnderstandingoneCancelsOtherocoOrders','UnderstandingoneCancelsOtherocoOrders_ICON'))




| OCO Orders (One Cancels Other) One Cancels Other functionality ties two resting order together, so that when one is canceled or filled, the other will be canceled automatically. This can be ideal for manually placing bracket entry orders, or placing Stop Loss and Profit Target orders. Stop loss and profit target orders submitted automatically via an ATM strategy are always sent as OCO; however, you can submit entry or exit orders as OCO orders as well. Why? The market may be trading in a channel and you wish to sell at resistance or buy at support, whichever comes first by placing two limit orders at either end of the channel.    To place OCO orders, first right mouse click within the Chart Trader panel, then select the menu item OCO Order or use the default Hot Key CTRL\+Z.   All orders placed while OCO is enabled will be part of the same OCO group. Once any order of this group is filled or cancelled, all other orders that belong to this group will be cancelled. If you want each OCO order to create it's own set of stop loss and profit target brackets, ensure that the [ATM Strategy](atm_strategy.md) drop down menu is set to either Custom or an ATM Strategy template before you submit each OCO order.     | Warning: On 8\.1\.2\.1 and older, after placing two orders within the same OCO group, it is important to disable OCO functionality before submitting any other orders. If you wish to place another set of OCO orders immediately after placing an initial set, first disable, then re\-enable OCO before placing the second set of orders. This will generate a new OCO ID, rather than adding the new orders to an existing OCO group. On 8\.1\.3\.0 and newer, OCO IDs will be reset when two orders have been placed with the same OCO ID, an order an OCO is canceled or rejected, and when an order with an OCO is filled. | | --- |      Example:  Below are steps for submitting a Sell Limit and a Buy Limit order via OCO.   ChartTrader6   1\. Enable OCO   ChartTrader7   2\. Notice that there is a green OC at the top right of the chart, indicating OCO is enabled. Place a Buy Limit order    ChartTrader8   3\. If you are initiating two orders to enter a new strategy, then re\-select the strategy in the strategy selection list    ChartTrader9   4\. Place a Sell Limit order   ChartTrader10   5\. Disable OCO (it is critical that you disable OCO before submitting another OCO group) |
| --- | --- |



![tog_minus](tog_minus.gif)        [Understanding simulated stop orders](javascript:HMToggle('toggle','UnderstandingSimulatedStopOrders','UnderstandingSimulatedStopOrders_ICON'))




| Simulated Stop Orders (Simulated Order) [Simulated Stop Orders](simulated_stop_orders.md) allow you to place orders that trigger at a specific price but try to fill at a better price. To submit a Simulated Stop order, you must enable Simulated Orders via the right click menu and select the Simulated Order menu item, or use a user\-defined Hot Key. All stop orders placed while this setting is enabled will be submitted as a Simulated Stop order.     | Notes:  •This applies to entry and exit orders specifically, NOT Stop Loss orders; simulated Stop Loss orders are enabled via a [stop strategy](stop_strategy.md)•When a Simulated Stop order is displayed in the chart panel via Chart Trader, it's line and type/quantity label will be colored yellow by default to differentiate it from a Stop Limit order | | --- |      One of the powerful features of Simulated Stop orders is that you can submit a "negative limit stop\-limit" order. This means that you can place an order in which the Limit price is better than the Stop price. As an example, you may want to buy on strength indicated by a move up to a particular price. Once that occurs, you want to enter at a better price using a limit order several ticks below the stop price. Any stop\-limit order submitted with a negative limit offset automatically becomes a simulated order and will be held on your PC until the stop is triggered or canceled. |
| --- | --- |










