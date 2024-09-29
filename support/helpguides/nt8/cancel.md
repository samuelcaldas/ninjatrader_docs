


NinjaScript \> Language Reference \> Add On \> Account \> Cancel()






















Cancel()







| \<\< [Click to Display Table of Contents](cancel.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Add On](add_on.md) \> [Account](account_class.md) \> Cancel() | [Previous page](all.md) [Return to chapter overview](account_class.md) [Next page](accounts_cancelallorders.md) |
| --- | --- |











## Definition


Cancels specified [Order](order.md) object(s).


 


## Syntax


Cancel(IEnumerable\<Order\> orders)


 


## Parameters




| orders | Order(s) to cancel |
| --- | --- |



 


## 


## Examples




| ns |
| --- |
| private Account myAccount; Order stopOrder \= null;   protected override void OnStateChange() {    if (State \=\= State.SetDefaults)    {        // Initialize myAccount    } }   private void OnExecutionUpdate(object sender, ExecutionEventArgs e) {    // Cancel the stop order if an execution results in a long position    if(e.MarketPosition \=\= MarketPosition.Long)        myAccount.Cancel(new\[] { stopOrder }); } |









