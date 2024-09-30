
Operations > Advanced Trade Management (ATM)
Advanced Trade Management (ATM)
| << [Click to Display Table of Contents](advanced_trade_management_atm.md) >> **Navigation:**     [Operations](operations-1.md) > Advanced Trade Management (ATM) | [Previous page](operations-1.md) [Return to chapter overview](operations-1.md) [Next page](server-side-vs-local-atms-1.md) |
| --- | --- |
| ATM Overview ATM Strategies can be accessed from the  ATM Strategy Selectors located in various [Order Entry](order_entry-1.md) interfaces   NinjaTrader provides you with the flexibility to trade with or without an Advanced Trade Management (ATM) Strategy. ATM Strategies are designed to provide discretionary traders with semi-automated features to manage their positions. This is NOT to be confused with NinjaScript Strategies for [automated trading](automated_trading-1.md) systems. | |
| --- | --- |
| ATM Strategy   ›[Definition and Benefits](atm_strategy-1.md)›[ATM Strategy Parameters](atm_strategy_parameters-1.md)›[ATM Strategy Selection Mode](atm_strategy_selection_mode-1.md)›[Stop Strategy](stop_strategy-1.md)›[Auto Breakeven](auto_breakeven-1.md)›[Auto Trail](auto_trail-1.md)›[ATM Strategy Templates](manage_atm_strategy_templates-1.md)›[Example #1](tutorial_atm_strategy_example_-1.md)›[Example #2](tutorial_atm_strategy_example2-1.md) | Advanced Options   ›[Auto Chase](auto_chase-1.md)›[Auto Reverse](auto_reverse-1.md)›[Shadow Strategy](shadow_strategy-1.md)  Misc   ›[Close at Time](auto_close_position-1.md)›[Indicator Tracking](attachingorderstoindicators-1.md)›[FAQ](faq-1.md) |
 
| playVideo |
| --- |
|  |
## 
## What is an ATM Strategy?
Before you enter a trade you already know where you are going to place your Profit Target(s), where you will set your Stop Loss, and how many contracts you will trade. You may also have rules and conditions for managing your trade such as; once there is 1 point in profit you will move your Stop Loss to breakeven and once there is 2 points in profit you will move your Stop Loss to protect 1 point in profit. These rules and conditions make up your personal trade methodology, or as we call it, your strategy. In NinjaTrader, an ATM Strategy is a collection of orders that represent your entries, exits, stops and targets along with sub-strategies (Auto Breakeven, Auto Chase, Auto Trail etc...) that govern how these orders are managed. By pre-defining your personal trading strategy in NinjaTrader, you are free to concentrate on the trade and not on the management of orders and positions. NinjaTrader does this all for you automatically.
 
## Do I have to use an ATM Strategy?
Absolutely not. NinjaTrader is incredibly flexible in that you can trade independent of an ATM Strategy and manually submit and manage all of your own orders. You can also choose to manage a portion of an open position by an ATM Strategy and leave another portion to be managed independently. It's completely up to you.
 
## What are the advantages to using an ATM Strategy? 
There are several:
- Reduce errors in order management

- Speed (orders are submitted and modified at PC speed instead of human speed)

- Discipline (less prone to applying 'too much' discretion)

- Consistency with your trading

- Reduces emotions

