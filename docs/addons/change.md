# Change()

## Definition

Changes specified [[[Order](../strategies/order.md) object(s).

## Syntax

Change(IEnumerable<Order> orders)

 

## Parameters

|  |  |
| --- | --- |
| orders | Order(s) to change |

## Example

```csharp
Order stopOrder;
stopOrder.StopPriceChanged = stopOrder.StopPrice - 4 \* stopOrder.Instrument.MasterInstrument.TickSize;
private void OnExecutionUpdate(object sender, ExecutionEventArgs e)
{
    // Change the stop order if an execution results in a long position
    if(e.MarketPosition == MarketPosition.Long)
    myAccount.Change(new[] { stopOrder });
}
```
