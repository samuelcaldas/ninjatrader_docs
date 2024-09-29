


NinjaScript \> Language Reference \> Add On \> Account \> Connection






















Connection







| \<\< [Click to Display Table of Contents](connection.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Add On](add_on.md) \> [Account](account_class.md) \> Connection | [Previous page](change.md) [Return to chapter overview](account_class.md) [Next page](connectoptions.md) |
| --- | --- |











## Definition


Indicates the data connection used for the specified account.


 


## Property Value


An instance of the Connection class containing information about the connection used for a specified account


 


## Syntax


\<Account\>.Connection


## 


## Examples




| ns |
| --- |
| private Account myAccount;   protected override void OnStateChange() {    if (State \=\= State.SetDefaults)    {        myAccount \= Account.All.FirstOrDefault(a \=\> a.Name \=\= "Sim101");    } }   private void OnAccountStatusUpdate(object sender, AccountStatusEventArgs e) {    Print(String.Format("{0} connection updated", myAccount.Connection.Options.Name)); } |









