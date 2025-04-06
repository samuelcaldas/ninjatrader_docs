



Using multiple entry/exit signals simultaneously

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](using_multiple_entry_exit_sign.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Educational Resources](educational_resources.htm) > [Reference Samples](reference_samples.htm) > [Strategy](strategy2.htm) >  Using multiple entry/exit signals simultaneously | [Previous page](using_cancelorder_method_to_ca.htm) [Return to chapter overview](strategy2.htm) [Next page](using_onorderupdate_and_onexec.htm) |

Sometimes you want to trade an instrument with several different possible entry conditions. To keep track of which trade used which conditions can become cumbersome if done on paper.

The attached reference sample demonstrates the following key concepts:
----------------------------------------------------------------------

•Adding user definable indicators to the strategy for display on the chart

•Setting the manner in which NinjaTrader handles entry orders

•Using unique identifiers for entry and exit orders

Important methods and properties used include:
----------------------------------------------

•[AddChartIndicator()](addchartindicator.htm)

•[EntriesPerDirection\*](entriesperdirection.htm)

•[EntryHandling\*](entryhandling.htm)

\* Entry handling properties can be either programmatically set or set through the Strategy dialog window

Other methods and properties of interest include:
-------------------------------------------------

•[EnterLongLimit()](enterlonglimit.htm)

•[EnterLongStopMarket()](enterlongstopmarket.htm)

•[EnterLongStopLimit()](enterlongstoplimit.htm)

Import instructions
-------------------

1.Download the file contained in this Help Guide topic to your PC desktop

2.From the Control Center window, select the menu Tools > Import > NinjaScript

3.Select the downloaded file

[SampleMultipleEntryExitSignals\_NT8.zip](https://ninjatrader.com/support/helpGuides/nt8/samples/SampleMultipleEntryExitSignals_NT8.zip)