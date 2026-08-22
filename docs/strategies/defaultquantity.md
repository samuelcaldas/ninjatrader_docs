# DefaultQuantity

## Definition

An order size variable that can be set either programmatically or overriden via the Strategy that determines the quantity of an entry order.

## Property Value

An int value represents the number of contracts or shares to enter a position with.  Default value is 1.

> **Warning:** This property should ONLY bet set from the [[[OnStateChange()](../language_reference/onstatechange.md) method during State.SetDefaults or State.Configure

## Syntax

DefaultQuantity

## Examples

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        DefaultQuantity = 1;
    }
}
```
