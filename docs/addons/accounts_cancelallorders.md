# CancelAllOrders()

## Definition

Cancels all [[[Order](../strategies/order.md)s of an instrument.

## Syntax

CancelAllOrders(Instrument )

 

## Parameters

|  |  |
| --- | --- |
| instrument | Instrument of the orders to be cancelled |

## Example

```csharp
myAccount;
OnStateChange()
{
    State.SetDefaults)
    {
        // Initialize myAccount
    }
}
e)
{
    // Cancel all orders if an execution is triggered after 9pm
    ))
    myAccount.CancelAllOrders(e.Execution.Instrument);
}
```
