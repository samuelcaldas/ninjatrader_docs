


NinjaScript \> Educational Resources \> Reference Samples \> Strategy \> Stopping a strategy after consecutive losers






















Stopping a strategy after consecutive losers







| \<\< [Click to Display Table of Contents](stopping_a_strategy_after_cons.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Educational Resources](educational_resources.md) \> [Reference Samples](reference_samples.md) \> [Strategy](strategy2.md) \> Stopping a strategy after consecutive losers | [Previous page](separating_logic_to_either_cal.md) [Return to chapter overview](strategy2.md) [Next page](trading_crossovers.md) |
| --- | --- |











Trending days or ranging days can make or break a strategy. If you have a system that does extremely well on trending days, you may look for a way to turn that system off during range\-bound days. A simple filter you may use could be something like, "If the last three trades were consecutive losers, stop trading for the rest of the session


 


## Key concepts in this example


•Obtaining previous trade information to decide whether or not to keep trading for the day

 


## Important related documentation


•[SystemPerformance](systemperformance.md)

•[TradeCollection](tradecollection.md)

•[AllTrades\*](alltrades.md)

•[EnterLong()](enterlong.md)

•[ExitLong()](exitlong.md)

•[IsFirstBarOfSession](isfirstbarofsession.md)

•[IsFirstTickOfBar](isfirsttickofbar.md)

 


\* This reference sample uses the .AllTrades property. This property will include all historical virtual trades as well as real\-time trades. If you wish to only make calculations based on real\-time trades you can use the .RealtimeTrades property.


 


## Import instructions


1\.Download the file contained in this Help Guide topic to your PC desktop

2\.From the Control Center window, select the menu Tools \> Import \> NinjaScript

3\.Select the downloaded file

 


[SampleTradeObjects\_Nt8\.zip](https://ninjatrader.com/support/helpGuides/nt8/samples/SampleTradeObjects_Nt8.zip)








