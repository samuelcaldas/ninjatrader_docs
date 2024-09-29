


NinjaScript \> Language Reference \> Add On \> Account \> Executions






















Executions







| \<\< [Click to Display Table of Contents](executions.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Add On](add_on-1.md) \> [Account](account_class-1.md) \> Executions | [Previous page](denomination-1.md) [Return to chapter overview](account_class-1.md) [Next page](executionupdate-1.md) |
| --- | --- |











## Definition


A collection of Execution objects generated for the specified account. These are the current sessions executions and should match executions reported in the Executions tab of the NinjaTrader Account Data window. 


 


## Property Value


An [Collection](https://msdn.microsoft.com/en-us/library/ms132397(v=vs.110).aspx) of Execution objects


 


## Syntax


\<Account\>.Executions


 




| Note: At this time there is not a supported method to retrieve historical executions from the local database. |
| --- |



## 


## Examples




| ns |
| --- |
| private Account myAccount;   protected override void OnStateChange() {    if (State \=\= State.SetDefaults)    {        // Initialize myAccount    } }   private void OnExecutionUpdate(object sender, ExecutionEventArgs e) {    foreach (Execution execution in myAccount.Executions)    {        Print(String.Format("Execution triggered for Order {0}", execution.Order));    } } |









