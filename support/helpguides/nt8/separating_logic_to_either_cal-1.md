


NinjaScript \> Educational Resources \> Reference Samples \> Strategy \> Separating logic to either calculate once on bar close or on every tick






















Separating logic to either calculate once on bar close or on every tick







| \<\< [Click to Display Table of Contents](separating_logic_to_either_cal.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Educational Resources](educational_resources-1.md) \> [Reference Samples](reference_samples-1.md) \> [Strategy](strategy2-1.md) \> Separating logic to either calculate once on bar close or on every tick | [Previous page](scaling_out_of_a_position-1.md) [Return to chapter overview](strategy2-1.md) [Next page](stopping_a_strategy_after_cons-1.md) |
| --- | --- |











Depending on your trade ideas, the timing of entries and exits could be crucial. Sometimes waiting 30 seconds for a bar to close is too long when you are trying to exit a position. To address this you could select your strategy to calculate on every single tick, but this may impact your entry timings. For example, crossover entries could flip back and forth making it difficult to place entry orders. If you are facing this issue, it is possible to separate out parts of your strategy logic to calculate on every single tick and other parts to calculate once at the end of each bar.


 


## Key concepts in this example


•Running some logic once per bar

•Running other logic on every single tick

 


## Important related documentation


•[Calculate](calculate-1.md)

•[IsFirstTickOfBar](isfirsttickofbar-1.md)

•[CrossBelow()](crossbelow-1.md)

•[EnterLong()](enterlong-1.md)

 


## Import instructions


1\.Download the file contained in this Help Guide topic to your PC desktop

2\.From the Control Center window, select the menu Tools \> Import \> NinjaScript

3\.Select the downloaded file

 


[SampleEnterOnceExitEveryTick\_NT8\.zip](samples/SampleEnterOnceExitEveryTick_NT8.zip)








