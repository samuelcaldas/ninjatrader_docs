# IsImageAttachmentSupported

## Definition

Determines if the Share Service will allow for images as attachments.

## Property Value

A bool value when false, screenshots will be unable to be sent to the social network.

> **Warning:** This property should ONLY bet set from the [[[OnStateChange()](onstatechange.md) method during State.SetDefaults or State.Configure

## Syntax

IsImageAttachmentSupported

## Examples

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        IsImageAttachmentSupported
        = false;
    }
}
```
