



Time

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\iseries_time.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [ISeries<T>](iseriest-1.htm) > [TimeSeries<DateTime>](timeseries-1.htm) >  Time | [Previous page](timeseries-1.htm) [Return to chapter overview](timeseries-1.htm) [Next page](iseries_times-1.htm) |

Definition
----------

A collection of historical bar time stamp values.

Property Value
--------------

An ISeries<DateTime> object.

Syntax
------

Time  
Time[int barsAgo] (returns a [DateTime](http://msdn2.microsoft.com/en-us/library/system.datetime.aspx) structure)

Examples
--------

| ns |
| --- |
| // Prints the current bar time stamp  Print(Time[0].ToString());     // Checks if current time is greater than the bar time stamp  if (DateTime.Now.Ticks > Time[0].Ticks)       Print("Do something"); |