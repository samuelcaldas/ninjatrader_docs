# Cancel()

## Definition

Cancels specified [Order](order.md) object(s).

## Syntax

Cancel(IEnumerable<Order> orders)

 

## Parameters

|  |  |
| --- | --- |
| orders | Order(s) to cancel |

## Examples

```csharp
private Account myAccount;
Order stopOrder = null;
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        // Initialize myAccount
    }
}
private void OnExecutionUpdate(object sender, ExecutionEventArgs e)
{
    // Cancel the stop order if an execution results in a long position
    if(e.MarketPosition == MarketPosition.Long)
    myAccount.Cancel(new[] { stopOrder });
}
```
