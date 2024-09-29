


NinjaScript \> Language Reference \> Strategy \> PositionAccount






















PositionAccount







| \<\< [Click to Display Table of Contents](positionaccount.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> PositionAccount | [Previous page](position_quantity.md) [Return to chapter overview](strategy.md) [Next page](positionaccount_averageprice.md) |
| --- | --- |











## Definition


Represents position related information that pertains to real\-world account (live or simulation).  


 




| Tips: •For multi\-instrument scripts, please see [PositionsAccount](positionsaccount.md) object which holds an array of all instrument positions managed by the strategy's account•For a Strategy Position, please see [Position](position.md) |
| --- |



 


 


## Methods and Properties




| Account | An [Account](account_class.md) object which corresponds to the position |
| --- | --- |
| [AveragePrice](position_averageprice.md) | Gets the average entry price of the account position |
| [GetUnrealizedProfitLoss()](position_getunrealizedprofitloss.md) | Gets the unrealized PnL for the account |
| [Instrument](position_instrument.md) | An [Instrument](instrument.md) value representing the instrument of an order |
| [MarketPosition](position_marketposition.md) | Gets the current market position of the account   Possible values: MarketPosition.Flat MarketPosition.Long MarketPosition.Short |
| [Quantity](position_quantity.md) | Gets the current account position size |
| ToString() | A string representation of an account position |



 


 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the average entry price      Print("The average entry price is " \+ PositionAccount.AveragePrice); } |



 


 








