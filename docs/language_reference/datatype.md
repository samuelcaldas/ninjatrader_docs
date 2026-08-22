# DataType

## Definition

Determines the data type displayed in a Market Analyzer Column.

## Syntax

DataType

## Example

![Ns](../images/ns.png)

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