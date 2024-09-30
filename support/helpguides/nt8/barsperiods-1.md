
NinjaScript > Language Reference > Common > AddDataSeries() > BarsPeriods
BarsPeriods
| << [Click to Display Table of Contents](barsperiods.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [AddDataSeries()](adddataseries-1.md) > BarsPeriods | [Previous page](barsinprogress-1.md) [Return to chapter overview](adddataseries-1.md) [Next page](currentbars-1.md) |
| --- | --- |
## Definition
Holds an array of BarsPeriod objects synchronized to the number of unique Bars objects held within the parent NinjaScript object. If a  NinjaScript object holds two Bars series, then BarsPeriods will hold two BarsPeriod objects.
 
## Property Value
An array of [BarsPeriod](barsperiod-1.md) objects.
 
| Warning: This property should NOT be accessed within the [OnStateChange()](onstatechange-1.md) method before the State has reached State.DataLoaded |
| --- |
  

Syntax  

BarsPeriods[int barSeriesIndex]
## 
## 
## Examples
| ns |
| --- |
| protected override void OnStateChange() {      if (State == State.Configure)      {          // Adds a 5-minute Bars object to the strategy and is automatically assigned           // a Bars object index of 1 since the original data the strategy is ran on,          // set by the UI, takes the index of 0.           AddDataSeries("AAPL", BarsPeriodType.Minute, 5);       } }    protected override void OnBarUpdate()  {       // Print out 5, the value of the secondary bars object       if (BarsInProgress == 1)          Print(BarsPeriods[1].Value); } |

