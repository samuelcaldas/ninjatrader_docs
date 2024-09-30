
NinjaScript > Language Reference > Strategy > Account
Account

| << [Click to Display Table of Contents](strategy_account.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Strategy](strategy-1.md) > Account | [Previous page](strategy-1.md) [Return to chapter overview](strategy-1.md) [Next page](addchartindicator-1.md) |
| --- | --- |

## Definition
Represents the real-world or simulation Account configured for the strategy.
 
## Property Value
An [Account](account_class-1.md) object configured for the strategy
## 
## Syntax
Account
## 
## Examples
| ns |
| --- |
| //Displays text on chart indicating what account the strategy is applied to Draw.TextFixed(this, "tag1", "Strategy is applied to " + Account.Name, TextPosition.BottomRight); |

