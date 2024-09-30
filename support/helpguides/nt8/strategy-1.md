
NinjaScript \> Language Reference \> Strategy
Strategy
| \<\< [Click to Display Table of Contents](strategy.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> Strategy | [Previous page](signature-1.md) [Return to chapter overview](language_reference_wip-1.md) [Next page](strategy_account-1.md) |
| --- | --- |
The methods and properties covered in this section are unique to custom strategy development.
 
## In this section
| [Account](strategy_account-1.md) | Represents the real\-world or simulation Account configured for the strategy. |
| --- | --- |
| [AddChartIndicator()](addchartindicator-1.md) | Adds an indicator to the strategy only for the purpose of displaying it on a chart. |
| [AddPerformanceMetric()](addperformancemetric-1.md) | Adds an instance of custom [Performance Metric](performancemetrics-1.md) to a strategy used in strategy calculations. |
| [ATM Strategy Methods](atm_strategy_methods-1.md) | Adds ATM strategies to manage your position |
| [BarsRequiredToTrade](barsrequiredtotrade-1.md) | The number of historical bars required before the strategy starts processing order methods called in the [OnBarUpdate()](onbarupdate-1.md) method. |
| [BarsSinceEntryExecution()](barssinceentryexecution-1.md) | Returns the number of bars that have elapsed since the last specified entry. |
| [BarsSinceExitExecution()](barssinceexitexecution-1.md) | Returns the number of bars that have elapsed since the last specified exit. |
| [ChartIndicators](chartindicators-1.md) | Contains a collection of Indicators which have been added to the strategy instance using [AddChartIndicator()](addchartindicator-1.md). |
| [CloseStrategy()](closestrategy-1.md) | Cancels all working orders, closes any existing positions, and finally disables the strategy. |
| [ConnectionLossHandling](connectionlosshandling-1.md) | Sets the manner in which your strategy will behave when a connection loss is detected. |
| [DaysToLoad](daystoload-1.md) | Determines the number of trading days which will be configured when loading the strategy from the Strategies Grid. |
| [DefaultQuantity](defaultquantity-1.md) | An order size variable that can be set either programmatically or overriden via the Strategy that determines the quantity of an entry order. |
| [DisconnectDelaySeconds](disconnectdelayseconds-1.md) | Determines the amount of time a disconnect would have to last before [connection loss handling](connectionlosshandling-1.md) takes action. |
| [EntriesPerDirection](entriesperdirection-1.md) | Determines the maximum number of entries allowed per direction while a position is active based on the [EntryHandling](entryhandling-1.md) property. |
| [EntryHandling](entryhandling-1.md) | Sets the manner in how entry orders will handle. |
| [Execution](execution-1.md) | Represents a read only interface that exposes information regarding an execution (filled order) resulting from an order and is passed as a parameter in the [OnExecutionUpdate()](onexecutionupdate-1.md) method. |
| [ExitOnSessionCloseSeconds](exitonsessioncloseseconds-1.md) | The number of seconds before the actual session end time that the "[IsExitOnSessionCloseStrategy](isexitonsessionclosestrategy-1.md)" function will trigger. |
| [IncludeCommission](includecommission-1.md) | Determines if the strategy performance results will include commission on a historical backtest. |
| [IncludeTradeHistoryInBacktest](includetradehistoryinbacktest-1.md) | Determines if the strategy will save orders, trades, and execution history. |
| [IsAdoptAccountPositionAware](isadoptaccountpositionaware-1.md) | Determines if the strategy is programmed in a manner capable of handling  real\-world account positions. |
| [IsExitOnSessionCloseStrategy](isexitonsessionclosestrategy-1.md) | Determines if the strategy will cancel all strategy generated orders and close all open strategy positions at the close of the session. |
| [IsFillLimitOnTouch](isfilllimitontouch-1.md) | Determines if the strategy will use a more liberal fill algorithm for back\-testing purposes only. |
| [IsInstantiatedOnEachOptimizationIteration](isinstantiatedoneachoptimizationiteration-1.md) | Determines if the strategy should be re\-instantiated (re\-created) after each optimization run when using the [Strategy Analyzer Optimizer](optimize_a_strategy-1.md). |
| [IsInStrategyAnalyzer](isinstrategyanalyer-1.md) | Determines if the current NinjaScript Strategy is run from a Strategy Analyzer chart. |
| [IsTradingHoursBreakLineVisible](istradinghoursbreaklinevisible-1.md) | Plots trading hours break lines on the indicator panel. |
| [IsWaitUntilFlat](iswaituntilflat-1.md) | Indicates the strategy is currently waiting until a flat position is detected before submitting live orders. |
| [NumberRestartAttempts](numberrestartattempts-1.md) | Determines the maximum number of restart attempts allowed within the last x minutes defined in [RestartsWithinMinutes](restartswithinminutes-1.md) when the strategy experiences a connection loss. |
| [OnAccountItemUpdate()](onaccountitemupdate-1.md) | An event driven method used for strategies which is called for each AccountItem update for the account on which the strategy is running. |
| [OnExecutionUpdate()](onexecutionupdate-1.md) | An event driven method which is called on an incoming execution of an order managed by a strategy. |
| [OnOrderTrace()](onordertrace-1.md) | An event driven method used for strategies which will allow you to customize the output of [TraceOrders](traceorders-1.md). |
| [OnOrderUpdate()](onorderupdate-1.md) | An event driven method which is called each time an order managed by a strategy changes state. |
| [OnPositionUpdate()](onpositionupdate-1.md) | An event driven method which is called each time the position of a strategy changes state. |
| [OptimizationPeriod](order-1.md) | Reserved for [Walk\-Forward Optimization](walk_forward_optimize_a_strate-1.md), this property determines the number of days used for the "in sample" backtest period for a given strategy.  See also [TestPeriod](testperiod-1.md). |
| [Order](order-1.md) | Represents a read only interface that exposes information regarding an order. |
| [Order Methods](order_methods-1.md) | NinjaScript provides several approaches you can use for order placement within your NinjaScript strategy. |
| [OrderFillResolution](orderfillresolution-1.md) | Determines how strategy orders are filled during historical states. |
| [OrderFillResolutionType](orderfillresolutiontype-1.md) | Determines the bars type which will be used for historical fill processing. |
| [OrderFillResolutionValue](orderfillresolutionvalue-1.md) | Determines the bars period interval value which will be used for historical fill processing. |
| [PerformanceMetrics](strategy_performancemetrics-1.md) | Holds an array of [PerformanceMetrics](performancemetrics-1.md) objects that represent custom metrics that can be used for strategy calcuations. |
| [Plots](strategy_plots-1.md) | A collection holding all of the Plot objects that define their visualization characteristics. |
| [Position](position-1.md) | Represents position related information that pertains to an instance of a strategy. |
| [PositionAccount](positionaccount-1.md) | Represents position related information that pertains to real\-world account (live or simulation). |
| [Positions](positions-1.md) | Holds an array of [Position](position-1.md) objects that represent positions managed by the strategy. |
| [PositionsAccount](positionsaccount-1.md) | Holds an array of [PositionAccount](positionaccount-1.md) objects that represent positions managed by the strategy's account. |
| [RealtimeErrorHandling](realtimeerrorhandling-1.md) | Defines the behavior of a strategy when a strategy generated order is returned from the broker's server in a "Rejected" state. |
| [RestartsWithinMinutes](restartswithinminutes-1.md) | Determines within how many minutes the strategy will attempt to restart. |
| [SetOrderQuantity](setorderquantity-1.md) | Determines how order sizes are calculated for a given strategy. |
| [Slippage](slippage-1.md) | Sets the amount of slippage in ticks per execution used in performance calculations during backtests. |
| [StartBehavior](startbehavior-1.md) | Sets the start behavior of the strategy. See [Syncing Account Positions](syncing_account_positions-1.md) for more information. |
| [StopTargetHandling](stoptargethandling-1.md) | Determines how stop and target orders are submitted during an entry order execution. |
| [StrategyBaseConverter](strategybaseconverter-1.md) | A custom TypeConverter class handling the designed behavior of an strategy's property descriptor collection. |
| [SystemPerformance](systemperformance-1.md) | The SystemPerformance object holds all trades and trade performance data generated by a strategy. |
| [TestPeriod](testperiod-1.md) | Reserved for [Walk\-Forward Optimization](walk_forward_optimize_a_strate-1.md), this property determines the number of days used for the "out of sample" backtest period for a given strategy. |
| [TimeInForce](timeinforce-1.md) | Sets the time in force property for all orders generated by a strategy. |
| [TraceOrders](traceorders-1.md) | Determines if OnOrderTrace() would be called for a given strategy. |
| [Trade](trade-1.md) | A Trade is a completed buy/sell or sell/buy transaction. It consists of an entry and exit execution. |
| [TradeCollection](tradecollection-1.md) | A collection of [Trade](trade-1.md) objects. |
| [TradesPerformanceValues](tradesperformancevalues-1.md) | Performance values of a [collection](tradecollection-1.md) of [Trade](trade-1.md) objects. |
| [WaitForOcoClosingBracket](waitforococlosingbracket-1.md) | Determines if the strategy will submit both legs of an OCO bracket before submitting the pair to the broker. |
