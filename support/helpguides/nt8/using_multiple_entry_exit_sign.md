


NinjaScript \> Educational Resources \> Reference Samples \> Strategy \> Using multiple entry/exit signals simultaneously






















Using multiple entry/exit signals simultaneously







| \<\< [Click to Display Table of Contents](using_multiple_entry_exit_sign.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Educational Resources](educational_resources.md) \> [Reference Samples](reference_samples.md) \> [Strategy](strategy2.md) \> Using multiple entry/exit signals simultaneously | [Previous page](using_cancelorder_method_to_ca.md) [Return to chapter overview](strategy2.md) [Next page](using_onorderupdate_and_onexec.md) |
| --- | --- |











Sometimes you want to trade an instrument with several different possible entry conditions. To keep track of which trade used which conditions can become cumbersome if done on paper.


 


## The attached reference sample demonstrates the following key concepts:


•Adding user definable indicators to the strategy for display on the chart

•Setting the manner in which NinjaTrader handles entry orders

•Using unique identifiers for entry and exit orders

 


## Important methods and properties used include:


•[AddChartIndicator()](addchartindicator.md)

•[EntriesPerDirection\*](entriesperdirection.md)

•[EntryHandling\*](entryhandling.md)

\* Entry handling properties can be either programmatically set or set through the Strategy dialog window


 


## Other methods and properties of interest include:


•[EnterLongLimit()](enterlonglimit.md)

•[EnterLongStopMarket()](enterlongstopmarket.md)

•[EnterLongStopLimit()](enterlongstoplimit.md)

 


## Import instructions


1\.Download the file contained in this Help Guide topic to your PC desktop

2\.From the Control Center window, select the menu Tools \> Import \> NinjaScript

3\.Select the downloaded file

 


[SampleMultipleEntryExitSignals\_NT8\.zip](https://ninjatrader.com/support/helpGuides/nt8/samples/SampleMultipleEntryExitSignals_NT8.zip)








