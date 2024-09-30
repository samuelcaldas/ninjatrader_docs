
NinjaScript > Educational Resources > Reference Samples > Strategy > Entering on one time frame and exiting on another
Entering on one time frame and exiting on another
| << [Click to Display Table of Contents](entering_on_one_time_frame_and.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Educational Resources](educational_resources.md) > [Reference Samples](reference_samples.md) > [Strategy](strategy2.md) > Entering on one time frame and exiting on another | [Previous page](backtesting_ninjascript_strate.md) [Return to chapter overview](strategy2.md) [Next page](getting_pnl_from_an_atm_strate.md) |
| --- | --- |
You can submit orders to different bars objects. This allows you the flexibility of submitting orders to different timeframes. You can watch for trade conditions across different time frames and place orders on whichever one you want. This is useful for strategies that require more finesse in the exit than the entry. You can now enter trades on longer time frames and then monitor and exit your trade on a more granular time frame.
## 
## Key concepts in this example
- Comparing values across multiple time frames

- Submitting orders to a non-primary bar object

 
## Important related documentation
- [BarsArray](barsarray.md)

- [BarsInProgress](barsinprogress.md)

- [AddDataSeries()](adddataseries.md)

- [BarsSinceExitExecution()](barssinceexitexecution.md)

- [BarsRequiredToTrade()](barsrequiredtotrade.md)

- [EnterLongLimit()](enterlonglimit.md)

 
## Import instructions
1.Download the file contained in this Help Guide topic to your PC desktop

2.From the Control Center window, select the menu Tools > Import > NinjaScript

3.Select the downloaded file

 
[SampleMultiTimeFrameOrders_NT8.zip](https://ninjatrader.com/support/helpGuides/nt8/samples/SampleMultiTimeFrameOrders_NT8.zip)

