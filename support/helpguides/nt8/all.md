



All

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](all.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Add On](add_on.htm) > [Account](account_class.htm) >  All | [Previous page](accountstatusupdate.htm) [Return to chapter overview](account_class.htm) [Next page](cancel.htm) |

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