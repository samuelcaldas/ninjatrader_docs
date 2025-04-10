



CancelAllOrders()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](accounts_cancelallorders.md) >>  **Navigation:**  [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Add On](add_on.md) > [Account](account_class.md) >  CancelAllOrders() | [Previous page](cancel.md) [Return to chapter overview](account_class.md) [Next page](change.md) |

Definition
----------

Cancels all [Order](order.md)s of an instrument.

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