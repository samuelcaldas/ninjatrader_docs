



MarketPosition

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](position_marketposition.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Strategy](strategy.htm) > [Position](position.htm) >  MarketPosition | [Previous page](position_instrument.htm) [Return to chapter overview](position.htm) [Next page](position_quantity.htm) |

Definition
----------

Gets the strategy's current market position

Property Value
--------------

MarketPosition.Flat

MarketPosition.Long

MarketPosition.Short

Syntax
------

Position.MarketPosition  
 

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {        // If not flat print our open PnL       if (Position.MarketPosition != MarketPosition.Flat)            Print("Open PnL: " + Position.GetUnrealizedProfitLoss(PerformanceUnit.Points, Close[0]));  } |