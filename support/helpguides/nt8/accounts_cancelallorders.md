



CancelAllOrders()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](accounts_cancelallorders.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Add On](add_on.htm) > [Account](account_class.htm) >  CancelAllOrders() | [Previous page](cancel.htm) [Return to chapter overview](account_class.htm) [Next page](change.htm) |

Definition
----------

Cancels all [Order](order.htm)s of an instrument.

Syntax
------

CancelAllOrders(Instrument )

 

Parameters
----------

|  |  |
| --- | --- |
| instrument | Instrument of the orders to be cancelled |

Example
-------

|  |
| --- |
| myAccount;     OnStateChange()  {  State.SetDefaults)  {  // Initialize myAccount  }  }     e)  {  // Cancel all orders if an execution is triggered after 9pm  ))  myAccount.CancelAllOrders(e.Execution.Instrument);  } |