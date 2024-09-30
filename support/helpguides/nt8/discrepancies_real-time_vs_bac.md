
Operations > Strategy Analyzer > Discrepancies: Real-Time vs Backtest

Discrepancies: Real-Time vs Backtest
| << [Click to Display Table of Contents](discrepancies_real-time_vs_bac.md) >> **Navigation:**     [Operations](operations.md) > [Strategy Analyzer](strategy_analyzer.md) > Discrepancies: Real-Time vs Backtest | [Previous page](2d__3d_optimization_graphs.md) [Return to chapter overview](strategy_analyzer.md) [Next page](saving_strategy_parameter_temp.md) |
| --- | --- |
You should expect that a strategy running real-time (live [brokerage account](connecting.md), live [market simulation](simulation.md), [Playback connection](playback_connection.md) etc...) will produce different results than the performance results generated during a backtest. This difference may be more easily seen on certain Bars types (e.g. Point and Figure or Renko) than others due to their inherent nature in bar formation.
 
## Getting Filled on an Order
- Fills are determined based on 4 data points, OHLC of a bar since that is the only information that is known during a backtest. 

- During simulation using real-time live market data or Playback, the fill algorithm is dynamic in that it uses incoming market data (both price and volume) to determine if an order should be filled or not. 

- During real-time live brokerage trading, orders are filled according to market dynamics. 

 
As you can see, there are three distinctly different models for how and when an order may be filled. This is why you may see orders NOT fill in real-time that you may otherwise expect to see filled based on your backtesting results.
 
## The Fill Price of Orders
- During a backtest assumptions are made on the fill price of an order is based on the OHLC of a bar and the price of the order itself. You can also have differences depending on which fill algorithm you choose. 

- During simulation using real-time market data or Playback, the fill price is based on incoming market data and volume, you may receive better or worse fill prices dependant on where the bid or ask price is and what volume is available at this market prices. 

- During real-time brokerage trading, orders are filled according to market dynamics. 

 
As you can see, there are three different models on what price an order can be filled at.
 
## Running a Strategy at the Close of a Bar or Tick by Tick
- During backtest, strategies can ONLY be processed at the close of each bar. 

- During real-time operation, you have a choice to run a strategy tick by tick ([Calculate](running_a_ninjascript_strategy.md) set to 'On Each Tick') which can produce different results. This is because you can have a signal that executes an order at the close of a bar but when running tick by tick, while in a bar a signal condition can be true although its false at the close of the same bar. 

 
## Differences in chart data
- If you run a strategy in real-time on DAY1 and then DAY2, you are now backtesting your strategy on DAY1 data instead of processing like it did in real-time so there could be differences. You should understand how [chart bars are built](how_bars_are_built.md).

- If using tick based charts, all it takes is a single tick difference between real-time and historical data to generate completely different looking charts. This in turn would impact the calculations of your strategy should the data sets be different.

 
## Backtesting Renko bars and HeikenAshi bars
- Standard Renko bars can be challenging for backtesting as the barstypes use functionality to remove the last bar in the data series and replace the bar with a new Open price.This is done with reversals and cannot be simulated historically, because the bars are already built. Testing may be done with the Playback Connection to fully simulate standard Renko bars with accurate reversals and order fills.

- Some custom Renko bars aim to work around this limitation and often substitute a "fake" open price in the bar. This will result in Standard Order Fill Resolution estimating fill prices using OHLC values that are not 100% reflective of actual price action which can create discrepancies with results. [High Order Fill Resolution](understanding_historical_fill_.md) should be used in cases like this, or the strategy should be written to [submit orders to a single tick data series](backtesting_ninjascript_strate.md).

- Similarly to custom Renko bars which use a "fake" open price, HeikenAshi bars alter the OHLC values of the data series to use the HeikenAshi moving average values. Since these are not real prices, it would be best to consider the same workarounds as noted above, or to use a HeikenAshi indicator. Please inquire with [[email protected]](/cdn-cgi/l/email-protection#3f4f535e4b59504d524c4a4f4f504d4b7f515651555e4b4d5e5b5a4d115c5052) for more information on how to find a HeikenAshi indicator.
