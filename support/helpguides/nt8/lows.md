
NinjaScript \> Language Reference \> Common \> ISeries\<T\> \> PriceSeries\<double\> \> Lows
Lows
| \<\< [Click to Display Table of Contents](lows.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [ISeries\<T\>](iseriest.md) \> [PriceSeries\<double\>](priceseries.md) \> Lows | [Previous page](low.md) [Return to chapter overview](priceseries.md) [Next page](median.md) |
| --- | --- |
## Definition
Holds an array of ISeries\<double\> objects holding historical bar low prices. An ISeries\<double\> object is added to this array when calling the [AddDataSeries()](adddataseries.md) method. Its purpose is to provide access to the low prices of all Bars objects in a multi\-instrument or multi\-time frame script. 
 
## Property Value
An array of ISeries\<double\> objects.
 
## Syntax
Lows\[int barSeriesIndex]\[int barsAgo]
## 
 
## Examples
| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.Configure)      {          // Adds a 5\-minute Bars object to the strategy and is automatically assigned          // a Bars object index of 1 since the primary data the strategy is run against          // set by the UI takes the index of 0\.          AddDataSeries("AAPL", BarsPeriodType.Minute, 5);      } }   protected override void OnBarUpdate() {      // Compares the primary bar's low price to the 5\-minute bar's low price      if (Lows\[0]\[0] \> Lows\[1]\[0])          Print("The primary bar's low price is greater"); } |
