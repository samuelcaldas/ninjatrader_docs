



All

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\all.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Add On](add_on-1.htm) > [Account](account_class-1.htm) >  All | [Previous page](accountstatusupdate-1.htm) [Return to chapter overview](account_class-1.htm) [Next page](cancel-1.htm) |

Definition
----------

A collection of Account objects

 

Property Value
--------------

A [Collection](https://msdn.microsoft.com/en-us/library/ms132397(v=vs.110).aspx) of Account objects

Syntax
------

Accounts.All

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()  {     if (State == State.DataLoaded)     {         foreach (Account sampleAccount in Account.All)      Print(String.Format("The account {0} has a {1} unit FX lotsize set", sampleAccount.Name, sampleAccount.ForexLotSize));     }  } |