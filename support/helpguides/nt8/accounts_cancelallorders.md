
NinjaScript \> Language Reference \> Add On \> Account \> CancelAllOrders()

CancelAllOrders()

| \<\< [Click to Display Table of Contents](accounts_cancelallorders.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Add On](add_on.md) \> [Account](account_class.md) \> CancelAllOrders() | [Previous page](cancel.md) [Return to chapter overview](account_class.md) [Next page](change.md) |
| --- | --- |
## Definition
Cancels all [Order](order.md)s of an instrument.
 
## Syntax
CancelAllOrders(Instrument instrument)
 
## Parameters

| instrument | Instrument of the orders to be cancelled |
| --- | --- |

## Example

| ns |
| --- |
| private Account myAccount;   protected override void OnStateChange() {    if (State \=\= State.SetDefaults)    {        // Initialize myAccount    } }   private void OnExecutionUpdate(object sender, ExecutionEventArgs e) {    // Cancel all orders if an execution is triggered after 9pm    if (e.Time \> new DateTime(now.Year, now.Month, now.Day, 21, 0, 0))        myAccount.CancelAllOrders(e.Execution.Instrument); } |
