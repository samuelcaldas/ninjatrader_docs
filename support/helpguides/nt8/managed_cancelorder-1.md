
NinjaScript > Language Reference > Strategy > Order Methods > Managed Approach > CancelOrder()

CancelOrder()

| << [Click to Display Table of Contents](managed_cancelorder.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Strategy](strategy-1.md) > [Order Methods](order_methods-1.md) > [Managed Approach](managed_approach-1.md) > CancelOrder() | [Previous page](advanced_order_handling-1.md) [Return to chapter overview](managed_approach-1.md) [Next page](managed_changeorder-1.md) |
| --- | --- |
## Definition
Cancels a specified order.  This method is reserved for experienced programmers that fully understanding the concepts of advanced order handling.
 

| Notes: 1.This method sends a cancel request to the broker and does not guarantee that an order is completely cancelled. Most of the time you can expect your order to come back 100% cancelled. 2.An order can be completely filled or part filled in the time that you send the cancel request and the time the exchange receives the request. Check the [OnOrderUpdate()](onorderupdate-1.md) method for the state of an order you attempted to cancelled. |
| --- |

## Syntax
CancelOrder(Order order)
## 

| Warning:  If you have existing historical [order](order-1.md) references which have transitioned to real-time, you MUST update the order object reference to the newly submitted real-time order; otherwise errors may occur as you attempt to cancel the order.  You may use the [GetRealtimeOrder()](getrealtimeorder-1.md) helper method to assist in this transition. |
| --- |

## Parameters

| order | An [Order](order-1.md) object representing the order you wish to cancel. |
| --- | --- |
 
## 
## Examples

| ns |
| --- |
| private Order myEntryOrder = null; private int barNumberOfOrder = 0;   protected override void OnBarUpdate() {    // Submit an entry order at the low of a bar    if (myEntryOrder == null)    {        // use 'live until canceled' limit order to prevent default managed order handling which would expire at end of bar        EnterLongLimit(0, true, 1, Low[0], "Long Entry");        barNumberOfOrder = CurrentBar;    }      // If more than 5 bars has elapsed, cancel the entry order    if (CurrentBar > barNumberOfOrder + 5)        CancelOrder(myEntryOrder); }   protected override void OnOrderUpdate(Order order, double limitPrice, double stopPrice, int quantity, int filled,    double averageFillPrice, OrderState orderState, DateTime time, ErrorCode error, string nativeError) {    // Assign entryOrder in OnOrderUpdate() to ensure the assignment occurs when expected.    // This is more reliable than assigning Order objects in OnBarUpdate, as the assignment is not gauranteed to be complete if it is referenced immediately after submitting    if (order.Name == "Long Entry")        myEntryOrder = order;      // Evaluates for all updates to myEntryOrder.    if (myEntryOrder != null && myEntryOrder == order)    {        // Check if myEntryOrder is cancelled.        if (myEntryOrder.OrderState == OrderState.Cancelled)        {            // Reset myEntryOrder back to null            myEntryOrder = null;        }    } } |
