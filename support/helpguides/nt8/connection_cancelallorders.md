
NinjaScript > Language Reference > Add On > Connection > CancelAllOrders()

CancelAllOrders()

| << [Click to Display Table of Contents](connection_cancelallorders.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Add On](add_on.md) > [Connection](connection_class.md) > CancelAllOrders() | [Previous page](connection_class.md) [Return to chapter overview](connection_class.md) [Next page](connect.md) |
| --- | --- |
## Definition
Cancels all orders for the specified instrument on the connection.
 
## Syntax
<Connection>.CancelAllOrders(Instrument instrument)
## 

| instrument | An Instrument object used to identify the instrument for which to cancel orders |
| --- | --- |
## 
## 
## Example

| ns |
| --- |
| private Account myAccount;   protected override void OnStateChange() {    if (State == State.SetDefaults)    {        // Initialize myAccount    } }   private void OnExecutionUpdate(object sender, ExecutionEventArgs e) {    // Cancel all orders if an execution is triggered after 9pm    if (e.Time > new DateTime(now.Year, now.Month, now.Day, 21, 0, 0))        myAccount.CancelAllOrders(e.Execution.Instrument); } |
