
NinjaScript > Educational Resources > Reference Samples > Strategy > Backtesting NinjaScript Strategies with an intrabar granularity

Backtesting NinjaScript Strategies with an intrabar granularity

| << [Click to Display Table of Contents](backtesting_ninjascript_strate.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Educational Resources](educational_resources-1.md) > [Reference Samples](reference_samples-1.md) > [Strategy](strategy2-1.md) > Backtesting NinjaScript Strategies with an intrabar granularity | [Previous page](strategy2-1.md) [Return to chapter overview](strategy2-1.md) [Next page](entering_on_one_time_frame_and-1.md) |
| --- | --- |
You can submit orders to different Bars objects. This allows you the flexibility of submitting orders to different timeframes. Like in live trading, taking entry conditions from a 5min chart means executing your order as soon as possible instead of waiting until the next 5min bar starts building. You can achieve this by submitting your orders to a more granular secondary bar series to achieve an "intrabar" fill.
 
## Key concepts in this example
- Finding entry conditions on the primary bar object

- Submitting orders to the secondary bar object for an intrabar fill

## 
## Important related documentation
- [AddDataSeries()](adddataseries-1.md)

- [BarsInProgress](barsinprogress-1.md)

- [EnterLong()](enterlong-1.md)

- [BarsArray](barsarray-1.md)

- [EnterLongLimit()](enterlonglimit-1.md)

 
## Import instructions
1.Download the file contained in this Help Guide topic to your PC desktop

2.From the Control Center window, select the menu Tools > Import > NinjaScript

3.Select the downloaded file

 
[SampleIntrabarBacktest_NT8.zip](samples/SampleIntrabarBacktest_NT8.zip)
