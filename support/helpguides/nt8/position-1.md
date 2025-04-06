



Position

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\position.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) >  Position | [Previous page](strategy_plots-1.htm) [Return to chapter overview](strategy-1.htm) [Next page](position_averageprice-1.htm) |

Definition
----------

Represents position related information that pertains to an instance of a strategy.

|  |
| --- |
| Tips:  •For multi-instrument scripts, please see [Positions](positions-1.htm) object which holds an array of all instrument positions managed by the strategy's account  •For a real-world Account Position, please see [PositionAccount](positionaccount-1.htm). |

Methods and Properties
----------------------

|  |  |
| --- | --- |
| Account | An [Account](account_class-1.htm) object which corresponds to the position |
| [AveragePrice](position_averageprice-1.htm) | Gets the average entry price of the strategy position |
| [GetUnrealizedProfitLoss()](position_getunrealizedprofitloss-1.htm) | Gets the unrealized PnL |
| [Instrument](position_instrument-1.htm) | An [Instrument](instrument-1.htm) value representing the instrument of an order |
| [MarketPosition](position_marketposition-1.htm) | Gets the current market position    Possible values:  MarketPosition.Flat  MarketPosition.Long  MarketPosition.Short |
| [Quantity](position_quantity-1.htm) | Gets the current position size |
| ToString() | A string representation of a position |

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Print out the average entry price       Print("The average entry price is " + Position.AveragePrice);  } |