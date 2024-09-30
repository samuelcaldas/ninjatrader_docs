
NinjaScript > Language Reference > Strategy > Order Methods > Managed Approach > GetRealtimeOrder()
GetRealtimeOrder()
| << [Click to Display Table of Contents](getrealtimeorder.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Strategy](strategy-1.md) > [Order Methods](order_methods-1.md) > [Managed Approach](managed_approach-1.md) > GetRealtimeOrder() | [Previous page](exitshortstopmarket-1.md) [Return to chapter overview](managed_approach-1.md) [Next page](setparabolicstop-1.md) |
| --- | --- |
## Definition
Returns a matching real-time order object based on a specified historical order object reference.
 
| Note:  This method is only needed if you have historical order references which you wish to transition and manage in real-time (i.e., you had a working order which was submitted historically and re-submitted in real-time as the strategy is enabled). This method only needs to be called once per order object, and should be done in OnOrderUpdate to handle all scenarios.  Please see the [Advanced Order Handling](advanced_order_handling-1.md) section on transition orders for more details. |
| --- |

## Method Return Value
Returns a real-time [order](order-1.md) reference associated with the historical order object.  If no associated order exists (i.e. OrderState is Filled, Canceled, Rejected, Unknown), a null value returns
 
Syntax  

GetRealtimeOrder(Order historicalOrder)
 
## Parameters
| historicalOrder | The historical [order](order-1.md) object to update to real-time |
| --- | --- |
## 
## 
## Examples
| ns |  |
| --- | --- |
| private Order myOrder;   protected override void OnOrderUpdate(Order order, double limitPrice, double stopPrice, int quantity, int filled, double averageFillPrice, OrderState orderState, DateTime time, ErrorCode error, string nativeError) {    // One time only, as we transition from historical    // Convert any old historical order object references to the live order submitted to the real-time account    if (myOrder != null && myOrder.IsBacktestOrder && State == State.Realtime)        myOrder = GetRealtimeOrder(myOrder);      // Assign Order objects here    // This is more reliable than assigning Order objects in OnBarUpdate, as the assignment is not guaranteed to be complete if it is referenced immediately after submitting    if (order.Name == "myOrder Signal Name")        myOrder = order;      // Null Entry order if filled or cancelled. We do not use the Order objects after the order is filled, so we can null it here    if (myOrder != null && myOrder == order)     {        if (order.OrderState == OrderState.Cancelled && order.Filled == 0)            myOrder = null;        if (order.OrderState == OrderState.Filled)            myOrder = null;     } } | |

