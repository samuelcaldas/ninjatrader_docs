# Quantity

## Definition

Gets the strategy's current position size.

## Property Value

An int value representing the position size.

## Syntax

Position.Quantity

## Examples

![Ns](../images/ns.png)

```csharp
protected override void OnBarUpdate()
{
    // Prints out the current market position
    Print(Position.MarketPosition.ToString() + " " + Position.Quantity.ToString());
}
```