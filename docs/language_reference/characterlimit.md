# CharacterLimit

## Definition

Determines the maximum number of characters the social network allows. Signature, text, and links all contribute to this character count displayed on the share window.

A value of int.MaxValue determines no practical limit and will make the character count not appear on the Share window.

## Property Value

A int value that represents the maximum number of characters the social network allows.

> **Warning:** This property should ONLY bet set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults or State.Configure

## Syntax

CharacterLimit

## Examples

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        CharacterLimit
        = 280;
    }
}
```