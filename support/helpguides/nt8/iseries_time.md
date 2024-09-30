
NinjaScript > Language Reference > Common > ISeries<T> > TimeSeries<DateTime> > Time

Time

| << [Click to Display Table of Contents](iseries_time.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [ISeries<T>](iseriest.md) > [TimeSeries<DateTime>](timeseries.md) > Time | [Previous page](timeseries.md) [Return to chapter overview](timeseries.md) [Next page](iseries_times.md) |
| --- | --- |
## Definition
A collection of historical bar time stamp values.
 
## Property Value
An ISeries<DateTime> object.
 
## Syntax
Time  

Time[int barsAgo] (returns a [DateTime](http://msdn2.microsoft.com/en-us/library/system.datetime.aspx) structure)
 
## 
## Examples

| ns |
| --- |
| // Prints the current bar time stamp Print(Time[0].ToString());   // Checks if current time is greater than the bar time stamp if (DateTime.Now.Ticks > Time[0].Ticks)      Print("Do something"); |
