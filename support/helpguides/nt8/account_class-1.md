
NinjaScript > Language Reference > Add On > Account
Account
| << [Click to Display Table of Contents](account_class.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Add On](add_on-1.md) > Account | [Previous page](quantityupdown-1.md) [Return to chapter overview](add_on-1.md) [Next page](accountitem-1.md) |
| --- | --- |
## Definition
The Account class can be used to subscribe to account related events as well as accessing account related information.
 
## Static Account Class Properties
| [All](all-1.md) | A collection of Account objects |
| --- | --- |
| [AccountStatusUpdate](accountstatusupdate-1.md) | Event handler for account status updates |
| [SimulationAccountReset](simulationaccountreset-1.md) | Event handler for resets on sim accounts   NOTE: Also happens when rewinding/fast forwarding Playback connections) |
 
## Methods and Properties From Account instances
| [AccountItem](accountitem-1.md) | Represents various account variables used to reflect values the status of the account |
| --- | --- |
| [AccountItemUpdate](accountitemupdate-1.md) | Event handler for changes to account values |
| [Cancel()](cancel-1.md) | Cancels specified order(s) on the account |
| [CancelAllOrders()](accounts_cancelallorders-1.md) | Cancels all orders of an instrument on the account |
| [Change()](change-1.md) | Changes specified order(s) on the account |
| [Connection](connection-1.md) | A Connection representing the connection this account is associated with |
| [CreateOrder()](createorder-1.md) | Creates orders for the account that need to be submitted via Submit() |
| [Denomination](denomination-1.md) | A Currency representing the denomination currency of this connection |
| [Executions](executions-1.md) | A collection of executions on this account |
| [ExecutionUpdate](executionupdate-1.md) | Event handler for when new executions come in, an existing execution is amended, or an execution is removed |
| [Flatten()](flatten-1.md) | Flattens the account on specified instrument(s) |
| [Get()](get-1.md) | Returns the value of an [AccountItem](accountitem-1.md) |
| [Name](name_account-1.md) | A string representing the name of this account |
| [Orders](orders_account-1.md) | A collection of orders on this account |
| [OrderUpdate](orderupdate-1.md) | Event handler for changes to orders |
| [Positions](positions_account-1.md) | A collection of positions on this account |
| [PositionUpdate](positionupdate-1.md) | Event handler for changes to positions |
| [Strategies](strategies_account-1.md) | A collection of strategies on this account |
| [Submit()](submit-1.md) | Submits specified order(s) |

## Example
| ns |
| --- |
| private Account myAccount;   protected override void OnStateChange() {      if (State == State.SetDefaults)      {          // Find our Sim101 account          lock (Account.All)                myAccount = Account.All.FirstOrDefault(a => a.Name == "Sim101");            // Subscribe to static events. Remember to unsubscribe with -= when you are done          Account.AccountStatusUpdate += OnAccountStatusUpdate;            if (myAccount != null)          {                // Print some information about our account using the AccountItem indexer                Print(string.Format("Account Name: {0} Connection Name: {1} Cash Value {2}",                    myAccount.Name,                    myAccount.Connection.Options.Name,                    myAccount.Get(AccountItem.CashValue, Currency.UsDollar)                    ));                  // Print the prices of the executions on our account                lock (myAccount.Executions)                    foreach (Execution execution in myAccount.Executions)                          Print("Price: " + execution.Price);                  // Subscribe to events. Remember to unsubscribe with -= when you are done                myAccount.AccountItemUpdate += OnAccountItemUpdate;                myAccount.ExecutionUpdate += OnExecutionUpdate;          }      }      else if (State == State.Terminated)      {          // Unsubscribe to events          myAccount.AccountItemUpdate -= OnAccountItemUpdate;          myAccount.ExecutionUpdate -= OnExecutionUpdate;           Account.AccountStatusUpdate -= OnAccountStatusUpdate;      } }   private void OnAccountStatusUpdate(object sender, AccountStatusEventArgs e) {      // Do something with the account status update }   private void OnAccountItemUpdate(object sender, AccountItemEventArgs e) {      // Do something with the account item update }   private void OnExecutionUpdate(object sender, ExecutionEventArgs e) {      // Do something with the execution update } |

