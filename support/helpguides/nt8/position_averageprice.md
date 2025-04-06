



AveragePrice

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](position_averageprice.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Strategy](strategy.htm) > [Position](position.htm) >  AveragePrice | [Previous page](position.htm) [Return to chapter overview](position.htm) [Next page](position_getunrealizedprofitloss.htm) |

Definition
----------

Gets the average price of a strategy position.

Property Value
--------------

A double value representing the position's average price per unit.

Syntax
------

Position.AveragePrice

 

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Raise stop loss to breakeven when there is at least 10 ticks in profit       if (Close[0] >= Position.AveragePrice + 10 \* TickSize)           ExitLongStopMarket(Position.Quantity, Position.AveragePrice);  } |