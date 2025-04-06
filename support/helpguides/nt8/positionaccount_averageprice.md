



AveragePrice

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](positionaccount_averageprice.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Strategy](strategy.htm) > [PositionAccount](positionaccount.htm) >  AveragePrice | [Previous page](positionaccount.htm) [Return to chapter overview](positionaccount.htm) [Next page](positionaccount_getunrealizedprofitloss.htm) |

Definition
----------

Gets the average price of an account position.

Property Value
--------------

A double value representing the account position's average price per unit.

Syntax
------

PositionAccount.AveragePrice

 

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Raise stop loss to breakeven when there is at least 10 ticks in profit       if (Close[0] >= PositionAccount.AveragePrice + 10 \* TickSize)           ExitLongStopMarket(PositionAccount.Quantity, PositionAccount.AveragePrice);  } |