# Advanced Order Handling

Advanced order handling is reserved for EXPERIENCED programmers. Through advanced order handling you can submit, change and cancel orders at your discretion through any event-driven method within a strategy. Each order method within the "Managed Approach" section has a method overload designed for advanced handling.

> Orders can remain live until you call the [CancelOrder()](managed_cancelorder.md) method, or until the order's time in force has expired, whichever comes first. This flexibility allows you to control exactly when an order should be cancelled instead of relying on the close of a bar. Each order method, such as [EnterLongLimit()](enterlonglimit.md), has a method overload designed to submit a "live until canceled" order. When using this overload, it is important to retain a reference to the Order object, so that it can be canceled via CancelOrder() at a later time.

- An Order object returned from calling an order method contains dynamic properties which will always reflect the current state of the associated order
- The property <Order>.OrderId is NOT a unique value, since it can change throughout an order's lifetime.  Please see the section below on "Transitioning order references from historical to live" for details on how to handle.
- To check for equality, you can compare Order objects directly    The following example code demonstrates the submission of an order and the assignment of the Order return object to the variable "entryOrder." After this, the object is checked in the OnOrderUpdate() method for equality, and then checked for the Filled state.   Examples 

![Ns](../images/ns.png)

```csharp
private Order entryOrder = null;
protected override void OnBarUpdate()
{
    if (entryOrder == null && Close[0] > Open[0])
    EnterLong("myEntryOrder");
}
protected override void OnOrderUpdate(Order order, double limitPrice, double stopPrice, int quantity, int filled, double averageFillPrice, OrderState orderState, DateTime time, ErrorCode error, string nativeError)
{
    // Assign entryOrder in OnOrderUpdate() to ensure the assignment occurs when expected.
    // This is more reliable than assigning Order objects in OnBarUpdate, as the assignment is not gauranteed to be complete if it is referenced immediately after submitting
    if (order.Name == "myEntryOrder" && orderState != OrderState.Filled)
    entryOrder = order;
    // Null Entry order if filled or cancelled. We do not use the Order objects after the order is filled, so we can null it here
    if (entryOrder != null && entryOrder == order)
    {
        if (order.OrderState == OrderState.Cancelled && order.Filled == 0)
        entryOrder = null;
        if (order.OrderState == OrderState.Filled)
        entryOrder = null;
    }
}
```

## Transitioning order references from historical to live

When starting a strategy on real-time data, the [starting behavior](../ninjascript/syncing_account_positions.md) will renew any active historical orders and resubmit these orders to your live or simulation account.  This process includes updating the historical/backtest generated order ID to the account generated order ID, and any associated OCO IDs.  If you are tracking order objects, is critical that you update the order reference to ensure that it is now using the correct order details.    This should be done in [OnOrderUpdate()](onorderupdate.md) to ensure all cases of order transitions are handled.

---

Critical:  If you DO NOT update a historical order reference, and then attempt to cancel/change that order after it has been submitted in real-time, your strategy will be disabled with a message similar to: "Strategy has been disabled because it attempted to modify a historical order that has transitioned to a live order."

> **Tip:** When the real-time order is submitted, there is a generic Order object passed into the [OnOrderUpdate()](onorderupdate.md) method containing the live order details which can be used for debugging.  It is recommended you use the helper [GetRealtimeOrder()](getrealtimeorder.md) when your strategy transitions to real-time to update your order references

     Example 

![Ns](../images/ns.png)

![Ns](../images/ns.png)

```csharp
private Order entryOrder = null; protected override void OnBarUpdate(){
    if (entryOrder == null && Close[0] > Open[0])
    entryOrder = EnterLongLimit("myEntryOrder", Low[0]);}
protected override void OnOrderUpdate(Order order, double limitPrice, double stopPrice, int quantity, int filled, double averageFillPrice, OrderState orderState, DateTime time, ErrorCode error, string nativeError){
    // One time only, as we transition from historical
    // Convert any old historical order object references to the live order submitted to the real-time account
    if (entryOrder != null && entryOrder.IsBacktestOrder && State == State.Realtime)
    entryOrder = GetRealtimeOrder(entryOrder);
    // Null entryOrder if filled or cancelled. We do not use the Order objects after the order is filled, so we can null it here
    if (entryOrder != null && entryOrder == order)
    {
        if (order.OrderState == OrderState.Cancelled && order.Filled == 0)
        entryOrder = null;
        if (order.OrderState == OrderState.Filled)
        entryOrder = null;
}}
```

## Working with a Multi-Instrument Strategy

```csharp
private Order entryOrder = null;
protected override void OnStateChange()
{
    if (State == State.Configure)
    {
        AddDataSeries("AAPL", BarsPeriodType.Minute, 1);
    }
}
protected override void OnBarUpdate()
{
    // Check if the MSFT series triggered an bar update event
    if (BarsInProgress == 0)
    {
        // Submit an order for AAPL in the context of MSFT bar update event
        if (entryOrder == null)
        EnterLongLimit(1, true, 1, Lows[1][0], "AAPL Order");
    }
}
protected override void OnOrderUpdate(Order order, double limitPrice, double stopPrice, int quantity, int filled, double averageFillPrice, OrderState orderState, DateTime time, ErrorCode error, string nativeError)
{
    // Assign entryOrder in OnOrderUpdate() to ensure the assignment occurs when expected.
    // This is more reliable than assigning Order objects in OnBarUpdate, as the assignment is not gauranteed to be complete if it is referenced immediately after submitting
    if (order.Name == "AAPL Order" && orderState != OrderState.Filled)
    entryOrder = order;
}
```