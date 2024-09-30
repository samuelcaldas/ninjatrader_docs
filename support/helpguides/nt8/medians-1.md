
NinjaScript > Language Reference > Common > ISeries<T> > PriceSeries<double> > Medians

Medians

| << [Click to Display Table of Contents](medians.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [ISeries<T>](iseriest-1.md) > [PriceSeries<double>](priceseries-1.md) > Medians | [Previous page](median-1.md) [Return to chapter overview](priceseries-1.md) [Next page](open-1.md) |
| --- | --- |
## Definition
Holds an array of ISeries<double> objects holding historical bar median prices. An ISeries<double>> object is added to this array when calling the [AddDataSeries()](adddataseries-1.md) method. Its purpose is to provide access to the median prices of all Bars objects in a multi-instrument or multi-time frame script. 
 
## Property Value
An array of ISeries<double> objects.
 
## Syntax
Medians[int barSeriesIndex][int barsAgo]
 
## 
## Examples

| ns |
| --- |
| protected override void OnStateChange() {      if (State == State.Configure)      {          // Adds a 5-minute Bars object to the strategy and is automatically assigned          // a Bars object index of 1 since the primary data the strategy is run against          // set by the UI takes the index of 0.          AddDataSeries("AAPL", BarsPeriodType.Minute, 5);       } }    protected override void OnBarUpdate()  {       // Compares the primary bar's median price to the 5-minute bar's median price      if (Medians[0][0] > Medians[1][0])           Print("The primary bar's median price is greater");  } |
