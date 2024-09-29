


NinjaScript \> Language Reference \> Add On \> Account \> Change()






















Change()







| \<\< [Click to Display Table of Contents](change.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Add On](add_on.md) \> [Account](account_class.md) \> Change() | [Previous page](accounts_cancelallorders.md) [Return to chapter overview](account_class.md) [Next page](connection.md) |
| --- | --- |











## Definition


Changes specified [Order](order.md) object(s).


 


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









