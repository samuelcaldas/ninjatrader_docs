# IsUnmanaged

## Definition

Determines if the strategy will be using Unmanaged order methods.

> **Note:** Unmanaged order methods and [[[Managed order methods](managed_approach.md) CANNOT be used interchangeably.  When IsUnmanaged is set to true, calling managed order methods such as EnterLong(), SetStopLoss(), etc, will generate an error which will be displayed on the [[[Log tab](../operations/log_tab2.md) of the Control Center.

## Property Value

This property returns true if the strategy will use Unmanaged order methods; otherwise, false. Default is set to false.

> **Warning:** This property should ONLY bet set from the [[[OnStateChange()](../language_reference/onstatechange.md) method during State.SetDefaults or State.Configure

## Syntax

IsUnmanaged

## Examples

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        // Use Unmanaged order methods
        IsUnmanaged = true;
    }
}
```
