


Operations \> Automated Trading \> Running NinjaScript Strategies \> Running a NinjaScript Strategy from the Strategies Tab






















Running a NinjaScript Strategy from the Strategies Tab







| \<\< [Click to Display Table of Contents](running_a_ninjascript_strateg2.md) \>\> **Navigation:**     [Operations](operations-1.md) \> [Automated Trading](automated_trading-1.md) \> [Running NinjaScript Strategies](running_ninjascript_strategies-1.md) \> Running a NinjaScript Strategy from the Strategies Tab | [Previous page](running_a_ninjascript_strategy-1.md) [Return to chapter overview](running_ninjascript_strategies-1.md) [Next page](using_strategy_templates-1.md) |
| --- | --- |




[Show/Hide Hidden Text](javascript:HMToggleExpandAll(!HMAnyToggleOpen()) "Click to open/close expanding sections")









You can run a NinjaScript strategy in real\-time in a live or simulation account via the [Strategies](options_strategies-1.md) tab of the Control Center. 


 


![tog_minus](tog_minus-1.gif)        [How to run a NinjaScript strategy from the Strategies tab](javascript:HMToggle('toggle','HowToRunAninjascriptStrategyFromTheStrategiesTab','HowToRunAninjascriptStrategyFromTheStrategiesTab_ICON'))




| Setup Tips Following are some key points and instructions on on how to run a NinjaScript strategy from the Strategies tab of the Control Center window:   •NinjaTrader MUST be connected to a live brokerage or market data vendor •A NinjaScript strategy is a self contained automated trading system and orders generated are live and not virtual. Cancelling strategy generated orders manually can cause your strategy to stop executing as you designed it. If you want to manually cancel an order, terminate the strategy first. •Strategies initiated from the Strategies tab will NOT appear in a chart  Running a NinjaScript Strategy To run a NinjaScript strategy from the Strategies tab:   1\.Left mouse click on the Strategies tab found in the NinjaTrader Control Center2\.Right mouse click within the Strategies tab. The right click menu will appear.3\.Select the menu item New Strategy... The New Strategy window will appear.4\.Choose the strategy you wish to run from the list of Available strategies on the left5\.Set the instrument, interval, and other optional strategy properties (see the "Understanding strategy properties section below") and press the OK button6\.Check the box in the Enable column of the Strategies tab next to the strategy you wish to enable.    | Note: You must set the "Enabled" property in Step 6 above to True to turn on the strategy. When this property is disabled, the strategy will be applied, but will be inactive. | | --- | |
| --- | --- |



![tog_minus](tog_minus-1.gif)        [Understanding strategy properties](javascript:HMToggle('toggle','UnderstandingStrategyProperties','UnderstandingStrategyProperties_ICON'))




| Strategy Properties (see image below) The image below shows the adjustable properties for a strategy available in the Strategies tab of the Control Center (see the "How to run a NinjaScript strategy in from the Strategies tab" section above):     | Data Series |  | | --- | --- | | Instrument | Sets the instrument(s) the strategy will run against | | Price based on | Sets the type of market data used to drive the Data Series. | | Type | Sets the bar type of the Data Series. | | Value | Sets the Data Series value. | | Strategy Parameters |  | | (...) | Sets any strategy specific user defined inputs | | Time Frame |  | | Days to load | Sets the number of days to load data | | Trading hours | Sets the Trading Hours template for the Data Series. (See the "[Trading Hours](sessioniterator-1.md)" section of the Help Guide for more information) | | Break at EOD | Enables or disables the bars being reset at EOD (End Of Day). (See the "[Break at EOD](break_at_eod-1.md)" section of the Help Guide for more information) | | Set up |  | | Account | Sets the account the strategy will execute orders in | | Calculate | Sets the frequency that the indicator calculates: •On bar close \- will slow down the calculation until the close of a bar•On price change \- will calculate on when there has been a change in price•On each tick \- calculate the indicator's value which each incoming tick. | | Label | Sets a text label that will be displayed on the chart to represent the strategy | | Maximum bars look back | Sets the maximum number of historical bars to use for strategy calculations. The TwoHundredFiftySix setting is the most memory friendly. | | Bars required to trade | Sets the minimum number of bars required before the strategy will start processing trades | | Start behavior | Sets the starting behavior of the strategy, based upon the account position. See the [Syncing Account Positions](syncing_account_positions-1.md) page for more information. | | Historical fill processing |  | | Order fill resolution | Sets the way that simulated historical orders will be processed by the strategy. See the [Understanding Historical Fill Processing](understanding_historical_fill_-1.md) page for more information. | | Fill limit orders on touch | Enables or disables the filling of limit orders on a single touch of price action. | | Slippage | Sets the slippage amount in ticks for the historical portion of the chart | | Order handling |  | | Entries per direction | Sets the maximum number of entries allowed per direction while a position is active based on the "Entry handling" property | | Entry handling | Sets the manner in how entry orders are handled. If set to "AllEntries", the strategy will process all entry orders until the maximum allowable entries set by the "Entries per direction" property has been reached while in an open position. If set to "UniqueEntries", strategy will process entry orders until the maximum allowable entries set by the "Entries per direction" property per each uniquely named entry. | | Exit on close | When enabled, open positions are closed on the last bar of a session | | Exit on close seconds | Sets the number of seconds prior to the end of a session when open positions of a strategy will be closed | | Stop \& target submission | Sets how stop and target orders are submitted | | Order properties |  | | Set order quantity | Sets how the order size is determined, options are: •Default quantity \- User defined order size•Strategy \- Takes the order size specified programmatically within the strategy | | Time in force | Sets the order's time in force |      | Running_NS_1 | | --- | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |



![tog_minus](tog_minus-1.gif)        [How to view strategy performance](javascript:HMToggle('toggle','HowToViewStrategyPerformance','HowToViewStrategyPerformance_ICON'))




| Strategy Performance While the [Account Performance](trade_performance-1.md) tab will generate performance report against your account's trade history, the Strategy Performance menu allows you to generate a performance report against the trades generated by the selected strategy.   ControlCenter_Strategies_StrategyPerformance   •Real\-time \- Generates performance data for your real\-time trades only (since the strategy started running) and will exclude historical trades. If your strategy held a virtual position (calculated against historical data) upon starting, a virtual execution representing the average price of this position will be injected into the real\-time results to ensure that a trade pair can be created with the executions resulting from the closing of this position.•Historical \& Real\-time \- Generates performance data for both historical and real\-time trade data.•Historical \- Generates performance data for historical data only. |
| --- |










