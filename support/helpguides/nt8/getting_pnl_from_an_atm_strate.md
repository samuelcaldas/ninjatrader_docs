
NinjaScript \> Educational Resources \> Reference Samples \> Strategy \> Getting PnL from an ATM strategy

Getting PnL from an ATM strategy

| \<\< [Click to Display Table of Contents](getting_pnl_from_an_atm_strate.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Educational Resources](educational_resources.md) \> [Reference Samples](reference_samples.md) \> [Strategy](strategy2.md) \> Getting PnL from an ATM strategy | [Previous page](entering_on_one_time_frame_and.md) [Return to chapter overview](strategy2.md) [Next page](halting_a_strategy_once_user_d.md) |
| --- | --- |
When integrating Advanced Trade Management templates into NinjaScript Strategies, the procedure for obtaining trade performance and order status is a little different than for strategies without ATM templates. The difference is that ATM templates basically take over and manage the trade separately from the NinjaScript portion of the strategy. Until the ATM trade terminates, the NinjaScript portion just observes and waits for another trading opportunity. Accessing all the trade data is still possible, but the set of commands to use differ from the traditional NinjaScript commands. This sample borrows code from the built\-in strategy SampleAtmStrategy and doesn't include all the references specific to that strategy. In addition, this sample draws some profit/loss information right on the chart.
 

| Note: This is a real\-time strategy only. You will also need to first setup an ATM template titled "AtmStrategyTemplate" for this sample to work. You can set this up in the SuperDOM or Chart Trader windows. |
| --- |
## 
## 
## Key concepts in this example
- Obtaining unrealized and realized profit/loss from ATM templates initiated by a NinjaScript strategy

- Keeping a running total of all the realized profits/losses

 
## Important related documentation
- [GetAtmStrategyRealizedProfitLoss()](getatmstrategyrealizedprofitlo.md)

- [GetAtmStrategyUnrealizedProfitLoss()](getatmstrategyunrealizedprofit.md)

- [Draw.TextFixed()](draw_textfixed.md)

- [RoundToTickSize()](roundtoticksize.md)

 
## Import instructions
1\.Download the file contained in this Help Guide topic to your PC desktop

2\.From the Control Center window, select the menu Tools \> Import \> NinjaScript

3\.Select the downloaded file

 
[SampleATMPnL\_NT8\.zip](https://ninjatrader.com/support/helpGuides/nt8/samples/SampleATMPnL_NT8.zip)
