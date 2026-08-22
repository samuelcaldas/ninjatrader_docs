# Count

## Definition

Indicates the number total number of values in the `ISeries<T>` array.  This value should always be in sync with the [CurrentBars](currentbars.md) array for that series.

## Method Return Value

A int representing the total size of the series

## Syntax

Count

 

## Examples

![Ns](../images/ns.png)

```csharp
protected override void OnBarUpdate()
{
    Print("Input count: " + Input.Count);
}
```