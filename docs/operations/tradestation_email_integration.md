# TradeStation Email Integration

The TradeStation Email Interface is targeted toward individuals who are familiar with programming in EasyLanguage and want to run TradeStation strategies and automate order flow to any supported NinjaTrader broker.

## The interface works as follows:

1. You apply a strategy in your TradeStation chart that generates buy/sell orders

2. TradeStation will send email notification for Strategy Orders Activated, Filled, Canceled and Replaced to NinjaTrader

3. NinjaTrader will process these emails and execute them as orders either to the NinjaTrader simulator or your live brokerage account

|  |
| --- |
| Email Interface  
- [Symbol Mapping](symbol_mapping.md)  
- [Running concurrent strategies](running_concurrent_strategies_.md)  
- [Set Up](set_up.md)  
- [Order Handling Options](../strategies/order_handling_options.md)  
- [Stop Order Handling](../strategies/stop_order_handling.md)  
- [Workspace Options](workspace_options.md) |