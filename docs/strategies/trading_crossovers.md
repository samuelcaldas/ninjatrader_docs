# Trading crossovers

Similar in concept to a breakout, many traders like to trade crossovers. This can be a crossover of price from a certain threshold or even an indicator crossing over another indicator.

## Key concepts in this example

- Determining and storing the first 15 bar high and low values for the current session

- Submitting long or short entry orders depending on which threshold is crossed

- Using a trail stop to exit positions

 

> **Tip:** This reference sample sets Calculat to OnEachTick. The reason we are doing this is so we can submit orders as soon as a crossover occurs instead of waiting for the bar to close before submitting the order.

 

 

## Important related documentation

- [[[Calculate](../language_reference/calculate.md)

- [[[CrossAbove()](../language_reference/crossabove.md)

- [[[CrossBelow()](../language_reference/crossbelow.md)

- [[[SetTrailStop()](settrailstop.md)

- [[[SetStopLoss()](setstoploss.md)

- [[[SetProfitTarget()](setprofittarget.md)

## Import instructions

1.Download the file contained in this Help Guide topic to your PC desktop

2.From the Control Center window, select the menu Tools > Import > NinjaScript

3.Select the downloaded file

[[[SampleHighLowCross\_NT8.zip](https://ninjatrader.com/support/helpGuides/nt8/samples/SampleHighLowCross_NT8.zip)
