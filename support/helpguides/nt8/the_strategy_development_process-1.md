
NinjaScript > Educational Resources > Developing Strategies > The Strategy Development Process
The Strategy Development Process
| << [Click to Display Table of Contents](the_strategy_development_process.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Educational Resources](educational_resources-1.md) > [Developing Strategies](developing_strategies-1.md) > The Strategy Development Process | [Previous page](compiling7-1.md) [Return to chapter overview](developing_strategies-1.md) [Next page](working_with_accounts-1.md) |
| --- | --- |
## Describe your Strategy
Describing your strategy means creating a set of objective rules that define the conditions used to enter and exit a market. Describing your strategy always starts with the wizard and then provides the following choices:
 
- Strategy Wizard with Condition Builder - This is a point and click approach for strategy description which is ideal for everyone from the non-programmer, novice programmer and advanced programmer. 

- [NinjaScript Editor](editor-1.md) - This is a modern scripting editor with full inline syntax checking and Intelliprompt. This is a great approach for those who want to manually code their strategy logic. If you are going to self code your strategy, please be familiar with the [OnStateChange()](onstatechange-1.md) and [OnBarUpdate()](onbarupdate-1.md) methods. 

 
## Backtest and Optimize your Strategy
## Once you have completed describing your strategy you can then test it against historical data to objectively determine how the strategy performed on a specific market(s) in the past.
 
- [Strategy Analyzer](strategy_analyzer-1.md) - You can backtest, optimize, and analyze your historical results 

 
At this point in the process you will likely go through an iterative cycle by where you change your strategy description, backtest, change description and backtest until you have a strategy that meets your requirements.
 
## Real-Time Test your Strategy
## It is critical that before you deploy your strategy against your live trading account, that you test it in real-time operation to ensure that the mechanics (operation) of your strategy behaves as you would expect it to. In addition, you can also forward test your strategy using real-time market data against the NinjaTrader [trade simulation engine](simulation-1.md). NinjaTrader provides several options for real-time testing:
 
- [Simulated Data Feed Connection](simulated_data_feed_connection-1.md) - This is an random internally generated market with user controlled trend and is great for force testing operation of a strategy

- [Playback Connection](playback_connection-1.md) - Record, replay at user defined speeds multiple markets simultaneously and run your strategies

- [Real-time Simulation](simulation-1.md) - Connect to your broker or market data vendor in real-time and run your strategies through our state of the art simulation engine

 
You can [run your strategy](running_ninjascript_strategies-1.md) from either a chart or the Strategies tab of the Control Center window. You can generate real-time [strategy performance](strategies_tab2.md) data from the Strategies tab.
 
## Running on your Live Trading Account
Now that you have described, backtested and real-time tested your strategy, you are ready to [automate your strategy against your live trading account](running_ninjascript_strategies-1.md). A few tips you should know:
 
- Please make sure you fully understand the [live run-time options](strategies_tab2.md)

- Live strategy [performance will vary](discrepancies_real-time_vs_bac-1.md) from your backtested results

- Please make sure you fully understand [Strategy Position vs Account Position](strategy_position_vs_account_p-1.md)... your strategy position is not a one-to-one relationship with your brokerage account position... you may need to synchronize if they are not synchronized. 

- Strategies are automatically terminated (stop running) on NinjaTrader shut down

- Automated trading does not mean go fishing while your computer trades for you. We highly recommend that you are within close proximity to your computer while it is running an automated trading strategy; you never know what can go wrong

- You can run multiple trading strategies at the same time in the same market
