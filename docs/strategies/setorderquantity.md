# SetOrderQuantity

## Definition

Determines how order sizes are calculated for a given strategy.

## Property Value

An enum determining how order quantities are set.  Default value is set to SetOrderQuantity.Strategy.

Possible values are:

| Name / Option | Description |
| --- | --- |
| SetOrderQuantity.DefaultQuantity | User defined order size based on the [DefaultQuantity](defaultquantity.md) property |
| SetOrderQuantity.Strategy | Takes the order size specified programmatically within the strategy |

> **Warning:** This property should ONLY bet set from the [OnStateChange()](../language_reference/onstatechange.md) method during State.SetDefaults or State.Configure

## Syntax

SetOrderQuantity

 

## Examples

```csharp
protected override void OnStateChange()
{
    if (State == State.Configure)
    {
        SetOrderQuantity = SetOrderQuantity.DefaultQuantity; // calculate orders based off default size
    }
}
```
