


Operations \> Order Entry \> FIFO Optimization






















FIFO Optimization







| \<\< [Click to Display Table of Contents](fifo_optimization.md) \>\> **Navigation:**     [Operations](operations-1.md) \> [Order Entry](order_entry-1.md) \> FIFO Optimization | [Previous page](order_state_definitions-1.md) [Return to chapter overview](order_entry-1.md) [Next page](working_with_forex-1.md) |
| --- | --- |














All of the NinjaTrader order entry interfaces preserve FIFO (First In First Out) status with the exchanges when possible.


![tog_minus](tog_minus-1.gif)        [Why is FIFO important?](javascript:HMToggle('toggle','WhyIsFifoImportant','WhyIsFifoImportant_ICON'))




| FIFO is important since getting your orders filled is dependant on a FIFO algorithm which basically means orders submitted ahead of yours at your order's price level will get filled ahead of you. Think of it like a long line at the grocery store. You are checked out only when those in line ahead of you have been checked out. NinjaTrader preserves your place in line when possible giving you the best possible advantage of getting your orders filled. |
| --- |



![tog_minus](tog_minus-1.gif)        [How does NinjaTrader preserve FIFO?](javascript:HMToggle('toggle','HowDoesproductnamePreserveFifo','HowDoesproductnamePreserveFifo_ICON'))




| All NinjaTrader order entry interfaces simplify the visualization of orders. Let's say that you have a buy limit order for 1 contract, and then want to modify this order from 1 contract to 2 contracts. Most other programs will simply change this order directly, but behind the scenes (at the broker's order servers) what is really happening is that the original order is cancelled (removed from the line) and then a new order for 2 contracts is submitted which then goes to the back of the line putting you at a disadvantage. Imagine waiting in the grocery store check out line for ten minutes. You forgot to get some bread, you leave the line in order to get the bread that you wanted (changing your order) and upon your return to the check out line, you have to start at the back of the line and wait all over again! With NinjaTrader, when you modify the order from 1 contracts to 2 contracts, an additional order for 1 contract is submitted. Now you have the original order for 1 contract waiting in the middle of the line somewhere and the new order for 1 contract at the back of the line. Your original order is not penalized and you maintain your position in line. The opposite is true for decreasing an order size. Although there are two working orders NinjaTrader consolidates the display so it looks as if there is only one order working. You decide to decrease the order size from 2 contracts back to 1\. NinjaTrader will modify the newest orders first and the oldest orders last in order to preserve your FIFO status. Following our example, the second order that was placed would be cancelled and you would be left with the original order for 1 contract with its maintained position in the order queue. |
| --- |



![tog_minus](tog_minus-1.gif)        [Exceptions to FIFO](javascript:HMToggle('toggle','ExceptionsToFifo','ExceptionsToFifo_ICON'))




| NinjaTrader will attempt to use FIFO when possible, but there are a few scenarios where this would not be possible.   Non\-Aggregated Order Displays Most of NinjaTrader's order interfaces (Basic Entry, SuperDOM, Chart Trader, etc) will have an aggregated order display to consolidate orders submitted/modified at the same price level and have also been designed for FIFO optimization.  However any order feature that uses a non\-aggregated order display, such as the [Orders Tab](orders_tab-1.md) of the Control Center or Account Data window, modifications will not be able to maintain FIFO optimization and will modify the order directly via a cancel/replace operation.  If FIFO is important for your style of trading, you will want to consider making modifications from an aggregated order display feature, rather than directly from grid of the Orders Tab.   Quantity Modification for Stocks NinjaTrader's features which support stocks will have an option to set how order modifications are handled when trading stocks.  You will find this setting by right clicking on the [Order Entry](order_entry-1.md) feature, selecting Properties, and will be called Quantify modification for stocks with the following options:     | Increase quantity of preexisting order | When modifying quantity or price on an aggregated order NinjaTrader will modify the order with the least time in the market via a cancel/replace operation. | | --- | --- | | Submit new order for additional quantity | Orders will use FIFO optimization as normal |      If the account you are trading with your stock brokerage charges you commission per individual share, you will want to consider using "Increase quantity of preexisting order" setting.  While you will lose the FIFO optimization, order modifications will not incur an additional commission charge as a result of the additional orders that would otherwise be placed in response to your modification request.   Futures, Forex, and CFD's will always use FIFO optimization on aggregated orders. |
| --- | --- | --- | --- | --- |










