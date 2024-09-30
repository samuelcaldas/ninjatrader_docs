
NinjaScript > Language Reference > Add On > Account > Orders
Orders
| << [Click to Display Table of Contents](orders_account.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Add On](add_on.md) > [Account](account_class.md) > Orders | [Previous page](name_account.md) [Return to chapter overview](account_class.md) [Next page](orderupdate.md) |
| --- | --- |
## Definition
A collection of Order objects generated for the specified account
 
## Property Value
An [Collection](https://msdn.microsoft.com/en-us/library/ms132397(v=vs.110).aspx) of Order objects
 
| Note: Please keep in mind that orders placed when in State.Historical are not submitted live to an account. |
| --- |

 
## Syntax
<Account>.Orders
## 
## Examples
| ns |
| --- |
| private Account myAccount;   protected override void OnStateChange() {    if (State == State.SetDefaults)    {        // Initialize myAccount    } }   private void OnAccountItemUpdate(object sender, AccountItemEventArgs e) {    // Print the name and order action of each order processed on the account    foreach (Order order in myAccount.Orders)    {        Print(String.Format("Order placed: {0} - {1}", order.Name, order.OrderAction));    } } |
