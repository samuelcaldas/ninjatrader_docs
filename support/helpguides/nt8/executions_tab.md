


Operations \> Control Center \> Executions Tab






















Executions Tab







| \<\< [Click to Display Table of Contents](executions_tab.md) \>\> **Navigation:**     [Operations](operations.md) \> [Control Center](control_center.md) \> Executions Tab | [Previous page](strategies_tab.md) [Return to chapter overview](control_center.md) [Next page](positions_tab.md) |
| --- | --- |














The Executions tab displays all executions for the current day in the [data grid](data_grids.md).


![tog_minus](tog_minus.gif)




| Executions Data Grid The current day's execution information will be shown in the data grid when connected to your brokerage connection. Simulated trades (into any simulation account) will appear when connected to any data feed connection.   ControlCenter_ExecutionsGrid   Columns can be re\-ordered and re\-sized at will, and individual columns can be enabled or disabled via the Properties window accessible in the Executions grid's Right\-Click menu. The following columns are displayed in the Executions grid by default:     | Instrument | The Instrument on which the execution took place | | --- | --- | | Action | Indicates whether the execution was from a Buy or Sell order | | Quantity | The quantity of the execution | | Price | The price at which the execution occurred | | Time | The time at which the execution occurred | | ID | A unique identifier for the execution | | E/X | Indicates whether the execution was an Entry or Exit | | Position | Indicates the Account Position after the execution | | Order ID | The ID of the order executed | | Name | The name of the order executed | | Commission | The commission applied to the execution | | Rate | The currency conversion rate used for the execution. A value of "1" indicates that no currency conversion took place | | Account Display Name | The Display Name of the account to which the execution was placed | | Connection | The connection through which the execution was routed |        The following additional columns can be applied through the grid's Properties window:     | Account Name | The "Account Name" \-\- not to be confused with the "Account Display Name." These two can differ for live brokerage accounts, and the "Account Display Name" tends to be more descriptive. | | --- | --- |      Right Click Menu Right mouse clicking within the executions grid opens the following menu:   ControlCenter_Executions_ContextMenu     | Chart | Opens a chart of the instrument at the time of the selected execution | | --- | --- | | Filter By Account | Sets which executions to display by account | | Always On Top | Sets if the window will be always on top of other windows | | Show Tabs | Sets if the window should allow for tabs | | Export... | Exports the grid contents to "CSV" or "Excel" file format | | Find... | Search for a term in the grid | | Print | Select to print either the window or the order grid area. | | Share | Select to share via your share connections. | | Properties... | Configure the executions tab properties |      Forex Executions Forex executions hold additional data such as Rate and Account Lot Size   Rate Executions on currency pairs that do not contain USD will try to grab a conversion rate in real\-time shown in the "Rate" column from your data provider. Should a suitable USD conversion rate not be available, a rate of 1 will be used. This Rate will be used in determining the PnL in USD for the forex trade in other areas like the [Account Performance tabs](trade_performance.md). The approach NinjaTrader follows is the GAIN Capital approach, but may differ from what banks do since they base their conversion rates off of the prior session's closing price of the currency pair. This means that our calculation approach may result in slightly different PnL values than the ones reported from your brokerage.     | Note: NinjaTrader connection setting "Auto subscribe to required instruments" must be enabled when creating your forex connection for NinjaTrader to automatically get the currency rates needed for PnL conversion when the trade execution occurs. For more information please see the connection guide for your provider on how to enable this property. | | --- |      Account Lot Size Executions track the Account Lot Size used for the account when the execution occured. This is used for accurate Pip PnL calculations as a 1 pip gain in EURUSD for a 10,000 QTY sized mini lot trader is different then a 1 pip gain in EURUSD for a 1,000 QTY sized micro lot trader. Account Lot Size is used by NinjaTrader to normalize your Pip PnL reporting so that it is accurate to your accounts base Forex lot size. The Account Lot Size is normally provided from your broker automatically, however if the broker does not send the account lot size then the connection settings for the account in NinjaTrader will have an option for you to define the property "Forex lot size". |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |



![tog_minus](tog_minus.gif)        [Executions tab properties](javascript:HMToggle('toggle','ExecutionsTabProperties','ExecutionsTabProperties_ICON'))




| ControlCenter_Executions_Properties   Executions Tab Properties   | General |  | | --- | --- | | Filter by account | Filters orders by selected account | | Grid font | Sets the font for the order grid | | Tab name | Sets the tab name | | Columns | Sets that columns are enabled or disabled in the order grid. |      How to set preset property defaults Once you have your properties set to your preference, you can left mouse click on the "preset" text located in the bottom right of the properties dialog. Selecting the option "save" will save these settings as the default settings used every time you open a new window/tab.   If you change your settings and later wish to go back to the original factory settings, you can left mouse click on the preset text and select the option to restore to return to the original factory settings \- please note though that you cannot save a custom default to restore to.     | Note: A number of pre\-defined variables can be used in the "Tab Name" field. For more information, see the "Tab Name Variables" section of the [Using Tabs](using_tabs.md) page. | | --- | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |










