
NinjaScript > Language Reference > Add On > Account > Cancel()

Cancel()

| << [Click to Display Table of Contents](cancel.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Add On](add_on-1.md) > [Account](account_class-1.md) > Cancel() | [Previous page](all-1.md) [Return to chapter overview](account_class-1.md) [Next page](accounts_cancelallorders-1.md) |
| --- | --- |
## Definition
Cancels specified [Order](order-1.md) object(s).
 
## Syntax
Cancel(IEnumerable<Order> orders)
 
## Parameters

| orders | Order(s) to cancel |
| --- | --- |
 
## 
## Examples

| ns |
| --- |
| private Account myAccount; Order stopOrder = null;   protected override void OnStateChange() {    if (State == State.SetDefaults)    {        // Initialize myAccount    } }   private void OnExecutionUpdate(object sender, ExecutionEventArgs e) {    // Cancel the stop order if an execution results in a long position    if(e.MarketPosition == MarketPosition.Long)        myAccount.Cancel(new[] { stopOrder }); } |
