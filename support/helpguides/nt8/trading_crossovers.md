
NinjaScript \> Educational Resources \> Reference Samples \> Strategy \> Trading crossovers
Trading crossovers
| \<\< [Click to Display Table of Contents](trading_crossovers.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Educational Resources](educational_resources.md) \> [Reference Samples](reference_samples.md) \> [Strategy](strategy2.md) \> Trading crossovers | [Previous page](stopping_a_strategy_after_cons.md) [Return to chapter overview](strategy2.md) [Next page](using_a_time_filter_to_limit_t.md) |
| --- | --- |
Similar in concept to a breakout, many traders like to trade crossovers. This can be a crossover of price from a certain threshold or even an indicator crossing over another indicator.
 
## Key concepts in this example
- Determining and storing the first 15 bar high and low values for the current session

- Submitting long or short entry orders depending on which threshold is crossed

- Using a trail stop to exit positions

 
| Tip: This reference sample sets Calculat to OnEachTick. The reason we are doing this is so we can submit orders as soon as a crossover occurs instead of waiting for the bar to close before submitting the order. |
| --- |

## Important related documentation
- [Calculate](calculate.md)

- [CrossAbove()](crossabove.md)

- [CrossBelow()](crossbelow.md)

- [SetTrailStop()](settrailstop.md)

- [SetStopLoss()](setstoploss.md)

- [SetProfitTarget()](setprofittarget.md)

 
## Import instructions
1\.Download the file contained in this Help Guide topic to your PC desktop

2\.From the Control Center window, select the menu Tools \> Import \> NinjaScript

3\.Select the downloaded file

 
[SampleHighLowCross\_NT8\.zip](https://ninjatrader.com/support/helpGuides/nt8/samples/SampleHighLowCross_NT8.zip)
