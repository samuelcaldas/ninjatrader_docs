



Using Try-Catch Blocks

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](using_try-catch_blocks.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Educational Resources](educational_resources.htm) > [Reference Samples](reference_samples.htm) > [Indicator](indicator2.htm) >  Using Try-Catch Blocks | [Previous page](using_system_io_file_propertie.htm) [Return to chapter overview](indicator2.htm) [Next page](creating-chart-wpf-(ui)-modifi.htm) |

Debugging your NinjaScript code can be time consuming and frustrating. When NinjaTrader encounters a run-time exception in your programming logic it will terminate the execution of the script and log the exception to the Control Center Log tab. This in itself can be of value however, there may be times where your script is too large and the exception error message provided is not granular enough. This is where standard C# exception handling using the keywords "try" and "catch" (try-catch block) can be very useful. A try-catch block allows you to encapsulate a section of your code to trap exceptions and write out meaningful information that can help you resolve your run-time errors.

Key concepts in this example
----------------------------

•try-catch blocks

Important related documentation
-------------------------------

•[Log()](log.htm)

•[Print()](print.htm)

•[PrintTo()](printto.htm)

Import instructions
-------------------

1.Download the file contained in this Help Guide topic to your PC desktop

2.From the Control Center window, select the menu Tools > Import > NinjaScript

3.Select the downloaded file

[SampleTryCatch\_NT8.zip](https://ninjatrader.com/support/helpGuides/nt8/samples/SampleTryCatch_NT8.zip)