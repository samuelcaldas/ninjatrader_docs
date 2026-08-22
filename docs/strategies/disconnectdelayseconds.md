# DisconnectDelaySeconds

## Definition

Determines the amount of time a disconnect would have to last before [[[connection loss handling](connectionlosshandling.md) takes action.

## Property Value

An int value represents the time required for a disconnect to last before connection loss handling actions will occur.  Default value is 10.

## Syntax

DisconnectDelaySeconds

## Examples

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        // Disconnect has to be at least 10 seconds
        DisconnectDelaySeconds = 10;
    }
}
```
