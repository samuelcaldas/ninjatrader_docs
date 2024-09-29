


Operations \> Order Entry \> SuperDOM \> Modifying and Cancelling Orders






















Modifying and Canceling Orders







| \<\< [Click to Display Table of Contents](modifying_and_cancelling_orders_superdom.md) \>\> **Navigation:**     [Operations](operations.md) \> [Order Entry](order_entry.md) \> [SuperDOM](superdom.md) \> Modifying and Canceling Orders | [Previous page](submitting_orders_superdom.md) [Return to chapter overview](superdom.md) [Next page](managing_positions_superdom.md) |
| --- | --- |




[Show/Hide Hidden Text](javascript:HMToggleExpandAll(!HMAnyToggleOpen()) "Click to open/close expanding sections")











| playVideo |
| --- |
|  |



 


Orders are modified within the SuperDOM by selecting the order and clicking on the new price cell. Optionally you can also enable Single Click Order Modification of your Profit Target and Stop Loss orders within the [SuperDOM Properties](properties_superdom.md).


![tog_minus](tog_minus.gif)




| Modifying entry and exit orders Pending orders in NinjaTrader may be modified by clicking to select the order and clicking once more at the new price point. This approach is more effective than drag and drop because it eliminates the potential errors made by accidentally letting go of your mouse button and dropping an order on the wrong price. 1\.Click using your left mouse button on the order you wish to modify.2\.Once selected, you will see the cursor change to a hand from an arrow, then choose the price you are modifying the order to and click using your left mouse button to complete the modify process.  SuperDOM_28   The left mouse button is used to modify the price of limit, stop\-market, stop\-limit, and MIT orders. You can cancel out of a price modification (remove the hand cursor) by pressing the ESC key.   You can also increase or decrease the price of an order by pressing down on the right mouse button with the mouse cursor hovering over the order, which will display all orders consolidated at that price. You can then select any individual order to increase price or decrease price in one tick increments   SuperDOM_33 |
| --- |



![tog_minus](tog_minus.gif)        [How to modify the price of Stop Loss and Profit Target orders](javascript:HMToggle('toggle','HowToModifyThePriceOfStopLossAndProfitTargetOrders','HowToModifyThePriceOfStopLossAndProfitTargetOrders_ICON'))




| [playVideo](http://www.ninjatrader.com/support/movies/nt7/helpGuide/operations/orderEntry/superDOM/modifyingStopLossAndProfitTargetOrders/Modifying-Stop-Loss-And-Profit-Target-Orders.md)   Modifying Stop Loss and Profit Target orders 1\.Click with your left mouse button in the center column on the Stop Loss or Profit Target order you want to modify.2\.Once selected, you will see the cursor change to a hand from an arrow, then choose the price you are modifying the order to and click using your left mouse button to complete the modify process.  SuperDOM_29   Note:  If there are multiple orders consolidated at a price level, modifying the price will modify all orders at that price level. |
| --- |



![tog_minus](tog_minus.gif)        [How to modify the size of an order](javascript:HMToggle('toggle','HowToModifyTheSizeOfAnOrder','HowToModifyTheSizeOfAnOrder_ICON'))




| Modifying the size of an order To modify the size of an order, click on the Size Marker (marked by the green arrow in the image below) with your left mouse button    SuperDOM_30   The quantity field will appear which allows you to set the new order quantity by either entering a new quantity or using the mouse wheel to scroll the value higher or lower.  Either press the "OK" button to submit the change or the "X" button to cancel the operation.    SuperDOM_31   Order size changes are handled according to NinjaTrader's advanced FIFO optimization capabilities.     | Tips: 1\.Holding the Ctrl key \+ scrolling will increment order quantities by a value of 102\.Middle clicking on the order quantity will bring up the [Quantity Selector](quantity_selector.md) | | --- | |
| --- | --- |



![tog_minus](tog_minus.gif)        [How to modify Stop Loss and Profit Target orders with a single click](javascript:HMToggle('toggle','HowToModifyStopLossAndProfitTargetOrdersWithASingleClick','HowToModifyStopLossAndProfitTargetOrdersWithASingleClick_ICON'))




| Single Click Order Modification You have the option of enabling Single Click Order Modification for ATM Stop Loss and Profit Target orders via the [SuperDOM Properties](properties_superdom.md) dialog window accessible by right mouse click context menu. This is an advanced feature that can provide you with the clear advantage of efficiently modifying orders in fast moving markets. If you are a scalper then this option is for you.   Once enabled, to modify Stop Loss and Profit Target orders click in the center/PRICE column. Clicking in the PRICE column on the BID or above when long will adjust your Profit Target order prices, below the BID will adjust Stop Loss order prices. Clicking in the PRICE column on the ASK or below when short will adjust your Profit Target order prices, above the ASK will adjust your Stop Loss order prices.     | Left Mouse Click | Modifies the closest Stop Loss or Profit Target order | | --- | --- | | Middle Mouse Click | Modifies the second closest Stop Loss or Profit Target order | | Middle Mouse Click \+ CTRL Key | Modifies the third closest Stop Loss or Profit Target order |        | Notes: 1\.Single Click order Modification for Stops and Targets are limited to only the first 3 nearest stops and targets2\. If you have more than one active strategy working in the market, single click modification will be applied to the stops and targets associated to the selected strategy as indicated in the strategy control list (drop down list) in the lower portion of the SuperDOM window.3\. This advanced mode DOES NOT provide single click access to working orders (Entry/Exit) that reside in either the BUY or SELL columns. | | --- | |
| --- | --- | --- | --- | --- | --- | --- | --- |



![tog_minus](tog_minus.gif)        [How to cancel orders](javascript:HMToggle('toggle','HowToCancelOrders','HowToCancelOrders_ICON'))




| Cancelling Orders There are several options for cancelling orders within the NinjaTrader SuperDOM.    1\.Pressing down on the left mouse button on the black "X" will cancel all orders consolidated at the corresponding price level.2\.Pressing down on the right mouse button with the mouse cursor hovering over the order will display all orders consolidated at that price. You can then select any individual order for cancellation.3\.Pressing on the large "X" will cancel all orders on either the "BUY" side (in this example) or the sell side.  SuperDOM_32   You can also cancel "ALL" orders by right mouse clicking inside the SuperDOM and selecting the menu item Cancel All Orders. |
| --- |










