



AveragePrice

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\positionaccount_averageprice.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) > [PositionAccount](positionaccount-1.htm) >  AveragePrice | [Previous page](positionaccount-1.htm) [Return to chapter overview](positionaccount-1.htm) [Next page](positionaccount_getunrealizedprofitloss-1.htm) |

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