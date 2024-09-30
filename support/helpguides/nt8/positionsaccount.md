
NinjaScript > Language Reference > Strategy > PositionsAccount

PositionsAccount

| << [Click to Display Table of Contents](positionsaccount.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > PositionsAccount | [Previous page](positions.md) [Return to chapter overview](strategy.md) [Next page](realtimeerrorhandling.md) |
| --- | --- |
## Definition
Holds an array of [PositionAccount](positionaccount.md) objects that represent positions managed by the strategy's account. This property should only be used when your strategy is executing orders against [multiple instruments](multi-time_frame__instruments.md).
 
Index value is based on the the array of Bars objects added via the [AddDataSeries()](adddataseries.md) method. For example:
 
First Bars is ES 1 Minute   

Secondary Bars is ES 5 Minute   

Third Bars is NQ 5 Minute
 
PositionsAccount[0] == ES position  

PositionsAccount[1] == Always a flat position, ES position will always be PositionsAccount[0]  

PositionsAccount[2] == NQ position
 

| Tips: - For single instrument scripts, please see [PositionAccount](positionaccount.md) object- For Strategy Positions, please see [Positions](positions.md) |
| --- |

## Property Value
An array of [PositionAccount](positionaccount.md) objects.
 
## Syntax
PositionsAccount[int index]
## 
 
## Examples

| ns |
| --- |
| protected override void OnStateChange() {    if (State == State.SetDefaults)    {                  Name = "ExampleStrategy";        }           else if (State == State.Configure)    {      AddDataSeries("ES 03-15", BarsPeriodType.Minute, 5);      AddDataSeries("NQ 03-15", BarsPeriodType.Minute, 5);           } }      protected override void OnBarUpdate() {      Print("ES account position is " + PositionsAccount[0].MarketPosition);      Print("NQ account position is " + PositionsAccount[2].MarketPosition);        // Alternative approach. By checking what Bars object is calling the OnBarUpdate()      // method, we can just use the Position property since its pointing to the correct      // position.      if (BarsInProgress == 0)          Print("ES account position is " + PositionAccount.MarketPosition);      else if (BarsInProgress == 2)          Print("NQ account position is " + PositionAccount.MarketPosition); } |
