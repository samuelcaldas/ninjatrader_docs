
NinjaScript > Language Reference > Add On > Account > Strategies
Strategies
| << [Click to Display Table of Contents](strategies_account.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Add On](add_on-1.md) > [Account](account_class-1.md) > Strategies | [Previous page](simulationaccountreset-1.md) [Return to chapter overview](account_class-1.md) [Next page](submit-1.md) |
| --- | --- |
## Definition
A collection of StrategyBase objects generated for the specified account
 
## Property Value
An [Collection](https://msdn.microsoft.com/en-us/library/ms132397(v=vs.110).aspx) of StrategyBase objects
 
## Syntax
<Account>.Strategies
## 
## Examples
| ns |
| --- |
| private Account myAccount;   protected override void OnStateChange() {    if (State == State.SetDefaults)    {        // Initialize myAccount    } }   private void OnAccountStatusUpdate(object sender, AccountStatusEventArgs e) {    foreach (StrategyBase strategy in myAccount.Strategies)    {        Print(String.Format("Account status updated. {0} strategy applied with position {1}", strategy.Name, strategy.Position));    } } |
