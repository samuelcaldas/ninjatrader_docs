


Operations \> Hot Keys \> Trading with Hot Keys






















Trading with Hot Keys







| \<\< [Click to Display Table of Contents](trading_with_hot_keys.md) \>\> **Navigation:**     [Operations](operations-1.md) \> [Hot Keys](hot_key_manager-1.md) \> Trading with Hot Keys | [Previous page](working_with_hot_keys-1.md) [Return to chapter overview](hot_key_manager-1.md) [Next page](hot_list_analyzer-1.md) |
| --- | --- |




[Show/Hide Hidden Text](javascript:HMToggleExpandAll(!HMAnyToggleOpen()) "Click to open/close expanding sections")









Hot Keys can be assigned to order actions and used to place orders within NinjaTrader order entry windows. 


 


![tog_minus](tog_minus-1.gif)        [Understanding the risks in using Hot Keys for order entry](javascript:HMToggle('toggle','UnderstandingTheRisksInUsingHotKeysForOrderEntry','UnderstandingTheRisksInUsingHotKeysForOrderEntry_ICON'))




| Hot Keys are a powerful and versatile trading tool. However, misuse can lead to unexpected trades and therefore loss of money. There are several features of the Hot Keys that you should become familiar with before using them for order entry to limit the risk of unexpected order placement.   Active Window You must always be aware of the current active window when using Hot Keys for order entry. Order entry Hot Keys are window sensitive and will only execute an action to the active order entry window. Please see the "Understanding where Hot Key order entry is active" section on this page for more information on this topic.   Using the incorrect Hot Key It is imperative that you know what Hot Key performs what action. It is easy to confuse Ctrl\+B with Shift \+B which may both enter different types of orders. For this reason, we recommend printing your Hot Keys after assigning for easy reference. Please see the "How to print your Hot Keys for reference" section of the [Working with Hot Keys](working_with_hot_keys-1.md) page of the Help Guide.   When Hot Keys are inactive When you close the Hot Key window, you will see the message shown below. A modal form is a window that is always on top and always selected. (An example is the modal form message window itself.) It is important to understand that ALL Hot Keys are inactive any time a modal form window is open.   HotKeys_Inactive |
| --- |



![tog_minus](tog_minus-1.gif)        [How to enable Hot Key order entry](javascript:HMToggle('toggle','HowToEnableHotKeyOrderEntry','HowToEnableHotKeyOrderEntry_ICON'))




| To enable order entry Hot Keys From within the Control Center window select the Tools menu and then select the menu name Options. Once in the Trading category, select "Use order entry hot keys"   Assigning Hot Keys 1\. Move your mouse over the action field where you want your Hot Key assigned, "Click to record hot key" should display 2\. Left mouse click on the field to begin recording 3\. Use the keyboard to select the Hot Key combination 4\. Recording will finish as you input the hot key on your keyboard or press esc to cancel the recording   HotKeys_Orderentry |
| --- |



![tog_minus](tog_minus-1.gif)        [Understanding where Hot Key order entry is active](javascript:HMToggle('toggle','UnderstandingWhereHotKeyOrderEntryIsActive','UnderstandingWhereHotKeyOrderEntryIsActive_ICON'))




| Order Entry Hot Keys will only submit from the the active order entry window. This is important to understand, especially if using multiple order entry windows.   Order Entry Windows Below is a list of all of the order entry windows available in NinjaTrader.  [Basic Entry](basic_entry-1.md) [Chart Trader](chart_trader-1.md) [FX Pro](fx_pro-1.md) [FX Board](fx_board-1.md) [SuperDOM](superdom-1.md) [Order Ticket](order_ticket-1.md)   Identifying the Active Window The active window is usually the window that was last clicked on and has the top most view. You will also notice that the active window's close button in the upper right hand corner is red compared to an inactive window that has a grey close button.     The screen capture below to the left shows the SuperDOM with ES 06\-14 selected as the active window whereas the screen capture in the right shows the SuperDOM with NQ 06\-14 selected and active. In the left screenshot any order Hot Keys would be submitted to the ES 06\-14\. In the right screenshot any order Hot Keys would be submitted to the NQ 06\-14\.     | HotKeys_ActiveLeft | HotKeys_ActiveRight | | --- | --- | |
| --- | --- | --- |



![tog_minus](tog_minus-1.gif)        [Pre\-defined order actions](javascript:HMToggle('toggle','PredefinedOrderActions','PredefinedOrderActions_ICON')) and definitions




| HotKeys_PredefinedOrder   Pre\-defined order actions   | Buy Ask | Submits a buy limit order at the current ask price | | --- | --- | | Buy Bid | Submits a buy limit order at the current bid price | | Buy Market | Submits a buy market order | | Sell Ask | Submits a sell limit order at the current ask price | | Sell Bid | Submits a sell limit order at the current bid price | | Sell Market | Submits a sell market order | | Breakeven ATM Strategy | Modifies your stop loss order to your break\-even price for the ATM Strategy position on the active window | | Breakeven Position | Modifies any stops to your break\-even price for any open position. | | \*Cancel last Order | Cancels the last submitted order | | Close ATM Strategy | Cancels any pending orders and exits any open positions activated by an ATM Strategy | | Close Position | Closes any open position on the active order entry window | | \*Decrease Last Order Price | Decreases the price of the last submitted pending order by one tick | | \*Increase Last Order Price | Increases the price of the last submitted pending order by one tick | | \*Modify Last Order to Fill | Modifies the price of the last submitted pending order by 15 ticks past the last traded price in order to fill the order. | | Reverse | Closes your open position and any related ATM orders and submits a market order in the opposite direction to reverse your open position. |        | \*Note:  For any Hot Key that references "last order," such as "Cancel last order," last order is defined as: The last order submitted that is not a stop or target order generated by an ATM Strategy | | --- | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |



![tog_minus](tog_minus-1.gif)        [How to create custom order actions](javascript:HMToggle('toggle','HowToCreateCustomOrderActions','HowToCreateCustomOrderActions_ICON'))




| NinjaTrader allows you to create custom order actions within the Order Entry section of the Hot Key window.   HotKeys_CustomOrder   HotKeys_CustomOrderDialog   To create a Custom Order action with an associated Hot Key 1\.Select the Order Entry category of the Hot Key window.2\.Left click "add".3\.Select an Action.4\.Select an Order type (Limit offset allows you to enter the number of ticks your limit order will be  submitted away from the stop order when using a StopLimit Order type).5\.Select the price the order will be submitted at. You can choose a number of ticks above (Plus) or below (Minus) the current Ask or Bid.6\.Select the hot key to use to submit the Custom Order.7\.Press the OK button.  To remove Custom Order actions Left click the Custom Order and select "remove" |
| --- |










