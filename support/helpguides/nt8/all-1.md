


NinjaScript \> Language Reference \> Add On \> Account \> All






















All







| \<\< [Click to Display Table of Contents](all.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Add On](add_on-1.md) \> [Account](account_class-1.md) \> All | [Previous page](accountstatusupdate-1.md) [Return to chapter overview](account_class-1.md) [Next page](cancel-1.md) |
| --- | --- |











## Definition


A collection of Account objects


 


## Property Value


A [Collection](https://msdn.microsoft.com/en-us/library/ms132397(v=vs.110).aspx) of Account objects


 


## Syntax


Accounts.All


## 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {    if (State \=\= State.DataLoaded)    {        foreach (Account sampleAccount in Account.All)     Print(String.Format("The account {0} has a {1} unit FX lotsize set", sampleAccount.Name, sampleAccount.ForexLotSize));    } } |









