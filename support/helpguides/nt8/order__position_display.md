


Operations \> Order Entry \> Chart Trader \> Order \& Position Display






















Order \& Position Display







| \<\< [Click to Display Table of Contents](order__position_display.md) \>\> **Navigation:**     [Operations](operations.md) \> [Order Entry](order_entry.md) \> [Chart Trader](chart_trader.md) \> Order \& Position Display | [Previous page](chart_trader.md) [Return to chapter overview](chart_trader.md) [Next page](collapsed_view.md) |
| --- | --- |














Chart Trader allows for the placement of orders, and the management of orders and positions, directly from a chart. Orders and positions within Chart Trader are displayed in a visual manner, allowing you to quickly compare them with current market movements while modifying orders in real\-time. Chart Trader contains two primary components: the Chart Trader panel, which is used to place, modify, or cancel/close orders and positions, and the chart panel, on which Chart Trader draws visual representations of resting orders and open positions.


![tog_minus](tog_minus.gif)




| Order Display A resting order is displayed on the chart as a color\-coded line connecting an order price label in the right margin of the chart with a second label displaying the order quantity and type.     | Limit Order | Default color is cyan with the text "LMT" | | --- | --- | | Stop\-Market Order | Default color is pink with text "STP" | | Stop\-Limit Order | Default color is violet with text "SLM" | | Market Order | Market orders are not displayed (see Control Center [Orders Tab](orders_tab.md) for more information) | | Market if Touched (MIT) Order | Default color is spring green with the text "MIT" | | Stop Loss Order | Default color is red | | Profit Target Order | Default color is lime |      Chart trader color properties can be set via the Chart Trader [properties window](properties3.md).    The image below displays how orders are visualized in a NinjaTrader chart with Chart Trader enabled.   ChartTrader1   1\. Buy stop\-limit order for 1 contract at a price of X 2\. Buy stop\-market order for 1 contract at a price of X 3\. Buy limit order for 1 contract at a price of X     | Note: Orders will only display for the selected Account and Instrument. | | --- | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |



![tog_minus](tog_minus.gif)




| Position Display An open position is displayed slightly differently. A position is displayed on the chart as a colored line connecting an entry price label in the right margin of the chart with a second label displaying the position size and current unrealized profit or loss. The text displaying the profit and loss is color coded, with green representing profit and red representing loss. The quantity displayed in the left\-hand label is color coded, as well, with green representing a long position and red representing a short position.   Note: The display of unrealized PnL in Chart Trader can be switched between points, currency, pips, ticks, and percent by either left mouse clicking in the PnL field in the Chart Trader panel, or via the Chart Trader [Properties](properties3.md) window.   The image below displays the chart with an active position managed by an [Advanced Trade Management](advanced_trade_management_atm.md) strategy.    ChartTrader2   1\. Two profit target orders  2\. Position size and PnL flag for 2 contracts long 3\. Two stop loss orders\* 4\. Average entry price 5\. PnL in Chart Trader panel   \* The stop loss line and flag represents two orders, as indicated by the letter "s" next to the qty number "2\."     | Note: Positions will only display for the selected Account and Instrument. | | --- | |
| --- | --- |



![tog_minus](tog_minus.gif)        [Working with multiple instruments](javascript:HMToggle('toggle','WorkingWithMultipleInstruments','WorkingWithMultipleInstruments_ICON'))




| Multi\-Series Charts NinjaTrader charts include the ability to plot multiple instruments within a single chart window, and each individual instrument on a chart can be selected and worked with separately using Chart Trader. For more information on how to manage instruments on a chart, see the [Working with Multiple Data Series](working_with_multiple_data_series.md) page.   ChartTrader16   In the image above, we have applied a EURUSD instrument, an FDAX \#\#\-\#\# instrument, and a BIDU instrument in three separate panels of the same chart.   Selecting Data Series With more than one instrument applied to a chart, you can change the instrument upon which Chart Trader will act via the Instrument dropdown menu. This menu will list all of the Data Series currently applied to your chart. When an instrument is selected, only orders and positions for that particular instrument will be displayed in the chart panel, and any quick buttons used or order parameters set in the Chart Trader panel will apply to that instrument.   ChartTrader17   1\. With the EURUSD selected in the Instruments dropdown menu, we can only that instrument's orders and positions.   ChartTrader18   2\. With BIDU selected, we see a different set of orders and positions. |
| --- |










