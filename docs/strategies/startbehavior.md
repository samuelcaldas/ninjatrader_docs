# StartBehavior

## Definition

Sets the start behavior of the strategy. See [Syncing Account Positions](../ninjascript/syncing_account_positions.md) for more information.

> **Note:** In order to use AdoptAccountPosition you will need to first set [IsAdoptAccountPositionAware](isadoptaccountpositionaware.md) to true. Please be sure that your strategy is specifically programmed in a manner that can accommodate account positions before using this mode.

## Property Value

An enum value that determines how the strategy behaves; Default value is set to StartBehavior.WaitUntilFlat.  Possible values are:

> StartBehavior.AdoptAccountPosition  StartBehavior.ImmediatelySubmit  StartBehavior.ImmediatelySubmitSynchronizeAccount  StartBehavior.WaitUntilFlat  StartBehavior.WaitUntilFlatSynchronizeAccount

## Syntax

StartBehavior

 

## Examples

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        StartBehavior = StartBehavior.WaitUntilFlat;
    }
}
```