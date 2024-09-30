
NinjaScript \> Language Reference \> Strategy \> PositionAccount

PositionAccount

| \<\< [Click to Display Table of Contents](positionaccount.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> PositionAccount | [Previous page](position_quantity-1.md) [Return to chapter overview](strategy-1.md) [Next page](positionaccount_averageprice-1.md) |
| --- | --- |
## Definition
Represents position related information that pertains to real\-world account (live or simulation).  
 

| Tips: - For multi\-instrument scripts, please see [PositionsAccount](positionsaccount-1.md) object which holds an array of all instrument positions managed by the strategy's account- For a Strategy Position, please see [Position](position-1.md) |
| --- |

## Methods and Properties

| Account | An [Account](account_class-1.md) object which corresponds to the position |
| --- | --- |
| [AveragePrice](position_averageprice-1.md) | Gets the average entry price of the account position |
| [GetUnrealizedProfitLoss()](position_getunrealizedprofitloss-1.md) | Gets the unrealized PnL for the account |
| [Instrument](position_instrument-1.md) | An [Instrument](instrument-1.md) value representing the instrument of an order |
| [MarketPosition](position_marketposition-1.md) | Gets the current market position of the account   Possible values: MarketPosition.Flat MarketPosition.Long MarketPosition.Short |
| [Quantity](position_quantity-1.md) | Gets the current account position size |
| ToString() | A string representation of an account position |

## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {      // Print out the average entry price      Print("The average entry price is " \+ PositionAccount.AveragePrice); } |

