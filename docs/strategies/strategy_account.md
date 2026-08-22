# Account

## Definition

Represents the real-world or simulation Account configured for the strategy.

## Property Value

An [[[Account](../addons/account_class.md) object configured for the strategy

## Syntax

Account

## Examples

```csharp
//Displays text on chart indicating what account the strategy is applied to
Draw.TextFixed(this, "tag1", "Strategy is applied to " + Account.Name, TextPosition.BottomRight);
```
