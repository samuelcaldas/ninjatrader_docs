



Position

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](position.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Strategy](strategy.htm) >  Position | [Previous page](strategy_plots.htm) [Return to chapter overview](strategy.htm) [Next page](position_averageprice.htm) |

Definition
----------

Represents position related information that pertains to an instance of a strategy.

|  |
| --- |
| Tips:  •For multi-instrument scripts, please see [Positions](positions.htm) object which holds an array of all instrument positions managed by the strategy's account  •For a real-world Account Position, please see [PositionAccount](positionaccount.htm). |

Methods and Properties
----------------------

|  |  |
| --- | --- |
| Account | An [Account](account_class.htm) object which corresponds to the position |
| [AveragePrice](position_averageprice.htm) | Gets the average entry price of the strategy position |
| [GetUnrealizedProfitLoss()](position_getunrealizedprofitloss.htm) | Gets the unrealized PnL |
| [Instrument](position_instrument.htm) | An [Instrument](instrument.htm) value representing the instrument of an order |
| [MarketPosition](position_marketposition.htm) | Gets the current market position    Possible values:  MarketPosition.Flat  MarketPosition.Long  MarketPosition.Short |
| [Quantity](position_quantity.htm) | Gets the current position size |
| ToString() | A string representation of a position |

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {       // Print out the average entry price       Print("The average entry price is " + Position.AveragePrice);  } |