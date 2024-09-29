


Operations \> Order Entry \> SuperDOM \> Price Ladder Display






















Price Ladder Display







| \<\< [Click to Display Table of Contents](price_ladder_display.md) \>\> **Navigation:**     [Operations](operations.md) \> [Order Entry](order_entry.md) \> [SuperDOM](superdom.md) \> Price Ladder Display | [Previous page](superdom.md) [Return to chapter overview](superdom.md) [Next page](static_vs_dynamic_price_ladder.md) |
| --- | --- |














The SuperDOM is designed to allow the trader to view market prices, market depth, current inside market, indicator price levels, PnL, current positions, and pending orders at a glance.  The unique display of each item within the SuperDOM Price Ladder display makes managing open orders and positions easy and efficient.


 


To open the SuperDOM Window, select the New menu from the NinjaTrader Control Center. Then left mouse click on the menu item SuperDOM (Static) or SuperDOM (Dynamic) (Please see [Static vs Dynamic Price Ladder Display](static_vs_dynamic_price_ladder.md) for more information)


 


![tog_minus](tog_minus.gif)




| The price ladder is broken down into three functional columns by default, and can be extended to display any number of additional custom columns.   Buy Column The left column is the Buy 1   •Submit buy orders•Modify buy orders•Display the total contracts on the bid at their respective prices (also known as market depth)  Price Column The center column, known as the Price 2   •Modify stop loss and profit target orders•Display market prices•Display the current bid, ask, and last traded prices•Display indicator price levels  Sell Column The right column is the Sell 3 column which is used to:   •Submit sell orders•Modify sell orders•Display the total contracts on the ask at their respective prices (also known as market depth)  SuperDOM_1     | Note: To view market depth for equities the [Level II](level_ii.md) window must be used. | | --- |      Columns You can optionally configure additional Columns 4 to display other points of interest relative to the ladder display.   SuperDOM_2   By default, NinjaTrader will come pre\-loaded with the following columns:   •APQ (Approximate Position in Queue)•Notes•PnL•Volume  We also support custom NinjaScript column development, meaning that programmers and vendors can create custom columns which can be  installed to extend functionality of the SuperDOM display.   Please see our Help Topic on [Understanding SuperDOM Columns](using_superdom_columns.md) for more information. |
| --- | --- |



![tog_minus](tog_minus.gif)        [Understanding how market data is displayed](javascript:HMToggle('toggle','UnderstandingHowMarketDataIsDisplayed','UnderstandingHowMarketDataIsDisplayed_ICON'))




| The Price Ladder display section of the SuperDOM displays the current inside market and market depth. Various aspects of this display can be user defined in the [SuperDOM Properties](properties_superdom.md) window.   The following market depth items can be displayed:   1\.Bid Depth2\.Ask Depth3\.Best Bid4\.Best Ask  Last traded price and size (yellow cell in the image below)   SuperDOM_3 |
| --- |



![tog_minus](tog_minus.gif)        [How to use the quick buttons at the bottom of the Price Ladder display](javascript:HMToggle('toggle','HowToUseTheQuickButtonsAtTheBottomOfThePriceLadderDisplay','HowToUseTheQuickButtonsAtTheBottomOfThePriceLadderDisplay_ICON'))




| The bottom row of the price ladder contains three functions: Buy Market, PnL, and Sell Market.   Market (left cell) Submits buy market, limit at ask, or limit at bid orders   PnL (center cell) Displays unrealized profit or loss for the current position   Market (right cell) Submits sell market, limit at ask, or limit at bid orders   SuperDOM_4   You can change the type of order the MARKET cells submit by holding down the SHIFT key to place limit orders at the ask, or by holding down the CTRL key to place limit orders at the bid. Clicking with your left mouse button on the PnL cell will change the display between points, ticks, currency, percent and pips. |
| --- |



![tog_minus](tog_minus.gif)        [How to display the daily high and low prices](javascript:HMToggle('toggle','HowToDisplayTheDailyHighAndLowPrices','HowToDisplayTheDailyHighAndLowPrices_ICON'))




| Daily High and Low The market's daily high 1 and daily low 2 can be optionally displayed.  To enable this feature:   •Right click on the SuperDOM, select Properties, check Show daily high/low markers  You can further customize the color of the markers in the [SuperDOM Properties](properties_superdom.md) dialog window.   SuperDOM_5     | Note: Daily High and Low values are not calculated by NinjaTrader and are sent from your data provider.  Not all data providers provide this information for all instrument types. | | --- | |
| --- | --- |



![tog_minus](tog_minus.gif)        [Understanding how position and profit \& loss information is displayed](javascript:HMToggle('toggle','UnderstandingHowPositionAndProfitLossInformationIsDisplayed','UnderstandingHowPositionAndProfitLossInformationIsDisplayed_ICON'))




| PnL Display The PnL field in the bottom of the Price column will show the current unrealized profit/loss for your current open position, and read as PnL when you are FLAT.   You can optionally enable "Show PnL when flat" in the [SuperDOM Properties](properties_superdom.md) to view your daily account PnL when FLAT   SuperDOM_6   Current Position Display The cell between the CLOSE button and the REV button will tell you your current position.   When long the field will show as green and list the number of contracts, and when short field will show as red and list the number of contracts. When you do not have an open position the field will say FLAT. |
| --- |



![tog_minus](tog_minus.gif)        [How to adjust the Price Ladder display](javascript:HMToggle('toggle','HowToAdjustThePriceLadderDisplay','HowToAdjustThePriceLadderDisplay_ICON'))




| [playVideo](http://www.ninjatrader.com/support/movies/nt7/helpGuide/operations/orderEntry/superDOM/adjustingThePriceLadderDisplay/Adjusting-The-Price-Ladder-Display.md)   Adjusting the Price Ladder display Move your cursor into the Price Ladder region and use your mouse scroll wheel to adjust market prices up or down.   You can also left mouse click on the "C" button at any time to center the inside market.   Optionally, the Auto Center property will automatically center the inside market price should the last traded price trade outside the visible range on the Price Ladder. You can enable or disable Auto Center at any time by clicking on your right mouse button in the border of the SuperDOM and selecting the menu name Auto Center.   SuperDOM_7     Number of Visible Price Rows The number of price rows will be dynamically adjusted by vertically re\-sizing the SuperDOM window.  The larger the size of the SuperDOM window, the more price levels will be added in automatically.     This achieved in the same manner you would use to resize any other sort of general application window, by moving your mouse cursor to the edge of the window and clicking and dragging until you have reached your desired size.   Increasing / Decreasing the Number of Market Depth Levels By default, the SuperDOM will display 10 levels of market depth.  However you can configure additional levels of depth to be displayed and is only limited by the number of levels provided by the exchange/data provider combination you are using.   For example, an exchange might provide 20 levels of market depth for an instrument you are trading.  If you would like to view all 20 of these levels on the SuperDOM, simply right click on the SuperDOM, select Properties, and set the \# of market depth levels property value to 20 and the press OK.   SuperDOM_8 |
| --- |










