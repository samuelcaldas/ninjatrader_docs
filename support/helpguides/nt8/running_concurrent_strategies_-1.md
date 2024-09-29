


Operations \> Automated Trading \> Automated Trading Interface (ATI) \> TradeStation Email Integration \> Running concurrent strategies in the same market






















Running concurrent strategies in the same market







| \<\< [Click to Display Table of Contents](running_concurrent_strategies_.md) \>\> **Navigation:**     [Operations](operations-1.md) \> [Automated Trading](automated_trading-1.md) \> [Automated Trading Interface (ATI)](automated_trading_interface_at-1.md) \> [TradeStation Email Integration](tradestation_email_integration-1.md) \> Running concurrent strategies in the same market | [Previous page](tradestation_email_integration-1.md) [Return to chapter overview](tradestation_email_integration-1.md) [Next page](set_up-1.md) |
| --- | --- |











NinjaTrader uses a number of different properties in the TradeStation generated email to identify unique orders as they are sent to NinjaTrader.  


 


## These properties include


•Instrument name 

•Action (Buy, Sell etc...) 

•Signal name 

•Workspace name 

 


## If you are running concurrent strategies on the same market you should ensure that you either


•Make all signal names unique or 

•Run the concurrent strategies in different TradeStation workspaces 

 


This will ensure accurate processing of your automated signals.








