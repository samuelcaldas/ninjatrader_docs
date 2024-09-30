
NinjaScript \> Language Reference \> Add On \> Account \> Strategies
Strategies
| \<\< [Click to Display Table of Contents](strategies_account.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Add On](add_on.md) \> [Account](account_class.md) \> Strategies | [Previous page](simulationaccountreset.md) [Return to chapter overview](account_class.md) [Next page](submit.md) |
| --- | --- |
## Definition
A collection of StrategyBase objects generated for the specified account
 
## Property Value
An [Collection](https://msdn.microsoft.com/en-us/library/ms132397(v=vs.110).aspx) of StrategyBase objects
 
## Syntax
\<Account\>.Strategies
## 
## Examples
| ns |
| --- |
| private Account myAccount;   protected override void OnStateChange() {    if (State \=\= State.SetDefaults)    {        // Initialize myAccount    } }   private void OnAccountStatusUpdate(object sender, AccountStatusEventArgs e) {    foreach (StrategyBase strategy in myAccount.Strategies)    {        Print(String.Format("Account status updated. {0} strategy applied with position {1}", strategy.Name, strategy.Position));    } } |
