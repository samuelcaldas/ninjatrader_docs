



Name

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\name_account.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Add On](add_on-1.htm) > [Account](account_class-1.htm) >  Name | [Previous page](get-1.htm) [Return to chapter overview](account_class-1.htm) [Next page](orders_account-1.htm) |

Definition
----------

Indicates the name of the specified account

Property Value
--------------

An string representing the name of the account

Syntax
------

<Account>.Name

Example
-------

| ns |
| --- |
| private Account myAccount;     protected override void OnStateChange()  {     if (State == State.SetDefaults)     {         // Initialize myAccount     }  }     private void OnAccountStatusUpdate(object sender, AccountStatusEventArgs e)  {     // Print the name of each account updated     Print(String.Format("{0} account updated", myAccount.Name));  } |