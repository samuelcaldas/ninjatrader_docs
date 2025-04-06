



Account

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\strategy_account.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) >  Account | [Previous page](strategy-1.htm) [Return to chapter overview](strategy-1.htm) [Next page](addchartindicator-1.htm) |

Definition
----------

Represents the real-world or simulation Account configured for the strategy.

Property Value
--------------

An [Account](account_class-1.htm) object configured for the strategy

Syntax
------

Account

Examples
--------

| ns |
| --- |
| //Displays text on chart indicating what account the strategy is applied to  Draw.TextFixed(this, "tag1", "Strategy is applied to " + Account.Name, TextPosition.BottomRight); |