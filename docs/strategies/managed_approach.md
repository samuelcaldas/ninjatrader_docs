# Managed Approach

The Managed approach in NinjaScript is designed to offer the greatest ease of use for beginner to intermediate programmers. The order methods are wrapped in a convenience layer that allows you to focus on your system's trading rules, leaving the underlying mechanics of order management and the relationships between entry orders, exit orders, and positions to NinjaTrader. This approach is best suited for simple to moderate order complexity, and can be further broken down into a Basic/Common Managed approach and a more [Advanced](advanced_order_handling.md) Managed approach. The following section will discuss the use of the Basic/Common approach.

A few key points to keep in mind:

- Orders are submitted as live and working when a strategy is running in real-time

- Profit target, stop loss and trail stop orders are submitted immediately when an entry order is filled, and are tied together via OCO (One Cancels Other)

- Order changes and cancellations are queued in the event that the order is in a state where it can't be cancelled or modified

- By default, orders submitted via Entry() and Exit() methods automatically cancel at the end of a bar if not re-submitted

- Entry() methods will reverse the position automatically. For example if you are in a 1 contract long position and now call EnterShort() -> you will see 2 executions, one to close the prior long position and the other to get you into the desired 1 contract short position.

\* Via the [SetProfitTarget()](setprofittarget.md), [SetStopLoss()](setstoploss.md), [SetTrailStop()](settrailstop.md) and [SetParabolicStop](setparabolicstop.md) methods

```csharp
![Ns](../images/ns.png)

protected override void OnBarUpdate()
{
    // Entry condition
    if (Close[0] > SMA(20)[0])
    EnterLongLimit(GetCurrentBid());
}
This technique allows you the quickest and easiest order submission method suitable for programmers of all levels. Should you want to submit an order and not have to keep re-submitting it to keep it alive you can use an [advanced approach](advanced_order_handling.md) reserved for experienced programmers, which includes an option to keep orders alive until specifically canceled in code.

![Ns](../images/ns.png)

```

- Used to tie an exit method to a specific position
- Used to identify unique entries in a strategy    Below is an example of placing an Market entry order and an associated Limit exit order, tied together by the signal name of the entry order.    
```csharp
protected override void OnBarUpdate()
{
    if (CurrentBar < 1) return;
    if (Close[0] > Close[1])
    {
        // Place a Market order to enter long
        EnterLong("longEntry");
        // Manually place a Profit Target 10 ticks above the current price, tied to the entry order's SignalName
        ExitLongLimit(Close[0] + (10 \* TickSize), "longEntry");
    }
}
Defining how Entry Methods are Processed in a Strategy You can limit how many entry methods are processed by determining the maximum number of entries in a single direction across all entry methods, or across unique signal names. The following properties can be set in the Strategies window when adding a strategy to a chart or to the Strategies tab of the Control Center window.
•[EntriesPerDirection](entriesperdirection.md) property - Sets the maximum number of entries in a single direction
•[EntryHandling](entryhandling.md) property - Determines if EntriesPerDirection applies across all entries or for entries with specified signal names
The example code below illustrates how the above properties control the processing of entry methods. The code contains two entry conditions and two EnterLong methods, each tagged with unique signal names.

```

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        EntriesPerDirection = 1;
        EntryHandling = EntryHandling.AllEntries;
    }
}
protected override void OnBarUpdate()
{
    // Entry condition 1
    if (CrossAbove(SMA(10), SMA(20), 1))
    EnterLong("Condition 1 Entry");
    // Entry condition 2
    if (CrossAbove(RSI(14, 3), 30, 1))
    EnterLong("Condition 2 Entry");
}
Entry Methods on Multi-Instrument Strategies
When running strategies that submit orders to multiple instruments, entry methods will submit orders to the instrument referenced by the [BarsInProgress](../language_reference/barsinprogress.md). The following example assumes that the strategy is running on a 1 minute E-Mini S&P 500 chart. It adds an NQ data series, then enters a position on both instruments.

```

```csharp
protected override void OnStateChange()
{
    AddDataSeries("NQ 09-14", BarsPeriodType.Minute, 1);
}
protected override void OnBarUpdate()
{
    if (BarsInProgress == 0)
    EnterLong("ES Trade");
    else if (BarsInProgress == 1)
    EnterLong("NQ Trade");
}
More information on using BarsInProgress to filter instruments can be found in the [Advanced Order Handling](advanced_order_handling.md) page.
```

## Quantity Type and TIF

> You can set the entry order quantity and order type directly in code via the following properties:
- QuantityType - Sets the order quantity is taken from the entry method quantity property or the default strategy quantity size
- [TimeInForce](timeinforce.md) propery - Sets the time in force of the order

## How to close a position

```csharp
protected override void OnBarUpdate()
{
    if (CrossAbove(SMA(10), SMA(20), 1))
    EnterLong(3);
    ExitLong(1);
}
FromEntrySignal -- Using Signal Names in Exit Methods Identifying entries with a signal name allows you to place multiple unique entries within a single strategy and call exit methods with specified signal names, so that only a position created with the specified signal name is closed. In the example below, there are two entry conditions which create positions, and two exit conditions specifying which position to close based on the signal name.

```

```csharp
protected override void OnBarUpdate()
{
    // Entry condition 1
    if (CrossAbove(SMA(10), SMA(20), 1))
    EnterLong("Condition 1 Entry");
    // Entry condition 2
    if (CrossAbove(RSI(14, 3), 30, 1))
    EnterLong("Condition 2 Entry");
    // Closes the position created by entry condition 1
    if (CrossBelow(SMA(10), SMA(20), 1))
    ExitLong("Condition 1 Entry");
    // Closes the position created by entry condition 2
    if (CrossBelow(RSI(14, 3), 70, 1))
    ExitLong("Condition 2 Entry");
}

```

> **Tip:** If you do not specify a "fromEntrySignal" parameter the entire position is exited rendering your strategy flat.

```csharp
protected override void OnBarUpdate()
{
    if (Position.MarketPosition == MarketPosition.Flat)
    {
        // Entry condition 1
        if (CrossAbove(SMA(10), SMA(20), 1))
        EnterLong("Condition 1 Entry");
    }
    if (Position.MarketPosition != MarketPosition.Flat)
    {
        // Scale in condition 2 for position management
        if (CrossAbove(RSI(14, 3), 30, 1))
        EnterLong("Condition 2 Entry");
        // Exit all positions using an empty string (could also use string.Empty)
        if (CrossBelow(SMA(10), SMA(20), 1))
        ExitLong("Exit All", "");
    }
}
```

## Understanding core order objects

> When using order methods such as [EnterLong()](enterlong.md), [ExitShortLimit()](exitshortlimit.md), etc, a direct [order object](order.md) is returned for the NinjaTrader Core.  These objects can be used throughout the lifetime of your strategy to provide additional metadata concerning your strategy, as well as apply advanced concepts such as [CancelOrder()](managed_cancelorder.md) and [ChangeOrder()](managed_changeorder.md).  More information about this advanced concept which is discussed under the [Advanced Order Handling](advanced_order_handling.md) section

## Internal Order Handling Rules that Reduce Unwanted Positions

To prevent situations in real-time in which you may have multiple orders working to accomplish the same task, there are some "under the hood" rules that a NinjaScript strategy follows when Managed order methods are called. For example, if your strategy had a limit order for 1 contract working as a Profit Target, but then your strategy was also programmed to reverse the position at the price very close to the target limit order, then submitting both orders can be risky, since it could lead to a larger position than the strategy is designed to enter if both orders got filled in quick succession by the exchange.

![Ns](../images/ns.png)

> **Note:** These rules do not apply to market orders, such as ExitLong() or ExitShort().

    For the most part, you do not need to be intimately familiar with these rules as you develop your strategies. It is all taken care of for you internally within a strategy. If a rule is violated, you will be notified through an error log in the Control Center Log tab.    |  

> **Note:** To prevent excessive logging which could degrade performance, you will only be notified of the very first order which has violated an order handling rule. Subsequent orders which violate a rule will not be notified through the error log.

    The following rules are true per unique signal name:    Methods that generate orders to enter a position will be ignored if:
- A position is open and an order submitted by a non market order exit method ([ExitLongLimit()](exitlonglimit.md) for example) is active and the order is used to open a position in the opposite direction
- A position is open and an order submitted by a set method ([SetStopLoss()](setstoploss.md) for example) is active and the order is used to open a position in the opposite direction
- A position is open and two or more Entry methods to reverse the position are entered together. In this case the second Entry order will be ignored.
- The strategy position is flat and an order submitted by an enter method ([EnterLongLimit()](enterlonglimit.md) for example) is active and the order is used to open a position in the opposite direction
- The entry signal name is not unique    Methods that generate orders to exit a position will be ignored if:
- A position is open and an order submitted by an enter method ([EnterLongLimit()](enterlonglimit.md) for example) is active and the order is used to open a position in the opposite direction
- A position is open and an order submitted by a set method ([SetStopLoss()](setstoploss.md) for example) is active    Set() methods that generate orders to exit a position will be ignored if:
- A position is open and an order submitted by an enter method ([EnterLongLimit()](enterlonglimit.md) for example) is active and the order is used to open a position in the opposite direction
- A position is open and an order submitted by a non market order exit method ([ExitLongLimit()](exitlonglimit.md) for example) is active |

![Ns](../images/ns.png)

| Name / Option | Description |
| --- | --- |
| [Advanced Order Handling](advanced_order_handling.md) | Through advanced order handling you can submit, change and cancel orders at your discretion through any event-driven method within a strategy. |
| [CancelOrder()](managed_cancelorder.md) | Cancels a specified order. |
| [ChangeOrder()](managed_changeorder.md) | Amends a specified [Order](order.md). |
| [EnterLong()](enterlong.md) | Generates a buy market order to enter a long position. |
| [EnterLongLimit()](enterlonglimit.md) | Generates a buy limit order to enter a long position. |
| [EnterLongMIT()](enterlongmit.md) | Generates a buy MIT order to enter a long position. |
| [EnterLongStopLimit()](enterlongstoplimit.md) | Generates a buy stop limit order to enter a long position. |
| [EnterLongStopMarket()](enterlongstopmarket.md) | Generates a buy stop market order to enter a long position. |
| [EnterShort()](entershort.md) | Generates a sell short market order to enter a short position. |
| [EnterShortLimit()](entershortlimit.md) | Generates a sell short stop limit order to enter a short position. |
| [EnterShortMIT()](entershortmit.md) | Generates a sell MIT order to enter a short position. |
| [EnterShortStopLimit()](entershortstoplimit.md) | Generates a sell short stop limit order to enter a short position. |
| [EnterShortStopMarket()](entershortstopmarket.md) | Generates a sell short stop order to enter a short position. |
| [ExitLong()](exitlong.md) | Generates a sell market order to exit a long position. |
| [ExitLongLimit()](exitlonglimit.md) | Generates a sell limit order to exit a long position. |
| [ExitLongMIT()](exitlongmit.md) | Generates a sell MIT order to exit a long position. |
| [ExitLongStopLimit()](exitlongstoplimit.md) | Generates a sell stop limit order to exit a long position. |
| [ExitLongStopMarket()](exitlongstopmarket.md) | Generates a sell stop market order to exit a long position. |
| [ExitShort()](exitshort.md) | Generates a buy to cover market order to exit a short position. |
| [ExitShortLimit()](exitshortlimit.md) | Generates a buy to cover limit order to exit a short position. |
| [ExitShortMIT()](exitshortmit.md) | Generates a buy to cover MIT order to exit a short position. |
| [ExitShortStopLimit()](exitshortstoplimit.md) | Generates a buy to cover stop limit order to exit a short position. |
| [ExitShortStopMarket()](exitshortstopmarket.md) | Generates a buy to cover stop market order to exit a short position. |
| [GetRealtimeOrder()](getrealtimeorder.md) | Returns a matching real-time order object based on a specified historical order object reference. |
| [SetParabolicStop()](setparabolicstop.md) | Generates a parabolic type trail stop order with the signal name "Parabolic stop" to exit a position. |
| [SetProfitTarget()](setprofittarget.md) | Generates a profit target order with the signal name "Profit target" to exit a position. |
| [SetStopLoss()](setstoploss.md) | Generates a stop loss order with the signal name "Stop loss" used to exit a position. |
| [SetTrailStop()](settrailstop.md) | Generates a trail stop order with the signal name "Trail stop" to exit a position. |

![Ns](../images/ns.png)

![Ns](../images/ns.png)

![Ns](../images/ns.png)