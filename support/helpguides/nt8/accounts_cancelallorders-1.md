
NinjaScript > Language Reference > Add On > Account > CancelAllOrders()
CancelAllOrders()
| << [Click to Display Table of Contents](accounts_cancelallorders.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Add On](add_on-1.md) > [Account](account_class-1.md) > CancelAllOrders() | [Previous page](cancel-1.md) [Return to chapter overview](account_class-1.md) [Next page](change-1.md) |
| --- | --- |
## Definition
Cancels all [Order](order-1.md)s of an instrument.
 
## Syntax
CancelAllOrders(Instrument instrument)
 
## Parameters
| instrument | Instrument of the orders to be cancelled |
| --- | --- |

## Example
| ns |
| --- |
| private Account myAccount;   protected override void OnStateChange() {    if (State == State.SetDefaults)    {        // Initialize myAccount    } }   private void OnExecutionUpdate(object sender, ExecutionEventArgs e) {    // Cancel all orders if an execution is triggered after 9pm    if (e.Time > new DateTime(now.Year, now.Month, now.Day, 21, 0, 0))        myAccount.CancelAllOrders(e.Execution.Instrument); } |

