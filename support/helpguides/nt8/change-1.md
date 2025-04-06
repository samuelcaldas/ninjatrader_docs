



Change()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\change.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Add On](add_on-1.htm) > [Account](account_class-1.htm) >  Change() | [Previous page](accounts_cancelallorders-1.htm) [Return to chapter overview](account_class-1.htm) [Next page](connection-1.htm) |

Definition
----------

Changes specified [Order](order-1.htm) object(s).

Syntax
------

Change(IEnumerable<Order> orders)

 

Parameters
----------

|  |  |
| --- | --- |
| orders | Order(s) to change |

Example
-------

| ns |
| --- |
| Order stopOrder;  stopOrder.StopPriceChanged = stopOrder.StopPrice - 4 \* stopOrder.Instrument.MasterInstrument.TickSize;     private void OnExecutionUpdate(object sender, ExecutionEventArgs e)  {     // Change the stop order if an execution results in a long position     if(e.MarketPosition == MarketPosition.Long)         myAccount.Change(new[] { stopOrder });  } |