



Getting indicator values from a specified time

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](getting_indicator_values_from_.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Educational Resources](educational_resources.htm) > [Reference Samples](reference_samples.htm) > [Indicator](indicator2.htm) >  Getting indicator values from a specified time | [Previous page](exposing_indicator_values_that.htm) [Return to chapter overview](indicator2.htm) [Next page](manipulating_datetime_objects.htm) |

Sometimes, you may want to access a value from a historical point in time, but have not kept track of the value to make this readily available. With NinjaScript, it is possible to pick a bar based on time to access that value. GetBar() returns the number of bars ago that holds the same timestamp of the time you request. This sample demonstrates how to get an indicator value from 9:30AM of the previous trading day.

Key concepts in this example
----------------------------

•Obtaining a Simple Moving Average value from a specific time by referencing the bar number for that time.

Important related documentation
-------------------------------

•[GetBar()](getbar.htm)

•[Draw.Line()](draw_line.htm)

•[Time](iseries_time.htm)

•[Sessions](tradinghours_sessions.htm)

•[DateTime](https://msdn.microsoft.com/en-us/library/system.datetime(v=vs.110).aspx)

Import instructions
-------------------

1.Download the file contained in this Help Guide topic to your PC desktop

2.From the Control Center window, select the menu Tools > Import > NinjaScript

3.Select the downloaded file

[SampleGetBar\_NT8.zip](https://ninjatrader.com/support/helpGuides/nt8/samples/SampleGetBar_NT8.zip)