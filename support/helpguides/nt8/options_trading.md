


Configuration \> Options \> Trading






















Trading







| \<\< [Click to Display Table of Contents](options_trading.md) \>\> **Navigation:**     [Configuration](configuration.md) \> [Options](options.md) \> Trading | [Previous page](enabling_disabling-multi-provi.md) [Return to chapter overview](options.md) [Next page](options_strategies.md) |
| --- | --- |














The Trading category sets all trading properties and allows configuration of simulation accounts. 


![tog_minus](tog_minus.gif)




| Trading Properties Trading properties can be set in the Options window with the Trading category selected. There are several properties each are described below:   Options_Trading     | General |  | | --- | --- | | Confirm order placement | Sets if NinjaTrader will open a popup to confirm each order placed preventing an accidental order submission. | | Start in global simulation mode | Sets if NinjaTrader will start with Global Simulation Mode enabled preventing live orders from being submitted until you manually disable Global Simulation Mode. This is only available if Multi\-provider is enabled. | | Use order entry hot keys | If checked NinjaTrader will allow you to submit orders using the order\-entry Hot Keys, which can be defined in the Hot Keys window. See the "[Hot Keys](hot_key_manager.md)" section for more information. | | Calculations |  | | Use Total PnL for Show realized PnL when flat | Enables or disabled Total PnL rather than Gross PnL being displayed in order entry windows when Show realized PnL when flat is also enabled. | | Use last price for PnL | Sets if the last trade price is used to calculate profit and loss, or if the Bid will be used for long positions and the Ask for short positions. | | Simulator |  | | Enforce immediate fills | Sets if orders on simulation accounts will be filled immediately instead of using the NinjaTrader advanced [simulation fill engine](simulation.md). | | Enforce partial fills | Sets if partial fills will be forced on simulation orders. When disabled, orders are filled based on the NinjaTrader advanced [simulation fill engine](simulation.md). | | Simulation color | Sets the background color of any order interface that has a simulation account selected. This feature is disabled if set to "Transparent". | | Auto close position |  | | Enable | Sets if NinjaTrader will close out any positions automatically at the specified time. For see more information, see the "Understanding the auto close position function" section below. | | Instruments | Sets the instruments for which NinjaTrader will attempt to close positions at the specified time. This is set for each individual order\-entry window, and can be set here by selecting the Instruments field and clicking add in the window that appears. If Auto close on all instruments is checked, this will globally work on all instruments in the platform, meaning disabling Auto close on an order entry window will have no affect since it is already globally set to close. | | Time | Sets the time at which NinjaTrader will attempt to automatically close positions held in the instruments set in the instruments field. Note: The time will be based upon the timezone set up in the [General](general_section.md) section of the Options window. | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |



![tog_minus](tog_minus.gif)




| Auto Close Position NinjaTrader can be set to automatically attempt to close a position at a designated time that is configured in the Tools \> Options \> Trading menu, you can also add instruments through the NinjaTrader trading interfaces via right click and selecting Auto close position.   Options_AutoClosePosition1     | Auto close position |  | | --- | --- | | Enable | Sets if NinjaTrader will close out any positions automatically at the specified time. | | Instruments | Sets the instruments for which NinjaTrader will attempt to close positions at the specified time. This is set for each individual order\-entry window, and can be set here by selecting the Instruments field and clicking add in the window that appears If Auto close on all instruments is checked, this will globally work on all instruments in the platform, meaning disabling Auto close on an order entry window will have no affect since it is already globally set to close. | | Time | Sets the time at which NinjaTrader will attempt to automatically close positions held in the instruments set in the instruments field. Note: The time will be based upon the timezone set up in the [General](general_section.md) section of the Options window. | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- |










