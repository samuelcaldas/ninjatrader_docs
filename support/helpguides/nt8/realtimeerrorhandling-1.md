


NinjaScript \> Language Reference \> Strategy \> RealtimeErrorHandling






















RealtimeErrorHandling







| \<\< [Click to Display Table of Contents](realtimeerrorhandling.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> RealtimeErrorHandling | [Previous page](positionsaccount-1.md) [Return to chapter overview](strategy-1.md) [Next page](restartswithinminutes-1.md) |
| --- | --- |











## Definition


Defines the behavior of a strategy when a strategy generated order is returned from the broker's server in a "Rejected" state. Default behavior is to stop the strategy, cancel any remaining working orders, and then close any open positions managed by the strategy by submitting one "Close" order for each unique position.


 




| Critical: •Setting this property value to IgnoreAllErrors can have serious adverse affects on a running strategy unless you have programmed your own order rejection handling in the [OnOrderUpdate()](onorderupdate-1.md) method •User defined rejection handling is advanced and should ONLY be addressed by experienced programmers |
| --- |



 


 


## Property Value


An enum value determining how the strategy behaves.  Default value is set to RealtimeErrorHandling.StopCancelClose. Possible values include:




| RealtimeErrorHandling.IgnoreAllErrors | Ignores any order errors received by the strategy and will continue running. |
| --- | --- |
| RealtimeErrorHandling.StopCancelClose | Default behavior of a strategy |
| RealtimeErrorHandling.StopCancelCloseIgnoreRejects | Will perform default behavior on all errors except order rejections |



 


 




| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange-1.md) method during State.SetDefaults or State.Configure |
| --- |



 


 


## Syntax


RealtimeErrorHandling


 


## 


## Examples




| ns |
| --- |
| private Order stopLossOrder \= null; private Order entryOrder \= null;   protected override void OnStateChange() {    if (State \=\= State.Configure)    {      RealtimeErrorHandling \= RealtimeErrorHandling.IgnoreAllErrors;    } }   protected override void OnBarUpdate() {    if (entryOrder \=\= null \&\& Close\[0] \> Open\[0])      EnterLong("myEntryOrder");      if (stopLossOrder \=\= null)      stopLossOrder \= ExitLongStopMarket(Position.AveragePrice \- 10 \* TickSize, "myStopLoss", "myEntryOrder"); }   protected override void OnOrderUpdate(Order order, double limitPrice, double stopPrice, int quantity, int filled, double averageFillPrice,                                      OrderState orderState, DateTime time, ErrorCode error, string nativeError) {    // Assign stopLossOrder in OnOrderUpdate() to ensure the assignment occurs when expected.    // This is more reliable than assigning Order objects in OnBarUpdate,    // as the assignment is not guaranteed to be complete if it is referenced immediately after submitting    if (order.Name \=\= "myStopLoss" \&\& orderState \=\= OrderState.Filled)      stopLossOrder \= order;      if (stopLossOrder !\= null \&\& stopLossOrder \=\= order)    {      // Rejection handling      if (order.OrderState \=\= OrderState.Rejected)      {          // Stop loss order was rejected !!!!          // Do something about it here      }    } } |



 








