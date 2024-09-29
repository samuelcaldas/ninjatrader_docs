


NinjaScript \> Language Reference \> Strategy \> Position






















Position







| \<\< [Click to Display Table of Contents](position.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> Position | [Previous page](strategy_plots-1.md) [Return to chapter overview](strategy-1.md) [Next page](position_averageprice-1.md) |
| --- | --- |











## Definition


Represents position related information that pertains to an instance of a strategy.   


 




| Tips: •For multi\-instrument scripts, please see [Positions](positions-1.md) object which holds an array of all instrument positions managed by the strategy's account•For a real\-world Account Position, please see [PositionAccount](positionaccount-1.md). |
| --- |



 


 


## Methods and Properties




| Account | An [Account](account_class-1.md) object which corresponds to the position |
| --- | --- |
| [AveragePrice](position_averageprice-1.md) | Gets the average entry price of the strategy position |
| [GetUnrealizedProfitLoss()](position_getunrealizedprofitloss-1.md) | Gets the unrealized PnL |
| [Instrument](position_instrument-1.md) | An [Instrument](instrument-1.md) value representing the instrument of an order |
| [MarketPosition](position_marketposition-1.md) | Gets the current market position   Possible values: MarketPosition.Flat MarketPosition.Long MarketPosition.Short |
| [Quantity](position_quantity-1.md) | Gets the current position size |
| ToString() | A string representation of a position |



 


 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the average entry price      Print("The average entry price is " \+ Position.AveragePrice); } |



 


 








