


NinjaScript \> Language Reference \> Add On \> Account \> Change()






















Change()







| \<\< [Click to Display Table of Contents](change.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Add On](add_on-1.md) \> [Account](account_class-1.md) \> Change() | [Previous page](accounts_cancelallorders-1.md) [Return to chapter overview](account_class-1.md) [Next page](connection-1.md) |
| --- | --- |











## Definition


Changes specified [Order](order-1.md) object(s).


 


## Syntax


Change(IEnumerable\<Order\> orders)


 


## Parameters




| orders | Order(s) to change |
| --- | --- |



 


## 


## Example




| ns |
| --- |
| Order stopOrder; stopOrder.StopPriceChanged \= stopOrder.StopPrice \- 4 \* stopOrder.Instrument.MasterInstrument.TickSize;   private void OnExecutionUpdate(object sender, ExecutionEventArgs e) {    // Change the stop order if an execution results in a long position    if(e.MarketPosition \=\= MarketPosition.Long)        myAccount.Change(new\[] { stopOrder }); } |









