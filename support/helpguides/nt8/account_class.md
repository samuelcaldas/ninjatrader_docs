



Account

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](account_class.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Add On](add_on.htm) >  Account | [Previous page](quantityupdown.htm) [Return to chapter overview](add_on.htm) [Next page](accountitem.htm) |

Definition
----------

The Account class can be used to subscribe to account related events as well as accessing account related information.

Static Account Class Properties
-------------------------------

|  |  |
| --- | --- |
| All | A collection of Account objects |
| AccountStatusUpdate | Event handler for account status updates |
| SimulationAccountReset | Event handler for resets on sim accounts NOTE: Also happens when rewinding/fast forwarding Playback connections) |

Methods and Properties From Account instances
---------------------------------------------

|  |  |
| --- | --- |
| AccountItem | Represents various account variables used to reflect values the status of the account |
| AccountItemUpdate | Event handler for changes to account values |
| Cancel() | Cancels specified order(s) on the account |
| CancelAllOrders() | Cancels all orders of an instrument on the account |
| Change() | Changes specified order(s) on the account |
| Connection | A Connection representing the connection this account is associated with |
| CreateOrder() | Creates orders for the account that need to be submitted via Submit() |
| Denomination | Currency representing the denomination currency of this connection |
| Executions | A collection of executions on this account |
| ExecutionUpdate | Event handler for when new executions come in, an existing execution is amended, or an execution is removed |
| Flatten() | Flattens the account on specified instrument(s) |
| Get() | AccountItem |
| Name | A string representing the name of this account |
| Orders | A collection of orders on this account |
| OrderUpdate | Event handler for changes to orders |
| Positions | A collection of positions on this account |
| PositionUpdate | Event handler for changes to positions |
| Strategies | A collection of strategies on this account |
| Submit() | Submits specified order(s) |

Example
-------

|  |
| --- |
| myAccount;     OnStateChange()  {  State.SetDefaults)  {  // Find our Sim101 account  (Account.All)  );     // Subscribe to static events. Remember to unsubscribe with -= when you are done  OnAccountStatusUpdate;     )  {  // Print some information about our account using the AccountItem indexer  ,  myAccount.Name,  myAccount.Connection.Options.Name,  Currency.UsDollar)  ));     // Print the prices of the executions on our account  (myAccount.Executions)  myAccount.Executions)  execution.Price);     // Subscribe to events. Remember to unsubscribe with -= when you are done  OnAccountItemUpdate;  OnExecutionUpdate;  }  }  State.Terminated)  {  // Unsubscribe to events  OnAccountItemUpdate;  OnExecutionUpdate;           Account.AccountStatusUpdate -=OnAccountStatusUpdate;  }  }     e)  {  // Do something with the account status update  }     e)  {  // Do something with the account item update  }     e)  {  // Do something with the execution update  } |