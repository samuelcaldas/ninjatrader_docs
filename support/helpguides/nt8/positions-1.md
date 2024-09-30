
NinjaScript \> Language Reference \> Strategy \> Positions

Positions

| \<\< [Click to Display Table of Contents](positions.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> Positions | [Previous page](positionaccount_quantity-1.md) [Return to chapter overview](strategy-1.md) [Next page](positionsaccount-1.md) |
| --- | --- |
## Definition
Holds an array of [Position](position-1.md) objects that represent positions managed by the strategy. This property should only be used when your strategy is executing orders against [multiple instruments](multi-time_frame__instruments-1.md).
 
Index value is based on the the array of Bars objects added via the [AddDataSeries()](adddataseries-1.md) method. For example:
 
First Bars is ES 1 Minute   

Secondary Bars is ES 5 Minute   

Third Bars is NQ 5 Minute
 
Positions\[0] \=\= ES position  

Positions\[1] \=\= Always a flat position, ES position will always be Positions\[0]  

Positions\[2] \=\= NQ position

| Tips: - For single instrument scripts, please see [Position](position-1.md) object- For a real\-world Account Positions, please see [PositionsAccount](positions_account-1.md) |
| --- |

## Property Value
An array of Position objects.
 
## Syntax
Positions\[int index]
## 
 
## Examples

| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.Configure)      {          AddDataSeries("ES 09\-14", BarsPeriodType.Minute, 5);          AddDataSeries("NQ 09\-14", BarsPeriodType.Minute, 5);      } }   protected override void OnBarUpdate() {      Print("ES position is " \+ Positions\[0].MarketPosition);      Print("NQ positions is " \+ Positions\[2].MarketPosition);        // Alternative approach. By checking what Bars object is calling the OnBarUpdate()      // method, we can just use the Position property since its pointing to the correct      // position.      if (BarsInProgress \=\= 0)          Print("ES position is " \+ Position.MarketPosition);      else if (BarsInProgress \= 2)          Print("NQ position is " \+ Position.MarketPosition); } |
