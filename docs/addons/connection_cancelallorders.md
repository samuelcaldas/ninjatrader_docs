# CancelAllOrders()

## Definition

Cancels all orders for the specified instrument on the connection.

## Syntax

<Connection>.CancelAllOrders(Instrument instrument)

| Name / Option | Description |
| --- | --- |
| instrument | An Instrument object used to identify the instrument for which to cancel orders |

## Example

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
    // Cancel all orders if an execution is triggered after 9pm
    if (e.Time > new DateTime(now.Year, now.Month, now.Day, 21, 0, 0))
    myAccount.CancelAllOrders(e.Execution.Instrument);
}
```