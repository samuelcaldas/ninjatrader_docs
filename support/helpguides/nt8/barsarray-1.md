
NinjaScript > Language Reference > Common > AddDataSeries() > BarsArray
BarsArray
| << [Click to Display Table of Contents](barsarray.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [AddDataSeries()](adddataseries-1.md) > BarsArray | [Previous page](addvolumetric-1.md) [Return to chapter overview](adddataseries-1.md) [Next page](barsinprogress-1.md) |
| --- | --- |
## Definition
An array holding Bars objects that are added via the [AddDataSeries()](adddataseries-1.md) method. BarsArray can be used as input for [indicator methods](indicators-1.md). This property is of primary value when working with [multi-time frame or multi-instrument scripts](multi-time_frame__instruments-1.md).
 
## Property Value
An array of [Bars](bars-1.md) objects.
 
| Warning:  This property should NOT be accessed within the [OnStateChange()](onstatechange-1.md) method before the State has reached State.DataLoaded |
| --- |

## Syntax
BarsArray[int index]
## 
## Examples
| ns |
| --- |
| protected override void OnStateChange() {      if (State == State.SetDefaults)    {      Name = "Examples Indicator";          }    else if (State == State.Configure)    {      // Add a 5 minute Bars object which is added to the BarArray       // which will take index 1 since the primary Bars object of the strategy       // will be index 0       AddDataSeries(BarsPeriodType.Minute, 5);     } }    protected override void OnBarUpdate()  {     // Ignore bar update events for the supplementary Bars object added above     if (BarsInProgress == 1)       return;       // Pass in a Bars object as input for the simple moving average method     // Evaluates if the 20 SMA of the primary Bars is greater than     // the 20 SMA of the secondary Bars added above     if (SMA(20)[0] > SMA(BarsArray[1], 20)[0])       EnterLong();  } |

