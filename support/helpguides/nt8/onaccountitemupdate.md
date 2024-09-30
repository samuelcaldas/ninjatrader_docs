
NinjaScript > Language Reference > Strategy > OnAccountItemUpdate()

OnAccountItemUpdate()

| << [Click to Display Table of Contents](onaccountitemupdate.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > OnAccountItemUpdate() | [Previous page](numberrestartattempts.md) [Return to chapter overview](strategy.md) [Next page](accountitemeventargs.md) |
| --- | --- |
## Definition
An event driven method used for strategies which is called for each AccountItem update for the account on which the strategy is running.
## 

| Note:  OnAccountItemUpdate() will be called continually in real-time if a position exists on the account on which the strategy is running. This is to provide updates on the current Unrealized Profit and Loss and associated risk values. |
| --- |

## Method Return Value
This method does not return a value.
 
## Syntax
You must override the method in your strategy with the following syntax:
## protected override void OnAccountItemUpdate(Account account, AccountItem accountItem, double value)
{ 
 
}
## 
## Method Parameters

| account | The [Account](account_class.md) updated |
| --- | --- |
| accountItem | The [AccountItem](accountitem.md) updated |
| value | The value of the AccountItem updated |
 
## 
## Examples

| ns |
| --- |
| protected override void OnAccountItemUpdate(Account account, AccountItem accountItem, double value) {     Print(string.Format("{0} {1} {2}", account.Name, accountItem, value));        // output:    // Sim101 BuyingPower 103962.5    // Sim101 CashValue 103962.5    // Sim101 GrossRealizedProfitLoss 3962.5    // Sim101 RealizedProfitLoss 3962.5 } |
