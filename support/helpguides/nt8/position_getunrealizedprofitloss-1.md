



GetUnrealizedProfitLoss()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\position_getunrealizedprofitloss.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) > [Position](position-1.htm) >  GetUnrealizedProfitLoss() | [Previous page](position_averageprice-1.htm) [Return to chapter overview](position-1.htm) [Next page](position_instrument-1.htm) |

Definition
----------

Calculates the unrealized PnL for the strategy position.

Method Return Value
-------------------

A double value representing the unrealized PnL.

Syntax
------

Position.GetUnrealizedProfitLoss(PerformanceUnit unit, [double price])

 

|  |
| --- |
| Note:  •If no double argument is provided in the call, the current (real-time) Last price will be substituted in. In case Tools > Options > Trading > 'Use last price for Pnl' is unchecked or the instrument type is Forex / CFD the bid (for a long position) / ask (for a short position) would be used as a substitute.  •For back-testing a double price to compare against should be provided like in our example below. |

Parameters
----------

|  |  |
| --- | --- |
| unit | Possible values:  PerformanceUnit.Currency  PerformanceUnit.Percent  PerformanceUnit.Pips  PerformanceUnit.Points  PerformanceUnit.Ticks |
| price | Optional price passed in used to calculate the PnL such as Close[0]. This value is used as the current price and compared against your entry price for the PnL. |

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // If not flat print our unrealized PnL       if (Position.MarketPosition != MarketPosition.Flat)           Print("Open PnL: " + Position.GetUnrealizedProfitLoss(PerformanceUnit.Points, Close[0]));  } |