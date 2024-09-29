


NinjaScript \> Language Reference \> Common \> ISeries\<T\> \> TimeSeries\<DateTime\> \> Time






















Time







| \<\< [Click to Display Table of Contents](iseries_time.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [ISeries\<T\>](iseriest-1.md) \> [TimeSeries\<DateTime\>](timeseries-1.md) \> Time | [Previous page](timeseries-1.md) [Return to chapter overview](timeseries-1.md) [Next page](iseries_times-1.md) |
| --- | --- |











## Definition


A collection of historical bar time stamp values.


 


## Property Value


An ISeries\<DateTime\> object.


 


## Syntax


Time  

Time\[int barsAgo] (returns a [DateTime](http://msdn2.microsoft.com/en-us/library/system.datetime.aspx) structure)


 


## 


## Examples




| ns |
| --- |
| // Prints the current bar time stamp Print(Time\[0].ToString());   // Checks if current time is greater than the bar time stamp if (DateTime.Now.Ticks \> Time\[0].Ticks)      Print("Do something"); |









