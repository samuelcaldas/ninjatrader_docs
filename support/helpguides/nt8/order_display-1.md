


Operations \> Order Entry \> SuperDOM \> Order Display






















Order Display







| \<\< [Click to Display Table of Contents](order_display.md) \>\> **Navigation:**     [Operations](operations-1.md) \> [Order Entry](order_entry-1.md) \> [SuperDOM](superdom-1.md) \> Order Display | [Previous page](static_vs_dynamic_price_ladder-1.md) [Return to chapter overview](superdom-1.md) [Next page](submitting_orders_superdom-1.md) |
| --- | --- |
















| playVideo |
| --- |
|  |



 


Orders are displayed in a highly visual manner. Different order types and order objectives (stop loss or profit target orders) are uniquely color coded.


![tog_minus](tog_minus-1.gif)        [Understanding how orders are displayed](javascript:HMToggle('toggle','UnderstandingHowOrdersAreDisplayed','UnderstandingHowOrdersAreDisplayed_ICON'))




| Order Display All orders are displayed by coloring a cell or group of cells within the Price Ladder     | 1\) Limit Order | Default color is cyan with the text "LMT" | | --- | --- | | 2\) Stop\-Limit Order | Default color is violet with text "SLM" | | 3\) MIT Order | Default color is spring green with text "MIT" | | 4\) Stop\-Market Order | Default color is pink with text "STP" | | 5\) Simulated Stop Order | Default color is yellow with text "SLM" or "STP" |      The image below shows a working limit, stop\-market, and stop\-limit order for one contract each.   SuperDOM_9     | Note: Orders will only display for the selected Account and Instrument. | | --- | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |



![tog_minus](tog_minus-1.gif)        [Understanding how the quantity of an order are displayed](javascript:HMToggle('toggle','UnderstandingHowTheQuantityOfAnOrderAreDisplayed','UnderstandingHowTheQuantityOfAnOrderAreDisplayed_ICON'))




| Size Marker There is also an associated Size Marker which displays the remaining contracts to be filled for the order(s) at the corresponding price. In the image blow, three contracts are remaining to be filled and are working at a price of 1963\.25   SuperDOM_11 |
| --- |



![tog_minus](tog_minus-1.gif)        [Understanding how multiple orders at the same price are displayed](javascript:HMToggle('toggle','UnderstandingHowMultipleOrdersAtTheSamePriceAreDisplayed','UnderstandingHowMultipleOrdersAtTheSamePriceAreDisplayed_ICON'))




| Consolidated Order Display The SuperDOM will consolidate the display of all orders resting at the same price and mark an "s" within the Size Marker display to indicate that there are multiple orders stacked at that price. The Size Marker then indicates the cumulative remaining contracts for all orders resting at that price. The image blow depicts a consolidated display of two limit orders for 1 contract each.   SuperDOM_12   By moving your mouse cursor over the order (cyan colored cell) and pressing down on your right mouse button, you will see a context menu listing all individual orders consolidated at the corresponding price and any relevant actions that you can perform on those orders.   SuperDOM_13 |
| --- |



![tog_minus](tog_minus-1.gif)        [Understanding how Stop Loss and Profit Target orders are displayed](javascript:HMToggle('toggle','UnderstandingHowStopLossAndProfitTargetOrdersAreDisplayed','UnderstandingHowStopLossAndProfitTargetOrdersAreDisplayed_ICON'))




| Stop Loss and Profit Target display Orders submitted as Stop Loss and Profit Target orders are uniquely displayed by coloring all three cells in the price row where the order(s) are working. This makes it very easy to visualize your stop and profit objectives relative to the current market. All other orders are displayed by coloring a single cell in either the BUY or SELL column.   The two below displays an image of a Stop Loss and Profit Target pair, notice that the Size Marker displays the number of contracts remaining to be filled, and that they are sell orders since they are displayed on the sell side of the Price Ladder. Also note the brown colored cell at price level 1974\.25, this represents the average entry price for the open position.     SuperDOM_10 |
| --- |



![tog_minus](tog_minus-1.gif)        [How to view out of range Stop Loss and Profit Target orders](javascript:HMToggle('toggle','HowToViewOutOfRangeStopLossAndProfitTargetOrders','HowToViewOutOfRangeStopLossAndProfitTargetOrders_ICON'))




| Displaying Stop Loss and Profit Target orders outside the visible range There may be times when your Stop Loss or Profit Target orders are outside of the visible price range of the SuperDOM price ladder. You can easily bring these orders in range by first disabling Auto Center from the SuperDOM right click menu, and then clicking with your middle mouse button in the Price column.   As long as Auto Center is disabled, clicking on the bid or above with your middle mouse button will bring into visible range the first stop loss or profit target order above the highest displayed price of the price ladder. Clicking below the bid with your middle mouse button will bring into visible range the first stop loss or profit target order below the lowest displayed price of the Price Ladder.   You can then quickly navigate back to the last traded price by either re\-enabling Auto Center, or pressing the C button to manually re\-center the price.     | Note: This function only works if "Single Click Order Modification" is set to False in the [SuperDOM Properties](properties_superdom-1.md) window. If set to true, middle click will instantly modify your Stop Loss or Profit Target orders.  Please see the help topic on [Modifying and Cancelling Orders](modifying_and_cancelling_orders_superdom-1.md) for more information on that feature | | --- | |
| --- | --- |










