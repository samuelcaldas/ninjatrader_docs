# UseOAuth

## Definition

If this property is set to true, a Connect button will appear in the dialogue for configuring the adapter that will call [OnAuthorizeAccount()](onauthorizeaccount.md) when the user clicks it.

## Property Value

A bool value determining if the OnAuthorizeAccount() method should be called in order to authorize the account to the social service.

> **Warning:** This property should ONLY bet set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults

## Syntax

UseOAuth

## Examples

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        UseOAuth
        = true;
    }
}
```