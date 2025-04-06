



Connection

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\connection.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Add On](add_on-1.htm) > [Account](account_class-1.htm) >  Connection | [Previous page](change-1.htm) [Return to chapter overview](account_class-1.htm) [Next page](connectoptions-1.htm) |

Definition
----------

Indicates the data connection used for the specified account.

Property Value
--------------

An instance of the Connection class containing information about the connection used for a specified account

Syntax
------

<Account>.Connection

Examples
--------

| ns |
| --- |
| private Account myAccount;     protected override void OnStateChange()  {     if (State == State.SetDefaults)     {         myAccount = Account.All.FirstOrDefault(a => a.Name == "Sim101");     }  }     private void OnAccountStatusUpdate(object sender, AccountStatusEventArgs e)  {     Print(String.Format("{0} connection updated", myAccount.Connection.Options.Name));  } |