



Rounding values to the nearest tick size

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](rounding_values_to_the_nearest.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Educational Resources](educational_resources.htm) > [Reference Samples](reference_samples.htm) > [Strategy](strategy2.htm) >  Rounding values to the nearest tick size | [Previous page](resetting_values_at_the_beginn.htm) [Return to chapter overview](strategy2.htm) [Next page](scaling_out_of_a_position.htm) |

When NinjaTrader receives a request to submit an order, it automatically rounds any limit price or stop price to the nearest tick for that specific instrument.

When debugging and/or printing out order information, this may not be apparent. NinjaTrader includes a Method named RoundToTickSize to apply the same internal rounding to any value you wish, which can help make comparisons easier.

Key concepts in this example
----------------------------

•Rounding a value to the nearest tick

Important related documentation
-------------------------------

•[RoundToTickSize()](roundtoticksize.htm)

•[EnterLongLimit()](enterlonglimit.htm)

•[ExitLong()](exitlong.htm)

•[CrossAbove()](crossabove.htm)

•[CrossBelow()](crossbelow.htm)

Import instructions
-------------------

1.Download the file contained in this Help Guide topic to your PC desktop

2.From the Control Center window, select the menu Tools > Import > NinjaScript

3.Select the downloaded file

[SampleRoundToTickSize\_NT8.zip](https://ninjatrader.com/support/helpGuides/nt8/samples/SampleRoundToTickSize_NT8.zip)