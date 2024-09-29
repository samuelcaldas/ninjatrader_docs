


NinjaScript \> Educational Resources \> Reference Samples \> Strategy \> Rounding values to the nearest tick size






















Rounding values to the nearest tick size







| \<\< [Click to Display Table of Contents](rounding_values_to_the_nearest.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Educational Resources](educational_resources-1.md) \> [Reference Samples](reference_samples-1.md) \> [Strategy](strategy2-1.md) \> Rounding values to the nearest tick size | [Previous page](resetting_values_at_the_beginn-1.md) [Return to chapter overview](strategy2-1.md) [Next page](scaling_out_of_a_position-1.md) |
| --- | --- |











When NinjaTrader receives a request to submit an order, it automatically rounds any limit price or stop price to the nearest tick for that specific instrument. 


 


When debugging and/or printing out order information, this may not be apparent. NinjaTrader includes a Method named RoundToTickSize to apply the same internal rounding to any value you wish, which can help make comparisons easier.


 


## Key concepts in this example


•Rounding a value to the nearest tick

 


## Important related documentation


•[RoundToTickSize()](roundtoticksize-1.md)

•[EnterLongLimit()](enterlonglimit-1.md)

•[ExitLong()](exitlong-1.md)

•[CrossAbove()](crossabove-1.md)

•[CrossBelow()](crossbelow-1.md)

 


## Import instructions


1\.Download the file contained in this Help Guide topic to your PC desktop

2\.From the Control Center window, select the menu Tools \> Import \> NinjaScript

3\.Select the downloaded file

 


[SampleRoundToTickSize\_NT8\.zip](samples/SampleRoundToTickSize_NT8.zip)








