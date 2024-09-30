
NinjaScript \> Educational Resources \> Reference Samples \> Indicator \> Getting indicator values from a specified time

Getting indicator values from a specified time

| \<\< [Click to Display Table of Contents](getting_indicator_values_from_.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Educational Resources](educational_resources-1.md) \> [Reference Samples](reference_samples-1.md) \> [Indicator](indicator2-1.md) \> Getting indicator values from a specified time | [Previous page](exposing_indicator_values_that-1.md) [Return to chapter overview](indicator2-1.md) [Next page](manipulating_datetime_objects-1.md) |
| --- | --- |
Sometimes, you may want to access a value from a historical point in time, but have not kept track of the value to make this readily available. With NinjaScript, it is possible to pick a bar based on time to access that value. GetBar() returns the number of bars ago that holds the same timestamp of the time you request. This sample demonstrates how to get an indicator value from 9:30AM of the previous trading day.
 
## Key concepts in this example
- Obtaining a Simple Moving Average value from a specific time by referencing the bar number for that time.

 
## Important related documentation
- [GetBar()](getbar-1.md)

- [Draw.Line()](draw_line-1.md)

- [Time](iseries_time-1.md)

- [Sessions](tradinghours_sessions-1.md)

- [DateTime](https://msdn.microsoft.com/en-us/library/system.datetime(v=vs.110).aspx)

 
## Import instructions
1\.Download the file contained in this Help Guide topic to your PC desktop

2\.From the Control Center window, select the menu Tools \> Import \> NinjaScript

3\.Select the downloaded file

 
[SampleGetBar\_NT8\.zip](samples/SampleGetBar_NT8.zip)
