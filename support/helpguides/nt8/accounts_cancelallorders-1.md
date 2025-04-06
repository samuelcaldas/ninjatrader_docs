



CancelAllOrders()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\accounts_cancelallorders.md) >>  **Navigation:**  [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Add On](add_on-1.md) > [Account](account_class-1.md) >  CancelAllOrders() | [Previous page](cancel-1.md) [Return to chapter overview](account_class-1.md) [Next page](change-1.md) |

Definition
----------

Cancels all [Order](order-1.md)s of an instrument.

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