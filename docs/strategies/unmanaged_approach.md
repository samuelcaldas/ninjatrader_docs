# Unmanaged Approach

The Unmanaged approach is reserved for VERY EXPERIENCED programmers. In place of the convenience layer that the [Managed](managed_approach.md) approach offered, the Unmanaged approach instead offers ultimate flexibility in terms of order submission and management. This section will discuss some of the basics of working with Unmanaged order methods.

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        IsUnmanaged = true;
    }
}
Please note that you will not be able to mix order methods from the two approaches. When setting [IsUnmanaged](isunmanaged.md) to true, you can only use Unmanaged order methods in the strategy.
```

```csharp
protected override void OnBarUpdate()
{
    // Entry condition
    if (Close[0] > SMA(20)[0] && entryOrder == null)
    entryOrder = SubmitOrderUnmanaged(0, OrderAction.Buy, OrderType.Limit, 1, GetCurrentBid(), 0, "", "Long Limit");
}
It is critical to assign an [Order](order.md) object to keep track of your order or else you will not be able to identify it in your code later since there is no signal tracking when using Unmanaged order methods. Please be aware of the following information about Order objects:
•An Order object returned from calling an order method is dynamic in that its properties will always reflect the current state of an order
•The property <Order>.OrderId is NOT a unique value since it can change throughout an order's lifetime
•To check for equality you can compare Order objects directly
Order Modification Unlike the Managed approach where you could modify a working order by calling the entry order method again with your new parameters, the Unmanaged approach requires the utilization of the [ChangeOrder()](managed_changeorder.md) method. The ChangeOrder() method requires you to have access to the Order object you wish to modify so it is important to hold onto those for any active order you have in your strategy.

```

```csharp
protected override void OnBarUpdate()
{
    // Raise stop loss to breakeven when you are at least 4 ticks in profit
    if (stopOrder != null && stopOrder.StopPrice < Position.AveragePrice && Close[0] >= Position.AveragePrice + 4 \* TickSize)
    ChangeOrder(stopOrder, stopOrder.Quantity, 0, Position.AveragePrice);
}
Order Cancellation Similar to the live until canceled technique from the Managed approach, canceling orders can be done through the [CancelOrder()](unmanaged_cancelorder.md) method.

```

```csharp
protected override void OnBarUpdate()
{
    // Cancel entry order if price is moving away from our limit price

    if (entryOrder != null && Close[0] < entryOrder.LimitPrice - 4 \* TickSize)
    {
        CancelOrder(entryOrder);
        // If the entryOrder Order object is no longer needed I should reset it to null in the OnOrderUpdate() method
    }
}
Signal Tracking Since the Unmanaged approach does not utilize NinjaScript's signal tracking the features associated with it will no longer be relevant. The following properties and their associated concept cannot be used with Unmanaged order methods:
[EntriesPerDirection](entriesperdirection.md)
[EntryHandling](entryhandling.md)
[SetOrderQuantity](setorderquantity.md)
Methods utilizing signal names like [BarsSinceEntryExecution()](barssinceentryexecution.md) and [BarsSinceExitExecution()](barssinceexitexecution.md) can still be used though.
```

## Critical considerations when using Unmanaged order methods

> When using the Unmanaged approach it is imperative to understand that NinjaTrader has many safety mechanisms that were present in the Managed approach turned off. There are critical issues that must be considered and your strategy must be programmed in a manner that addresses these concerns. Failure to do so may result in a serious adverse affect on your trading account.   Overfills Overfills is a serious issue that can occur when using complex entry conditions that bracket the market in both directions end up with both entries being filled instead of one being canceled. Overfills can also occur when you place a trade quickly hoping to close a position while a prior order to close the same position already had an in-flight execution. The exact scenarios in which an overfill can occur is highly dependent on the specific strategy programming. By default, NinjaTrader will protect against overfills even though you are using the Unmanaged approach by halting the strategy, but should you decide to custom program your own [overfill handling](ignoreoverfill.md) it is up to you to either prevent overfills from being a possibility in your code or by introducing logic to address overfills should one occur.   Order rejections Order rejections are not local to using Unmanaged order methods, but the impact of improper rejection management is just as detrimental. Please be sure the strategy has significant contingency programming to handle order rejections so as to prevent your strategy from being left in some sort of limbo state. This is especially important if you decide to turn off [RealtimeErrorHandling](realtimeerrorhandling.md) protection.   Connection Loss Even though NinjaTrader provides [connection loss handling](connectionlosshandling.md) features it is still important to ensure your recovered strategy's internal state is not in limbo. Should you have internal variables tracking various information it may be necessary for you to program your own additional connection loss handling into [OnConnectionStatusUpdate()](../language_reference/onconnectionstatusupdate.md) to properly recover all aspects of your strategy in the manner you desired.

| Name / Option | Description |
| --- | --- |
| [CancelOrder()](unmanaged_cancelorder.md) | Cancels a specified order. |
| [ChangeOrder()](unmanaged_changeorder.md) | Amends a specified [Order](order.md). |
| [IgnoreOverfill](ignoreoverfill.md) | An [unmanaged order property](unmanaged_approach.md) which defines the behavior of a strategy when an overfill is detected. |
| [IsUnmanaged](isunmanaged.md) | Determines if the strategy will be using Unmanaged order methods. |

| [SubmitOrderUnmanaged()](submitorderunmanaged.md) | Generates an [Unmanaged](isunmanaged.md) order. |