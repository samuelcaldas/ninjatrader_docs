
NinjaScript \> Language Reference \> Strategy \> Account
Account

| \<\< [Click to Display Table of Contents](strategy_account.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> Account | [Previous page](strategy.md) [Return to chapter overview](strategy.md) [Next page](addchartindicator.md) |
| --- | --- |

## Definition
Represents the real\-world or simulation Account configured for the strategy.
 
## Property Value
An [Account](account_class.md) object configured for the strategy
## 
## Syntax
Account
## 
## Examples
| ns |
| --- |
| //Displays text on chart indicating what account the strategy is applied to Draw.TextFixed(this, "tag1", "Strategy is applied to " \+ Account.Name, TextPosition.BottomRight); |

