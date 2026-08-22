# CharactersReservedPerMedia

## Definition

Sets the number of characters allowed when attaching an image to ensure that character count is properly calculated.

> **Note:** Social networks which limit the number of characters for each post, will have a defined number of characters that are reserved when an image or other media is attached.

## Property Value

A int value that represents the number of characters reserved when attaching an image or other media.

> **Warning:** This property should ONLY bet set from the [OnStateChange()](onstatechange.md) method during State.SetDefaults or State.Configure

## Syntax

CharactersReservedPerMedia

## Examples

![Ns](../images/ns.png)

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        CharactersReservedPerMedia
        = 40;
    }
}
```