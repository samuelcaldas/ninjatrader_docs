


Operations \> Order Entry \> SuperDOM \> Submitting Orders






















Submitting Orders







| \<\< [Click to Display Table of Contents](submitting_orders_superdom.md) \>\> **Navigation:**     [Operations](operations.md) \> [Order Entry](order_entry.md) \> [SuperDOM](superdom.md) \> Submitting Orders | [Previous page](order_display.md) [Return to chapter overview](superdom.md) [Next page](modifying_and_cancelling_orders_superdom.md) |
| --- | --- |




[Show/Hide Hidden Text](javascript:HMToggleExpandAll(!HMAnyToggleOpen()) "Click to open/close expanding sections")









## 




| playVideo |
| --- |
|  |



 


Orders are submitted in the NinjaTrader SuperDOM using different combinations of mouse clicks and keyboard keys. Limit, stop\-market, stop\-limit, and MIT orders are placed with the following conventions: 


 


## Left Mouse Button


•Limit orders are placed with the left mouse button 

•MIT orders are placed with the Ctrl key \+ left mouse button

 


You can optionally reconfigure these default settings to allow for the left click to submit MIT orders from the [SuperDOM Properties](properties_superdom.md):


 


• Check "Left mouse button is MIT" 

 


With this configuration, the left mouse button will now submit MIT orders, and Ctrl \+ Left mouse button will submit Limit orders


 


## Middle Mouse Button (Scroll Wheel)


•Stop\-market orders are placed with the Ctrl key and middle mouse button

•Stop\-limit orders are placed with the middle mouse button

 


Or you configure the Middle mouse button to submit stop\-market orders from the [SuperDOM Properties](properties_superdom.md):


 


•Check "Middle mouse button is stop market"

 


With this configuration, the middle mouse button will now submit stop\-market orders, and Ctrl \+ middle mouse button will submit stop\-limit orders


 




| Note: It is highly recommended that you review the [Advanced Trade Management (ATM)](advanced_trade_management_atm.md) section for a complete understanding of order submission and subsequent actions that you can have NinjaTrader automate. |
| --- |



![tog_minus](tog_minus.gif)




| How to Select an Instrument There are multiple ways to select an Instrument in the SuperDOM window.     •Select the Instrument Selector to open a list of recently used instruments or instruments contained in a predefined list    •With the SuperDOM window selected begin typing the instrument symbol directly on the keyboard. Typing will trigger the Overlay Instrument Selector.  For more Information on instrument selection and management please see [Instruments](instruments.md) section of the Help Guide.   How to Select an Account A list of all connected accounts will be listed in the Account Selector drop down list. To change the account select the account you wish to trade through via this drop down list. |
| --- |



![tog_minus](tog_minus.gif)        [Understanding order settings](javascript:HMToggle('toggle','UnderstandingOrderSettings','UnderstandingOrderSettings_ICON'))




| To submit an Order 1\.Set the order "Quantity" field ([info](quantity_selector.md))2\.Set the "TIF" (Time in Force) field ([info](tif_selector.md))3\.Set the "ATM Strategy" option ([info](atm_strategy_parameters.md))4\.Enter an order with any of the methods described below |
| --- |



![tog_minus](tog_minus.gif)        [How to submit a limit order](javascript:HMToggle('toggle','HowToSubmitALimitOrder','HowToSubmitALimitOrder_ICON'))




| Limit Orders To submit a limit order, select either the Buy column for buy orders or the Sell column for sell orders and press down on your 1 left mouse button in the cell that corresponds to the price you wish the limit order to be submitted at.    SuperDOM_15   Clicking at the location marked in the image above would submit a buy limit order at the price 1965\.00\. |
| --- |



![tog_minus](tog_minus.gif)        [How to submit a stop\-market order](javascript:HMToggle('toggle','HowToSubmitAStopMarketOrder','HowToSubmitAStopMarketOrder_ICON'))




| Stop\-Market To submit a stop\-market order, select either the Buy column for buy orders or the Sell column for sell orders and press down on your 2 middle mouse button (scroll wheel) while holding the CTRL key down in the cell that corresponds to the price you wish the stop\-market order to be submitted at.   SuperDOM_16   In the image above, holding down the CTRL key on your keyboard and middle mouse clicking on the price point would enter a buy stop\-market order at 1967\.50\. |
| --- |



![tog_minus](tog_minus.gif)        [How to submit a stop\-limit order](javascript:HMToggle('toggle','HowToSubmitAStopLimitOrder','HowToSubmitAStopLimitOrder_ICON'))




| Stop\-Limit Order To submit a stop\-limit order, select either the Buy column for buy orders or the Sell column for sell orders and press down on your 3 middle mouse button (scroll wheel) in the cell that corresponds to the price you wish the stop limit order to be submitted at.   A numeric field (image lower right) will appear that represents the number of ticks away you wish the limit price of the stop\-limit order to be placed at. Either by using your mouse scroll wheel or clicking on the up/down arrows in the numeric field, set the number of ticks and press the "check mark" button to complete the order submission. Pressing the "x" button will cancel the order submission operation.    For example, if you intend to have an order with a stop price of 1967\.50 and a limit price of 1968\.50 (4 ticks spread for the SP Emini contract) you would set the numeric field value to 4\. Following the same example submitting a sell stop\-limit, setting the numeric field value to 1 would result in a stop price of 1967\.50 and a limit price of 1967\.25\.   SuperDOM_18SuperDOM_17     Negative Stop\-Limit Offset You will notice that there are also negative values. By selecting a negative value, you automatically submit a Simulated Stop order, which is indicated by a yellow order flag. This allows you to place orders that trigger at a break out price but try to fill you at a better price.    SuperDOM_26     Single Click Stop\-Limit Orders If you generally place stop\-limit orders using the same offset between limit and stop price, you can enable single click submission of stop\-limit orders by setting the "Stop\-limit offset" property to an integer value via the [SuperDOM properties](properties_superdom.md). By default, this setting is set to "Off" which forces the numeric field (image above right) to display. Setting this property to a value of 1 would instantly place a stop\-limit order with a stop price of X and a limit price of X \+ 1 for buy orders or X \- 1 for sell orders. |
| --- |



![tog_minus](tog_minus.gif)        [How to submit an MIT (Market If Touched) order](javascript:HMToggle('toggle','HowToSubmitAnMitmarketIfTouchedOrder','HowToSubmitAnMitmarketIfTouchedOrder_ICON'))




| MIT Orders To submit a MIT order, select either the Buy column for buy orders or the Sell column for sell orders and press down on your 4 left mouse button while holding the CTRL key down in the cell that corresponds to the price you wish the MIT to be submitted at.   SuperDOM_19   In the image above, holding down the CTRL key on your keyboard and left mouse clicking on the price point would enter a buy MIT order at 1965\.00 |
| --- |



![tog_minus](tog_minus.gif)        [Understanding the OCO order (one cancels other) function](javascript:HMToggle('toggle','UnderstandingTheOcoOrderoneCancelsOtherFunction','UnderstandingTheOcoOrderoneCancelsOtherFunction_ICON'))




| OCO Orders (One Cancels Other) Stop loss and profit target orders (submitted automatically via an ATM strategy) are always sent as OCO, however, you can submit entry or exit orders as OCO orders as well. Why? The market may be trading in a channel and you wish to sell at resistance or buy at support, whichever comes first by placing two limit orders at either end of the channel. To place OCO orders, via the right mouse click context menu select the menu name "OCO Order" or use the shortcut key Ctrl \+ Z.   SuperDOM_20   The "oc" (OCO indicator) will light up green. All orders placed while this indicator is lit will be part of the same OCO group. Once any order of this group is either filled or cancelled, all other orders that belong to this group will be cancelled.    SuperDOM_21   If you want each OCO order to create it's own set of Stop Loss and Profit Target orders ensure that the ATM Strategy control list is set to either \<Custom\> or a strategy template name before you submit each OCO order.   After you have placed your orders, it is advised to disable the OCO function via the right click menu, or use the short cut key CTRL\+Z.     | Warning: On 8\.1\.2\.1 and older, after placing two orders within the same OCO group, it is important to disable OCO functionality before submitting any other orders. If you wish to place another set of OCO orders immediately after placing an initial set, first disable, then re\-enable OCO before placing the second set of orders. This will generate a new OCO ID, rather than adding the new orders to an existing OCO group. On 8\.1\.3\.0 and newer, OCO IDs will be reset when two orders have been placed with the same OCO ID, an order an OCO is canceled or rejected, and when an order with an OCO is filled. | | --- |      Break Out/Fade Entry Example One of the great features of NinjaTrader is its ability to submit two entry orders, one of which will cancel if the other is filled.   You can accomplish a breakout/breakdown approach by:   •Right click in the SuperDOM and select the menu item "OCO Order" to enable the OCO function •For your first order, select the desired option from the "ATM Strategy" drop down list •Submit your stop order to buy above the market •For your second order, select the desired option from the "ATM Strategy" drop down list •Submit your stop order to sell below the market•CRITICAL: Right click in the SuperDOM and select the menu item OCO Order to disable OCO from being applied to subsequent orders.    SuperDOM_22   For a market fade approach just substitute limit orders for stop orders.    Using the OCO Function to Bracket an Open Position If you have an open position without an ATM strategy attached, and you wish to add limit and stop orders to protect the position follow these steps:   •Set the ATM strategy in the ATM Strategy selection drop down box to a value of \<None\> •Right click in the SuperDOM and enable OCO order placement by selecting the menu name "OCO Order"•Then place a limit order where you want to exit at a profit•Then place a stop order where you want to exit at a loss•Lastly, right click again and select the menu item "OCO Order" to disable the OCO order placement  SuperDOM_23   Now you have a target and a stop placed protecting your open position, and when one of these orders is filled the other will be cancelled automatically. |
| --- | --- |



![tog_minus](tog_minus.gif)        [How to submit simulated stop orders (Simulated Order)](javascript:HMToggle('toggle','HowToSubmitSimulatedStopOrderssimulatedOrder','HowToSubmitSimulatedStopOrderssimulatedOrder_ICON'))




| Simulated Stop Orders To submit a Simulated Stop Order (entry and exit NOT stop loss; simulated stop loss orders are enabled via an ATM stop strategy) you must enable Simulated Order mode via the right mouse click context menu by selecting the "Simulated Order" menu item or use the shortcut key Ctrl \+ A. The "so" (Simulated Order indicator) will light up green. All stop orders placed while this indicator is lit will be submitted as a Simulated Stop Orders.    SuperDOM_24   SuperDOM_25   One of the powerful features of Simulated Stop Orders is that you can submit a "negative limit stop\-limit" order. This means that you can place an order where the limit price is better than the stop price. As an example, you may want to buy on strength indicated by a move up to a particular price. Once that occurs, you want to enter at a better price using a limit order several ticks below (if you are buying) the stop price.    For more information please visit the [Simulated Stop Orders](simulated_stop_orders.md) section of the user Help Guide. |
| --- |



![tog_minus](tog_minus.gif)        [How to submit orders with the Quick Buttons](javascript:HMToggle('toggle','HowToSubmitOrdersWithTheQuickButtons','HowToSubmitOrdersWithTheQuickButtons_ICON'))




| Quick Buttons Setting “Show Quick Buttons” to true in the [SuperDOM Properties](properties_superdom.md) enables: Ask and Bid buttons in the Buy and Sell Columns, a \+Target (add target) button, and a \-Target (remove target) button.   SuperDOM_27   When enabled, pressing an "Ask" button with the left mouse button will submit a limit order at the ask price, pressing a "Bid" button will submit a limit order at the bid price.   For more information on adding and removing targets please view the [Managing Positions](managing_positions_superdom.md) section of the user help guide. |
| --- |










