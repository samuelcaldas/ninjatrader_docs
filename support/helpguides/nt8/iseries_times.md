
NinjaScript \> Language Reference \> Common \> ISeries\<T\> \> TimeSeries\<DateTime\> \> Times

Times

| \<\< [Click to Display Table of Contents](iseries_times.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [ISeries\<T\>](iseriest.md) \> [TimeSeries\<DateTime\>](timeseries.md) \> Times | [Previous page](iseries_time.md) [Return to chapter overview](timeseries.md) [Next page](volumeseries.md) |
| --- | --- |
## Definition
Holds an array of ISeries\<DateTime\> objects holding historical bar times. A ISeries\<DateTime\> object is added to this array when calling the [AddDataSeries()](adddataseries.md) method. Its purpose is to provide access to the times of all Bars objects in a multi\-instrument or multi\-time frame script.
 
## Property Value
An array of ISeries\<DateTime\> objects.
 
## Syntax
Times\[int barSeriesIndex]\[int barsAgo]
 
## 
## Examples

| ns |
| --- |
| protected override void OnStateChange()  {      if (State \=\= State.Configure)      {          // Adds a 5\-minute Bars object to the strategy and is automatically assigned           // a Bars object index of 1 since the primary data the strategy is run against           // set by the UI takes the index of 0\.           AddDataSeries("AAPL", BarsPeriodType.Minute, 5);      } }   protected override void OnBarUpdate() {      // Compares the primary bar's time to the 5\-minute bar's time      if (Times\[0]\[0].Ticks \> Times\[1]\[0].Ticks)          Print("The current bar's time is greater"); } |
