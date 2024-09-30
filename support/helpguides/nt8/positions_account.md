
NinjaScript > Language Reference > Add On > Account > Positions

Positions

| << [Click to Display Table of Contents](positions_account.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Add On](add_on.md) > [Account](account_class.md) > Positions | [Previous page](orderupdate.md) [Return to chapter overview](account_class.md) [Next page](positionupdate.md) |
| --- | --- |
## Definition
A collection of Position objects generated for the specified account
 
## Property Value
An [Collection](https://msdn.microsoft.com/en-us/library/ms132397(v=vs.110).aspx) of Position objects
 
## Syntax
Account.Positions
<Account>.Positions
## 
## Examples

| ns |
| --- |
| private Account myAccount;   protected override void OnStateChange() {    if (State == State.SetDefaults)     {        // Find our Sim101 account        lock (Account.All)             myAccount = Account.All.FirstOrDefault(a => a.Name == "Sim101");     }      if (State == State.DataLoaded)     {        lock (myAccount.Positions)         {             Print("Positions in State.DataLoaded:");              foreach (Position position in myAccount.Positions)             {                 Print(String.Format("Position: {0} at {1}", position.MarketPosition, position.AveragePrice));             }         }     } } |
