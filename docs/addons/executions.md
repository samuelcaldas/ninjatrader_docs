# Executions

## Definition

A collection of Execution objects generated for the specified account. These are the current sessions executions and should match executions reported in the Executions tab of the NinjaTrader Account Data window.

## Property Value

An [Collection](https://msdn.microsoft.com/en-us/library/ms132397(v=vs.110).aspx) of Execution objects

## Syntax

<Account>.Executions

 

> **Note:** At this time there is not a supported method to retrieve historical executions from the local database.

## Examples

![Ns](../images/ns.png)

```csharp
private Account myAccount;
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        // Initialize myAccount
    }
}
private void OnExecutionUpdate(object sender, ExecutionEventArgs e)
{
    foreach (Execution execution in myAccount.Executions)
    {
        Print(String.Format("Execution triggered for Order {0}", execution.Order));
    }
}
```