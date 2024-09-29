


NinjaScript \> Language Reference \> Add On \> Account \> Name






















Name







| \<\< [Click to Display Table of Contents](name_account.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Add On](add_on.md) \> [Account](account_class.md) \> Name | [Previous page](get.md) [Return to chapter overview](account_class.md) [Next page](orders_account.md) |
| --- | --- |











## Definition


Indicates the name of the specified account


 


## Property Value


An string representing the name of the account


 


## Syntax


\<Account\>.Name


## 


## Example




| ns |
| --- |
| private Account myAccount;   protected override void OnStateChange() {    if (State \=\= State.SetDefaults)    {        // Initialize myAccount    } }   private void OnAccountStatusUpdate(object sender, AccountStatusEventArgs e) {    // Print the name of each account updated    Print(String.Format("{0} account updated", myAccount.Name)); } |









