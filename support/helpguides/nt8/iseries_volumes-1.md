


NinjaScript \> Language Reference \> Common \> ISeries\<T\> \> VolumeSeries\<double\> \> Volumes






















Volumes







| \<\< [Click to Display Table of Contents](iseries_volumes.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [ISeries\<T\>](iseriest-1.md) \> [VolumeSeries\<double\>](volumeseries-1.md) \> Volumes | [Previous page](iseries_volume-1.md) [Return to chapter overview](volumeseries-1.md) [Next page](iseries_count-1.md) |
| --- | --- |











## Definition


Holds an array of ISeries\<double\> objects holding historical bar volumes. An ISeries\<double\> object is added to this array when calling the [AddDataSeries()](adddataseries-1.md) method. Its purpose is to provide access to the volumes of all Bars objects in a multi\-instrument or multi\-time frame script. 


 




| Note:    For working with [Cryptocurrency instruments](instrumenttype-1.md) which report volume fractional, please use the [VOL()](volume-1.md) indicator series, or store the volume for your script in a custom variable and convert alongside our [VOL()](volume-1.md) indicator (Instrument.MasterInstrument.InstrumentType \=\= InstrumentType.CryptoCurrency ? Core.Globals.ToCryptocurrencyVolume((long)Volume\[0]) : Volume\[0]). |
| --- |



 


 


## Property Value


An array of ISeries\<double\> objects.


 


## Syntax
Volumes\[int barSeriesIndex]\[int barsAgo]


## 


## 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.Configure)      {          // Adds a 5\-minute Bars object to the strategy and is automatically assigned          // a Bars object index of 1 since the primary data the strategy is run against          // set by the UI takes the index of 0\.          AddDataSeries("AAPL", BarsPeriodType.Minute, 5);      } }    protected override void OnBarUpdate() {       // Compares the primary bar's volume to the 5\-minute bar's volume      if (Volumes\[0]\[0] \> Volumes\[1]\[0])          Print("The primary bar's volume is greater"); } |









