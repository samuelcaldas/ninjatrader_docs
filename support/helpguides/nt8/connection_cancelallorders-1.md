


NinjaScript \> Language Reference \> Add On \> Connection \> CancelAllOrders()






















CancelAllOrders()







| \<\< [Click to Display Table of Contents](connection_cancelallorders.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Add On](add_on-1.md) \> [Connection](connection_class-1.md) \> CancelAllOrders() | [Previous page](connection_class-1.md) [Return to chapter overview](connection_class-1.md) [Next page](connect-1.md) |
| --- | --- |











## Definition


Cancels all orders for the specified instrument on the connection.


 


## Syntax


\<Connection\>.CancelAllOrders(Instrument instrument)


## 




| instrument | An Instrument object used to identify the instrument for which to cancel orders |
| --- | --- |



## 


## 


## Example




| ns |
| --- |
| private Account myAccount;   protected override void OnStateChange() {    if (State \=\= State.SetDefaults)    {        // Initialize myAccount    } }   private void OnExecutionUpdate(object sender, ExecutionEventArgs e) {    // Cancel all orders if an execution is triggered after 9pm    if (e.Time \> new DateTime(now.Year, now.Month, now.Day, 21, 0, 0))        myAccount.CancelAllOrders(e.Execution.Instrument); } |









