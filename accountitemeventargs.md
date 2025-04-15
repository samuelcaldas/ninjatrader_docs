



AccountItemEventArgs

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](accountitemeventargs.md) >>  **Navigation:**  [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > [OnAccountItemUpdate()](onaccountitemupdate.md) >  AccountItemEventArgs | [Previous page](onaccountitemupdate.md) [Return to chapter overview](onaccountitemupdate.md) [Next page](onexecutionupdate.md) |

Definition
----------

AccountItemEventArgs contains [Account](account_class.md)-related information to be passed as an argument to the [OnAccountItemUpdate(](onaccountitemupdate.md)[)](accountitemupdate.md) event.

 

 

|  |
| --- |
| Developing AddOns Overview |

 

The properties listed below are accessible from an instance of AccountItemEventArgs:

|  |  |
| --- | --- |
| Account | The Account for which OnAccountItemUpdate() was called |
| AccountItem | AccountItem which has updated, resulting in the call to OnAccountItemUpdate() |
| Currency | The currency of the Account in question |
| Time | A DateTime object representing the time at which the change occurred |
| Value | The new value of the updated AccountItems |

Example
-------

|  |
| --- |
| // This method is fired on any change of an AccountItem  e)  {  /\* Dispatcher.InvokeAsync() is needed for multi-threading considerations. When processing events outside of the UI thread, and we want to          influence the UI .InvokeAsync() allows us to do so. It can also help prevent the UI thread from locking up on long operations. \*/  =>  {  //Print which AccountItem changed, on which account, and the new value, using  ,  Environment.NewLine,  e.Account.Name,  e.AccountItem,  e.Value));  });     } |