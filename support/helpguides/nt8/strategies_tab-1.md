


Operations \> Control Center \> Strategies Tab






















Strategies Tab







| \<\< [Click to Display Table of Contents](strategies_tab.md) \>\> **Navigation:**     [Operations](operations-1.md) \> [Control Center](control_center-1.md) \> Strategies Tab | [Previous page](orders_tab-1.md) [Return to chapter overview](control_center-1.md) [Next page](executions_tab-1.md) |
| --- | --- |














The Strategies tab displays running and terminated strategies in a [data grid](data_grids-1.md).


 




| Note: The [IncludeTradeHistoryInBacktest](includetradehistoryinbacktest-1.md) property is set to false by default when a strategy is applied directly in the Strategies tab. This provides for leaner memory usage, but at the expense of not being able to access Trade objects for historical trades. Thus, fields such as [SystemPerformance.AllTrades.Count](alltrades-1.md) that rely on references Trade objects will not have any such references to work with. If you would like to save these objects for reference in your code, you can set IncludeTradeHistoryInBacktest to true in the Configure state. For more information, see the [Working with Historical Trade Data](strategyanalyzer_properties_2-1.md) page. |
| --- |



![tog_minus](tog_minus-1.gif)        [Understanding the strategies tab](javascript:HMToggle('toggle','UnderstandingTheStrategiesTab','UnderstandingTheStrategiesTab_ICON'))




| Strategy Display Active and stopped strategies are listed as a grid and can be started/stopped by left mouse clicking the check box in the Enabled column.   ControlCenterStrategiesGrid   •Green highlighted "Strategy" name indicates a currently running strategy.•Orange highlighted "Strategy" name indicates the strategy is waiting until it reaches a flat position to be in sync with the account position before fully starting. (Please see the [Syncing Account Positions](syncing_account_positions-1.md) section for configuration options)•Black highlighted "Strategy" name indicates a disabled strategy.  Strategies using multiple instruments will be expandable so that each instrument's strategy position can be viewed. In the image above, the second strategy is using ES 06\-14 as well as MSFT which is shown below it.   Columns can be re\-ordered and re\-sized at will, and individual columns can be enabled or disabled via the Properties window accessible in the Strategies grid's Right\-Click menu. The following columns are displayed in the Strategies grid by default:     | Strategy | The name of the strategy | | --- | --- | | Instrument | The instrument on which the strategy is enabled | | Data Series | The interval type and value associated with the strategy's instrument | | Parameters | The values of any user\-defined parameter inputs used by the strategy | | Position | The Strategy Position (independent of the Account Position) | | Acct. Position | The Account Position (includes positions not entered by the strategy) | | Sync | Compares the strategy position to the current real\-world account position relative to the configured instrument.  A value of true indicates the strategy position is currently in sync with the account position    For Multi Instrument strategies, a small red flag can appear to the right of the sync value \- this would alert the user to expand the row to check the sync for any additional instruments the strategy trades as well.   Note:  A strategy which is in "Wait until flat" (yellow) is considered "flat" regardless of the historical strategy position | | Avg. Price | Average price of positions entered by the strategy | | Unrealized | Any unrealized profit or loss of an open position entered by the strategy | | Realized | Any realized profit or loss of positions entered by the strategy | | Account Display Name | The Display Name of the account on which the strategy is enabled | | Connection | The connection on which the strategy is running. This column will be blank for disabled strategies | | Enabled | A checkbox indicating whether the strategy is enabled. This box can be checked or unchecked to enable or disable a strategy. |      The following additional columns can be applied through the grid's Properties window:     | Account Name | The "Account Name" \-\- not to be confused with the "Account Display Name." These two can differ for live brokerage accounts, and the "Account Display Name" tends to be more descriptive. | | --- | --- |        | Tip: Please note the sync column compares only the individual strategy position to the account position, it will not generate a total strategy position for all strategies run on the same instrument / account combination. | | --- |      Right Click Menu Right mouse clicking within the strategies grid opens the following menu:   ControlCenter_StrategiesContextMenu     | New Strategy... | [Run a new automated NinjaScript strategy](running_a_ninjascript_strategy-1.md) | | --- | --- | | Edit Strategy | Brings up the Edit Strategy window to edit the strategy parameters for the selected strategy. (Only disabled strategies can be edited) | | Synchronize All Strategies | Will aggregate all strategy positions and syncs aggregate value to the accounts position for the instruments that have running strategies. | | Enable | Enables the strategy | | Disable | Disables the strategy | | Remove | Removes the selected strategy from the grid | | Strategy Performance | Generates a performance report for the selected strategy (See the "How to view strategy performance" section below) | | Filter Only Active Strategies | Displays only active strategies. Note: If this item is checked and a new strategy is added that is not yet enabled, the strategy will not be displayed in this grid. | | Filter By Account | Sets which strategies to display by account | | Always On Top | Sets if the window should be always on top of other windows | | Show Tabs | Sets if the window should allow for tabs | | Export | Exports the grid contents to "CSV" or "Excel" file format | | Find... | Search for a term in the grid | | Print | Select to print either the window or the order grid area. | | Share | Select to share via your share connections. | | Properties... | Configure the strategies tab properties | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |



![tog_minus](tog_minus-1.gif)        [How to view strategy performance](javascript:HMToggle('toggle','HowToViewStrategyPerformance','HowToViewStrategyPerformance_ICON'))




| Strategy Performance While the [Account Performance](trade_performance-1.md) tab will generate performance report against your account's trade history, the Strategy Performance menu allows you to generate a performance report against the trades generated by the selected strategy.   ControlCenter_Strategies_StrategyPerformance   •Real\-time \- Generates performance data for your real\-time trades only (since the strategy started running) and will exclude historical trades. If your strategy held a virtual position (calculated against historical data) upon starting, a virtual execution representing the average price of this position will be injected into the real\-time results to ensure that a trade pair can be created with the executions resulting from the closing of this position.•Historical \& Real\-time \- Generates performance data for both historical and real\-time trade data.•Historical \- Generates performance data for historical data only. |
| --- |



![tog_minus](tog_minus-1.gif)        [Strategy tab properties](javascript:HMToggle('toggle','StrategyTabProperties','StrategyTabProperties_ICON'))




| ControlCenter_Strategies_Properties   Strategy Tab Properties   | General |  | | --- | --- | | Filter only active strategies | Displays only active strategies | | Filter by account | Displays only strategies running on the selected account | | Grid font | Sets the font for the order grid | | Tab name | Sets the tab name | | Columns | Sets that columns are enabled or disabled |      How to Save Property Presets Once you have your properties set to your preference, you can left mouse click on the "preset" text located in the bottom right of the properties dialog. Selecting the option "save" will save these settings as the default settings used every time you open a new window/tab.   If you change your settings and later wish to go back to the original factory settings, you can left mouse click on the preset text and select the option to restore to return to the original factory settings \- please note though that you cannot save a custom default to restore to.     | Note: A number of pre\-defined variables can be used in the "Tab Name" field. For more information, see the "Tab Name Variables" section of the [Using Tabs](using_tabs-1.md) page. | | --- | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |










