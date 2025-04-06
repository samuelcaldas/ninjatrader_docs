



Strategy

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\strategy.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) >  Strategy | [Previous page](signature-1.htm) [Return to chapter overview](language_reference_wip-1.htm) [Next page](strategy_account-1.htm) |

The methods and properties covered in this section are unique to custom strategy development.

In this section
---------------

|  |  |
| --- | --- |
| [Account](strategy_account-1.htm) | Represents the real-world or simulation Account configured for the strategy. |
| [AddChartIndicator()](addchartindicator-1.htm) | Adds an indicator to the strategy only for the purpose of displaying it on a chart. |
| [AddPerformanceMetric()](addperformancemetric-1.htm) | Adds an instance of custom [Performance Metric](performancemetrics-1.htm) to a strategy used in strategy calculations. |
| [ATM Strategy Methods](atm_strategy_methods-1.htm) | Adds ATM strategies to manage your position |
| [BarsRequiredToTrade](barsrequiredtotrade-1.htm) | The number of historical bars required before the strategy starts processing order methods called in the [OnBarUpdate()](onbarupdate-1.htm) method. |
| [BarsSinceEntryExecution()](barssinceentryexecution-1.htm) | Returns the number of bars that have elapsed since the last specified entry. |
| [BarsSinceExitExecution()](barssinceexitexecution-1.htm) | Returns the number of bars that have elapsed since the last specified exit. |
| [ChartIndicators](chartindicators-1.htm) | Contains a collection of Indicators which have been added to the strategy instance using [AddChartIndicator()](addchartindicator-1.htm). |
| [CloseStrategy()](closestrategy-1.htm) | Cancels all working orders, closes any existing positions, and finally disables the strategy. |
| [ConnectionLossHandling](connectionlosshandling-1.htm) | Sets the manner in which your strategy will behave when a connection loss is detected. |
| [DaysToLoad](daystoload-1.htm) | Determines the number of trading days which will be configured when loading the strategy from the Strategies Grid. |
| [DefaultQuantity](defaultquantity-1.htm) | An order size variable that can be set either programmatically or overriden via the Strategy that determines the quantity of an entry order. |
| [DisconnectDelaySeconds](disconnectdelayseconds-1.htm) | Determines the amount of time a disconnect would have to last before [connection loss handling](connectionlosshandling-1.htm) takes action. |
| [EntriesPerDirection](entriesperdirection-1.htm) | Determines the maximum number of entries allowed per direction while a position is active based on the [EntryHandling](entryhandling-1.htm) property. |
| [EntryHandling](entryhandling-1.htm) | Sets the manner in how entry orders will handle. |
| [Execution](execution-1.htm) | Represents a read only interface that exposes information regarding an execution (filled order) resulting from an order and is passed as a parameter in the [OnExecutionUpdate()](onexecutionupdate-1.htm) method. |
| [ExitOnSessionCloseSeconds](exitonsessioncloseseconds-1.htm) | The number of seconds before the actual session end time that the "[IsExitOnSessionCloseStrategy](isexitonsessionclosestrategy-1.htm)" function will trigger. |
| [IncludeCommission](includecommission-1.htm) | Determines if the strategy performance results will include commission on a historical backtest. |
| [IncludeTradeHistoryInBacktest](includetradehistoryinbacktest-1.htm) | Determines if the strategy will save orders, trades, and execution history. |
| [IsAdoptAccountPositionAware](isadoptaccountpositionaware-1.htm) | Determines if the strategy is programmed in a manner capable of handling  real-world account positions. |
| [IsExitOnSessionCloseStrategy](isexitonsessionclosestrategy-1.htm) | Determines if the strategy will cancel all strategy generated orders and close all open strategy positions at the close of the session. |
| [IsFillLimitOnTouch](isfilllimitontouch-1.htm) | Determines if the strategy will use a more liberal fill algorithm for back-testing purposes only. |
| [IsInstantiatedOnEachOptimizationIteration](isinstantiatedoneachoptimizationiteration-1.htm) | Determines if the strategy should be re-instantiated (re-created) after each optimization run when using the [Strategy Analyzer Optimizer](optimize_a_strategy-1.htm). |
| [IsInStrategyAnalyzer](isinstrategyanalyer-1.htm) | Determines if the current NinjaScript Strategy is run from a Strategy Analyzer chart. |
| [IsTradingHoursBreakLineVisible](istradinghoursbreaklinevisible-1.htm) | Plots trading hours break lines on the indicator panel. |
| [IsWaitUntilFlat](iswaituntilflat-1.htm) | Indicates the strategy is currently waiting until a flat position is detected before submitting live orders. |
| [NumberRestartAttempts](numberrestartattempts-1.htm) | Determines the maximum number of restart attempts allowed within the last x minutes defined in [RestartsWithinMinutes](restartswithinminutes-1.htm) when the strategy experiences a connection loss. |
| [OnAccountItemUpdate()](onaccountitemupdate-1.htm) | An event driven method used for strategies which is called for each AccountItem update for the account on which the strategy is running. |
| [OnExecutionUpdate()](onexecutionupdate-1.htm) | An event driven method which is called on an incoming execution of an order managed by a strategy. |
| [OnOrderTrace()](onordertrace-1.htm) | An event driven method used for strategies which will allow you to customize the output of [TraceOrders](traceorders-1.htm). |
| [OnOrderUpdate()](onorderupdate-1.htm) | An event driven method which is called each time an order managed by a strategy changes state. |
| [OnPositionUpdate()](onpositionupdate-1.htm) | An event driven method which is called each time the position of a strategy changes state. |
| [OptimizationPeriod](order-1.htm) | Reserved for [Walk-Forward Optimization](walk_forward_optimize_a_strate-1.htm), this property determines the number of days used for the "in sample" backtest period for a given strategy.  See also [TestPeriod](testperiod-1.htm). |
| [Order](order-1.htm) | Represents a read only interface that exposes information regarding an order. |
| [Order Methods](order_methods-1.htm) | NinjaScript provides several approaches you can use for order placement within your NinjaScript strategy. |
| [OrderFillResolution](orderfillresolution-1.htm) | Determines how strategy orders are filled during historical states. |
| [OrderFillResolutionType](orderfillresolutiontype-1.htm) | Determines the bars type which will be used for historical fill processing. |
| [OrderFillResolutionValue](orderfillresolutionvalue-1.htm) | Determines the bars period interval value which will be used for historical fill processing. |
| [PerformanceMetrics](strategy_performancemetrics-1.htm) | Holds an array of [PerformanceMetrics](performancemetrics-1.htm) objects that represent custom metrics that can be used for strategy calcuations. |
| [Plots](strategy_plots-1.htm) | A collection holding all of the Plot objects that define their visualization characteristics. |
| [Position](position-1.htm) | Represents position related information that pertains to an instance of a strategy. |
| [PositionAccount](positionaccount-1.htm) | Represents position related information that pertains to real-world account (live or simulation). |
| [Positions](positions-1.htm) | Holds an array of [Position](position-1.htm) objects that represent positions managed by the strategy. |
| [PositionsAccount](positionsaccount-1.htm) | Holds an array of [PositionAccount](positionaccount-1.htm) objects that represent positions managed by the strategy's account. |
| [RealtimeErrorHandling](realtimeerrorhandling-1.htm) | Defines the behavior of a strategy when a strategy generated order is returned from the broker's server in a "Rejected" state. |
| [RestartsWithinMinutes](restartswithinminutes-1.htm) | Determines within how many minutes the strategy will attempt to restart. |
| [SetOrderQuantity](setorderquantity-1.htm) | Determines how order sizes are calculated for a given strategy. |
| [Slippage](slippage-1.htm) | Sets the amount of slippage in ticks per execution used in performance calculations during backtests. |
| [StartBehavior](startbehavior-1.htm) | Sets the start behavior of the strategy. See [Syncing Account Positions](syncing_account_positions-1.htm) for more information. |
| [StopTargetHandling](stoptargethandling-1.htm) | Determines how stop and target orders are submitted during an entry order execution. |
| [StrategyBaseConverter](strategybaseconverter-1.htm) | A custom TypeConverter class handling the designed behavior of an strategy's property descriptor collection. |
| [SystemPerformance](systemperformance-1.htm) | The SystemPerformance object holds all trades and trade performance data generated by a strategy. |
| [TestPeriod](testperiod-1.htm) | Reserved for [Walk-Forward Optimization](walk_forward_optimize_a_strate-1.htm), this property determines the number of days used for the "out of sample" backtest period for a given strategy. |
| [TimeInForce](timeinforce-1.htm) | Sets the time in force property for all orders generated by a strategy. |
| [TraceOrders](traceorders-1.htm) | Determines if OnOrderTrace() would be called for a given strategy. |
| [Trade](trade-1.htm) | A Trade is a completed buy/sell or sell/buy transaction. It consists of an entry and exit execution. |
| [TradeCollection](tradecollection-1.htm) | A collection of [Trade](trade-1.htm) objects. |
| [TradesPerformanceValues](tradesperformancevalues-1.htm) | Performance values of a [collection](tradecollection-1.htm) of [Trade](trade-1.htm) objects. |
| [WaitForOcoClosingBracket](waitforococlosingbracket-1.htm) | Determines if the strategy will submit both legs of an OCO bracket before submitting the pair to the broker. |