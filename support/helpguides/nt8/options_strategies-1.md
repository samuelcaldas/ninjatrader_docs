


Configuration \> Options \> Strategies






















Strategies







| \<\< [Click to Display Table of Contents](options_strategies.md) \>\> **Navigation:**     [Configuration](configuration-1.md) \> [Options](options-1.md) \> Strategies | [Previous page](options_trading-1.md) [Return to chapter overview](options-1.md) [Next page](options_ati-1.md) |
| --- | --- |




[Show/Hide Hidden Text](javascript:HMToggleExpandAll(!HMAnyToggleOpen()) "Click to open/close expanding sections")









The Strategies category sets options regarding handling of [ATM Strategies](atm_strategy-1.md) and [NinjaScript strategies](strategy-1.md) for automated system trading.


![tog_minus](tog_minus-1.gif)        [Understanding ATM strategy properties](javascript:HMToggle('toggle','UnderstandingAtmStrategyProperties','UnderstandingAtmStrategyProperties_ICON'))




| ATM Strategy Properties This property group sets [ATM strategy](atm_strategy-1.md) handling options.   Options_Strategies1     | ATM Strategy |  | | --- | --- | | Use server side ATMs (beta) | When enabled the new ATMs that work server side will be available. This is only available when Multi\-provider is disabled. See the [Sever Side ATMs](server-side-atm-strategy-1.md) section of the help guide to understand the differences between them and the legacy ATMs. | | Modify inner bracket | When enabled, and when scaling into a position managed by an ATM Strategy, the inner bracket of stop loss and profit target order quantities will be modified to reflect the increased position size. When disabled, the outer bracket will be modified. This setting is only available when Use server side ATMs is disabled. | | Modify nearest bracket | When enabled, the nearest bracket of stop loss and profit target order quantities are modified when changing the quantity of a stop loss or target order in a multi\-target ATM Strategy. This property is used in conjunction with "Modify inner bracket". For example, if both "Modify inner..." and "Modify nearest..." are enabled and you modify target 2 from 1 contract to 2 contracts, target 1 order size will be reduced by 1\. If you had "Modify inner..." disabled, target 3 order size will be reduced by 1\. This setting is only available when Use server side ATMs is disabled. | | Show simulated stops as pending | When enabled, simulated stops will show with an order start of Trigger pending. This setting is only available when Use server side ATMs is disabled. | | Use last price for auto trail and auto breakeven | When enabled, the last traded price is used to trigger auto trail or auto breakeven functions. When disabled, the Bid is used for long positions, and the Ask is used for short positions. This setting is only available when Use server side ATMs is disabled. | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |



![tog_minus](tog_minus-1.gif)        [Understanding NinjaScript properties](javascript:HMToggle('toggle','UnderstandingninjascriptProperties','UnderstandingninjascriptProperties_ICON'))




| NinjaScript properties This property group controls how NinjaTrader will run your NinjaScript strategies.    Options_Strategies_NS     | Cancel entry orders when a strategy is disabled | Enables or disables automatic cancellation of a NinjaScript strategy's entry orders when the strategy is disabled. | | --- | --- | | Cancel exit orders when a strategy is disabled | Enables or disables automatic cancellation of a NinjaScript strategy's exit orders when the strategy is disabled. | | On connection loss | Expand this category to set connection loss handling parameters. | | Handling | Sets the action a NinjaScript strategy will take after a disconnection occurs:   Keep Running: Keeps the strategy running and logs the disconnection. When the connection is reestablished, the strategy will resume as if no disconnection occurred.   Recalculate: The strategy will attempt to recalculate its strategy position when a connection is reestablished and held for longer than 10 seconds. Recalculations will only occur if the strategy was stopped based on one of the conditions below. Should the connection be reestablished before the strategy is stopped, the strategy will continue running without recalculating as if no disconnection occurred. •If data feed disconnects for longer than the time specified in “Disconnect delay seconds”, the strategy is stopped and the disconnection is logged.•If the order feed disconnects and the strategy places an order while disconnected, the strategy is stopped and the disconnection is logged.•If both the data and order feeds disconnect for longer than the time specified in “Disconnect delay seconds”, the strategy is stopped and the disconnection is logged.  Stop Strategy: Automatically stops the strategy and logs the disconnection when disconnected for more than "Disconnect Delay Seconds". No action will be taken when a connection is reestablished. | | Disconnect delay seconds | Sets the number of seconds a disconnection must persist before it is recognized by the Disconnect Handling logic | | Number of restart attempts | Sets the number of times NinjaTrader will attempt to restart a strategy within the "Restarts within x minutes" time span. The strategy will only restart on a reestablished connection when there have been fewer restart attempts than "Number of restart attempts" within the last "Restarts within x minutes" time span. Otherwise the strategy will simply halt, and no further restart attempts will be made. | | Restarts within x minutes | Sets the number of minutes for the "Restarts within x minutes" time span used by "Number of restart attempts". | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |










