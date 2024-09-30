
Operations > Strategy Analyzer > Backtest a Strategy

Backtest a Strategy

| << [Click to Display Table of Contents](backtest_a_strategy.md) >> **Navigation:**     [Operations](operations.md) > [Strategy Analyzer](strategy_analyzer.md) > Backtest a Strategy | [Previous page](strategy_analyzer_layout.md) [Return to chapter overview](strategy_analyzer.md) [Next page](optimize_a_strategy.md) |
| --- | --- |
A backtest allows you to analyze the historical performance of a strategy. In order to run a backtest you will need:
 
- Access to [historical data](data_by_provider.md)

- Custom NinjaScript *[strategy](strategy.md) 

 

| Tip:  There are several pre-defined sample strategies that are installed with NinjaTrader that you can explore. |
| --- |
 

| playVideo |
| --- |
|  |
 

| Notes:  1.By default, the Strategy Analyzer downloads data from your market data provider which can slow down backtest progress for larger tests.  If you wish to disable this feature and operate using existing data in your database, right click on the Strategy Analyzer > select Properties > enable Use Local Data Only 2.The [IncludeTradeHistoryInBacktest](includetradehistoryinbacktest.md) property is set to false by default when a strategy is applied in the Strategy Analyzer for backtesting. This provides for leaner memory usage, but at the expense of not being able to access Trade objects for historical trades. Thus, fields such as [SystemPerformance.AllTrades.Count](alltrades.md) that rely on references to Trade objects will not have any such references to work with. If you would like to save these objects for reference in your code, you can set IncludeTradeHistoryInBacktest to true in the Configure state. For more information, see the [Working with Historical Trade Data](strategyanalyzer_properties_2.md) page.3.A certain level of discrepancy between realtime and backtest results would be expected, especially on more exotic barstypes like Point & Figure and Renko, please also review [this page](discrepancies_real-time_vs_bac.md) for more details. |
| --- |
![tog_minus](tog_minus.gif)

| Start a Backtest To run a Backtest of a strategy:   StrategyAnalyzer_StartBacktest   1.Select the Backtest type of "Backtest"2.Select the strategy you would like to backtest3.Set the strategy and backtest parameters (See the "Understanding backtest properties" section below for property definitions) 4.Select the instrument and Data Series you would like to backtest5.Select the "Run" button to start the backtest    | Tip:  You can optionally configure a sound to be played when the Backtest completes.  To enable this option, right click on the Strategy Analyzer > Properties > Play sound on complete > Choose the sound file you wish to play (must be a .WAV) | | --- | |
| --- | --- |
![tog_minus](tog_minus.gif)        [Understanding backtest properties](javascript:HMToggle('toggle','UnderstandingBacktestProperties','UnderstandingBacktestProperties_ICON'))

| Backtest Properties The following properties are available within the Backtest window:   StrategyAnalyzer_Settings_Properties     | General |  | | --- | --- | | Backtest type | Sets the backtest type. 1. [Backtest](backtest_a_strategy.md) 2. [Optimization](optimize_a_strategy.md) 3. [Walk Forward Optimization](walk_forward_optimize_a_strate.md) 4. [Multi-Objective Optimization](multi-objective_optimization.md) | | Strategy | Sets the strategy you would like to test. | | Strategy parameters |  | | Parameters (...) | Each strategy parameter is listed dynamically depending on the strategy selection | | Data Series |  | | Instrument | Sets the instrument or list you wish to test on | | Price based on | Sets the type of market data used to drive the Data Series | | Type | Sets the bar type of the Data Series. | | Value | Sets the Data Series value. | | Time frame |  | | Start date | Sets the start date for the test period | | End date | Sets the end date for the test period | | Trading hours | Sets the trading hour template for the Data Series. (See the "[Trading Hours](trading_hours.md)" section of the Help Guide for more information) | | Break at EOD | Enables or disables the bars being reset at EOD (End Of Day). (See the ["Break at EOD"](break_at_eod.md) section of the Help Guide for more information) | | Set up |  | | Include commission | Enables or disables commissions in the backtest performance results (See the "[Commission Tab](understanding_commissions.md)" section of the Help Guide for more information) | | Maximum bars look back | Max number of bars used for calculating an indicator's value.  The "[TwoHundredFiftySix](maximumbarslookback.md)" setting is the most memory friendly. | | Bars required to trade | Sets the minimum number of bars required before orders will be allowed to be submitted | | Historical fill processing |  | | Order fill resolution | Sets the order fill resolution to be used for the backtest. (See the "[Understanding Historical Fill Processing](understanding_historical_fill_.md)" section of the Help Guide for more information) | | Fill limit orders on touch | Enables or disables the filling of limit orders on a single touch of price action. | | Slippage | Set the amount of slippage in ticks to apply to market / stop market / Market-if-touched order executions (default is 0) Note: In the Summary the Slippage is displayed in points. | | Order handling |  | | Entries per direction | Sets the maximum number of entries allowed per direction while a position is active based on the "[Entry handling](entryhandling.md)" property | | Entry handling | Sets the manner in how entry orders are handled. If set to "AllEntries", the strategy will process all entry orders until the maximum allowable entries set by the "Entries per direction" property has been reached while in an open position. If set to "UniqueEntries", strategy will process entry orders until the maximum allowable entries set by the "Entries per direction" property per each uniquely named entry. | | Exit on session close | When enabled, open positions are closed on the last bar of a session | | Order properties |  | | Set order quantity | Sets how the order size is determined, options are: "by default quantity" - User defined order size "by strategy" - Takes the order size specified programmatically within the strategy | | Time in force | Sets the order's time in force | |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |

