
NinjaScript \> Language Reference \> Strategy \> Position

Position

| \<\< [Click to Display Table of Contents](position.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> Position | [Previous page](strategy_plots.md) [Return to chapter overview](strategy.md) [Next page](position_averageprice.md) |
| --- | --- |
## Definition
Represents position related information that pertains to an instance of a strategy.   
 

| Tips: - For multi\-instrument scripts, please see [Positions](positions.md) object which holds an array of all instrument positions managed by the strategy's account- For a real\-world Account Position, please see [PositionAccount](positionaccount.md). |
| --- |

## Methods and Properties

| Account | An [Account](account_class.md) object which corresponds to the position |
| --- | --- |
| [AveragePrice](position_averageprice.md) | Gets the average entry price of the strategy position |
| [GetUnrealizedProfitLoss()](position_getunrealizedprofitloss.md) | Gets the unrealized PnL |
| [Instrument](position_instrument.md) | An [Instrument](instrument.md) value representing the instrument of an order |
| [MarketPosition](position_marketposition.md) | Gets the current market position   Possible values: MarketPosition.Flat MarketPosition.Long MarketPosition.Short |
| [Quantity](position_quantity.md) | Gets the current position size |
| ToString() | A string representation of a position |

## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the average entry price      Print("The average entry price is " \+ Position.AveragePrice); } |

