


NinjaScript \> Educational Resources \> Reference Samples \> Strategy \> Using trade performance statistics for money management






















Using trade performance statistics for money management







| \<\< [Click to Display Table of Contents](using_trade_performance_statis.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Educational Resources](educational_resources-1.md) \> [Reference Samples](reference_samples-1.md) \> [Strategy](strategy2-1.md) \> Using trade performance statistics for money management | [Previous page](using_isrising_and_isfalling_c-1.md) [Return to chapter overview](strategy2-1.md) [Next page](tips-1.md) |
| --- | --- |











For money management reasons you may want to limit your strategy from aggressive daytrading or you may want to cut your losses short on volatile sessions that are not playing out in your favor. This can be done through the utilization of the Performance object.


## 


## Key concepts in this example


•Locking in realized profits after a certain amount of gains have been achieved during the trading session

•Cutting realized losses short after a certain amount of losses have been accrued over the trading session

•Preventing aggressive amounts of trading

 


## Important related documentation


•[SystemPerformance](systemperformance-1.md)

•[TradeCollection](tradecollection-1.md)

•[AllTrades\*](alltrades-1.md)

 


\* This reference sample uses the .AllTrades property. This property will include all historical virtual trades as well as real\-time trades. If you wish to only make calculations based on real\-time trades you can use the .RealtimeTrades property.


 


## Import instructions


1\.Download the file contained in this Help Guide topic to your PC desktop

2\.From the Control Center window, select the menu Tools \> Import \> NinjaScript

3\.Select the downloaded file

 


[SamplePnL\_NT8\.zip](samples/SamplePnL_NT8.zip)








