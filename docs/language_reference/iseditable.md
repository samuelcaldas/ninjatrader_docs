# IsEditable

## Definition

Determines if a Market Analyzer Column is editable.

## Property Value

This property returns true if the Market Analyzer Column can be edited; otherwise, false.

## Syntax

IsEditable

## Example

```csharp
protected override void OnStateChange()
{
    if (State == State.SetDefaults)
    {
        DataType
        = typeof(string);
        IsEditable = true;
    }
}
```