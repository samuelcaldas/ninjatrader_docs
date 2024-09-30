
NinjaScript \> Language Reference \> Add On \> Account \> Name

Name

| \<\< [Click to Display Table of Contents](name_account.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Add On](add_on-1.md) \> [Account](account_class-1.md) \> Name | [Previous page](get-1.md) [Return to chapter overview](account_class-1.md) [Next page](orders_account-1.md) |
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
