



Cancel()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](cancel.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Add On](add_on.htm) > [Account](account_class.htm) >  Cancel() | [Previous page](all.htm) [Return to chapter overview](account_class.htm) [Next page](accounts_cancelallorders.htm) |

Definition
----------

Cancels specified [Order](order.htm) object(s).

Syntax
------

Cancel(IEnumerable<Order> orders)

 

Parameters
----------

|  |  |
| --- | --- |
| orders | Order(s) to cancel |

Examples
--------

| ns |
| --- |
| private Account myAccount;  Order stopOrder = null;     protected override void OnStateChange()  {     if (State == State.SetDefaults)     {         // Initialize myAccount     }  }     private void OnExecutionUpdate(object sender, ExecutionEventArgs e)  {     // Cancel the stop order if an execution results in a long position     if(e.MarketPosition == MarketPosition.Long)         myAccount.Cancel(new[] { stopOrder });  } |