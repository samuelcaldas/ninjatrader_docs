
NinjaScript \> Language Reference \> Strategy \> OnAccountItemUpdate() \> AccountItemEventArgs

AccountItemEventArgs

| \<\< [Click to Display Table of Contents](accountitemeventargs.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> [OnAccountItemUpdate()](onaccountitemupdate.md) \> AccountItemEventArgs | [Previous page](onaccountitemupdate.md) [Return to chapter overview](onaccountitemupdate.md) [Next page](onexecutionupdate.md) |
| --- | --- |
## Definition
AccountItemEventArgs contains [Account](account_class.md)\-related information to be passed as an argument to the [OnAccountItemUpdate(](onaccountitemupdate.md)[)](accountitemupdate.md) event.

| Note:  For a complete, working example of this class in use, download framework example located on our [Developing AddOns Overview](developing_add_ons.md) |
| --- |
 
The properties listed below are accessible from an instance of AccountItemEventArgs:
 

| Account | The Account for which OnAccountItemUpdate() was called |
| --- | --- |
| AccountItem | The [AccountItem](accountitem.md) which has updated, resulting in the call to OnAccountItemUpdate() |
| Currency | The currency of the Account in question |
| Time | A DateTime object representing the time at which the change occurred |
| Value | The new value of the updated AccountItems |
 
## Example

| ns |
| --- |
| // This method is fired on any change of an AccountItem private void OnAccountItemUpdate(object sender, AccountItemEventArgs e) {        /\* Dispatcher.InvokeAsync() is needed for multi\-threading considerations. When processing events outside of the UI thread, and we want to         influence the UI .InvokeAsync() allows us to do so. It can also help prevent the UI thread from locking up on long operations. \*/        Dispatcher.InvokeAsync(() \=\>        {            //Print which AccountItem changed, on which account, and the new value, using            outputBox.AppendText(string.Format("{0}Account: {1}{0}AccountItem: {2}{0}Value: {3}",                Environment.NewLine,                e.Account.Name,                e.AccountItem,                e.Value));        });   } |
