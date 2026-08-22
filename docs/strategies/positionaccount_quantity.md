# Quantity

## Definition

Gets the current account's position size.

## Property Value

An int value representing the account's position size.

## Syntax

PositionAccount.Quantity

## Examples

![Ns](../images/ns.png)

```csharp
protected override void OnBarUpdate()
{
    // Prints out the current market position
    Print(PositionAccount.MarketPosition.ToString() + " " + PositionAccount.Quantity.ToString());
}
```