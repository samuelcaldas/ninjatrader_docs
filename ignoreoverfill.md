# IgnoreOverfill

## Definition

An [unmanaged order property](unmanaged_approach.md) which defines the behavior of a strategy when an overfill is detected. An overfill is categorized as when an order returns a "Filled" or "PartFilled" state after the order was already marked for cancellation. The cancel request could have been induced by an explicit CancelOrder() call, from more implicit cancellations like those that occur when another order sharing the same OCO ID is filled, or from things like order expiration.

> **Critical:**
- Setting this property value to true can have serious adverse affects on a running strategy unless you have programmed your own overfill handling
- User defined overfill handling is advanced and should ONLY be addressed by experienced programmers. Additional information can be found on overfills in the [Unmanaged approach](unmanaged_approach.md) section

## Property Value

This property returns true if the strategy will ignore overfills; otherwise, false. Default is set to false.

> **Warning:** This property should ONLY bet set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults or State.Configure

## Syntax

IgnoreOverfill

## Examples

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        // Allows for custom overfill handling
        IgnoreOverfill = true;
    }
}
```
