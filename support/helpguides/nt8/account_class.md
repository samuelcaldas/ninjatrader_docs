
NinjaScript \> Language Reference \> Add On \> Account

Account

| \<\< [Click to Display Table of Contents](account_class.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Add On](add_on.md) \> Account | [Previous page](quantityupdown.md) [Return to chapter overview](add_on.md) [Next page](accountitem.md) |
| --- | --- |
## Definition
The Account class can be used to subscribe to account related events as well as accessing account related information.
 
## Static Account Class Properties

| [All](all.md) | A collection of Account objects |
| --- | --- |
| [AccountStatusUpdate](accountstatusupdate.md) | Event handler for account status updates |
| [SimulationAccountReset](simulationaccountreset.md) | Event handler for resets on sim accounts   NOTE: Also happens when rewinding/fast forwarding Playback connections) |
 
## Methods and Properties From Account instances

| [AccountItem](accountitem.md) | Represents various account variables used to reflect values the status of the account |
| --- | --- |
| [AccountItemUpdate](accountitemupdate.md) | Event handler for changes to account values |
| [Cancel()](cancel.md) | Cancels specified order(s) on the account |
| [CancelAllOrders()](accounts_cancelallorders.md) | Cancels all orders of an instrument on the account |
| [Change()](change.md) | Changes specified order(s) on the account |
| [Connection](connection.md) | A Connection representing the connection this account is associated with |
| [CreateOrder()](createorder.md) | Creates orders for the account that need to be submitted via Submit() |
| [Denomination](denomination.md) | A Currency representing the denomination currency of this connection |
| [Executions](executions.md) | A collection of executions on this account |
| [ExecutionUpdate](executionupdate.md) | Event handler for when new executions come in, an existing execution is amended, or an execution is removed |
| [Flatten()](flatten.md) | Flattens the account on specified instrument(s) |
| [Get()](get.md) | Returns the value of an [AccountItem](accountitem.md) |
| [Name](name_account.md) | A string representing the name of this account |
| [Orders](orders_account.md) | A collection of orders on this account |
| [OrderUpdate](orderupdate.md) | Event handler for changes to orders |
| [Positions](positions_account.md) | A collection of positions on this account |
| [PositionUpdate](positionupdate.md) | Event handler for changes to positions |
| [Strategies](strategies_account.md) | A collection of strategies on this account |
| [Submit()](submit.md) | Submits specified order(s) |

## Example

| ns |
| --- |
| private Account myAccount;   protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          // Find our Sim101 account          lock (Account.All)                myAccount \= Account.All.FirstOrDefault(a \=\> a.Name \=\= "Sim101");            // Subscribe to static events. Remember to unsubscribe with \-\= when you are done          Account.AccountStatusUpdate \+\= OnAccountStatusUpdate;            if (myAccount !\= null)          {                // Print some information about our account using the AccountItem indexer                Print(string.Format("Account Name: {0} Connection Name: {1} Cash Value {2}",                    myAccount.Name,                    myAccount.Connection.Options.Name,                    myAccount.Get(AccountItem.CashValue, Currency.UsDollar)                    ));                  // Print the prices of the executions on our account                lock (myAccount.Executions)                    foreach (Execution execution in myAccount.Executions)                          Print("Price: " \+ execution.Price);                  // Subscribe to events. Remember to unsubscribe with \-\= when you are done                myAccount.AccountItemUpdate \+\= OnAccountItemUpdate;                myAccount.ExecutionUpdate \+\= OnExecutionUpdate;          }      }      else if (State \=\= State.Terminated)      {          // Unsubscribe to events          myAccount.AccountItemUpdate \-\= OnAccountItemUpdate;          myAccount.ExecutionUpdate \-\= OnExecutionUpdate;           Account.AccountStatusUpdate \-\= OnAccountStatusUpdate;      } }   private void OnAccountStatusUpdate(object sender, AccountStatusEventArgs e) {      // Do something with the account status update }   private void OnAccountItemUpdate(object sender, AccountItemEventArgs e) {      // Do something with the account item update }   private void OnExecutionUpdate(object sender, ExecutionEventArgs e) {      // Do something with the execution update } |
