
Operations > Advanced Trade Management (ATM)
Advanced Trade Management (ATM)
| << [Click to Display Table of Contents](advanced_trade_management_atm.md) >> **Navigation:**     [Operations](operations.md) > Advanced Trade Management (ATM) | [Previous page](operations.md) [Return to chapter overview](operations.md) [Next page](server-side-vs-local-atms.md) |
| --- | --- |
| ATM Overview ATM Strategies can be accessed from the  ATM Strategy Selectors located in various [Order Entry](order_entry.md) interfaces   NinjaTrader provides you with the flexibility to trade with or without an Advanced Trade Management (ATM) Strategy. ATM Strategies are designed to provide discretionary traders with semi-automated features to manage their positions. This is NOT to be confused with NinjaScript Strategies for [automated trading](automated_trading.md) systems. | |
| --- | --- |
| ATM Strategy   ›[Definition and Benefits](atm_strategy.md)›[ATM Strategy Parameters](atm_strategy_parameters.md)›[ATM Strategy Selection Mode](atm_strategy_selection_mode.md)›[Stop Strategy](stop_strategy.md)›[Auto Breakeven](auto_breakeven.md)›[Auto Trail](auto_trail.md)›[ATM Strategy Templates](manage_atm_strategy_templates.md)›[Example #1](tutorial_atm_strategy_example_.md)›[Example #2](tutorial_atm_strategy_example2.md) | Advanced Options   ›[Auto Chase](auto_chase.md)›[Auto Reverse](auto_reverse.md)›[Shadow Strategy](shadow_strategy.md)  Misc   ›[Close at Time](auto_close_position.md)›[Indicator Tracking](attachingorderstoindicators.md)›[FAQ](faq.md) |
 
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

