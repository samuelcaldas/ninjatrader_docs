



Keeping orders alive

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\keeping_orders_alive.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Educational Resources](educational_resources-1.htm) > [Reference Samples](reference_samples-1.htm) > [Strategy](strategy2-1.htm) >  Keeping orders alive | [Previous page](halting_a_strategy_once_user_d-1.htm) [Return to chapter overview](strategy2-1.htm) [Next page](modifying_the_price_of_stop_lo-1.htm) |

The default behavior for NinjaTrader is to cancel limit orders if the trigger conditions are no longer true. It is possible to submit orders that stay active until cancelled by setting liveUntilCancelled to true. This sample demonstrates and explains the difference between submitting an order with isLiveUntilCancelled true and false. The comments contain a longer, more detailed explanation.

Key concepts in this example:
-----------------------------

•How to submit an order that stays active until it is explicitly canceled\*

\*Another sample demonstrating how to explicitly cancel orders can be found here: [Using CancelOrder() method to cancel orders](using_cancelorder_method_to_ca-1.htm)

Important related documentation
-------------------------------

•[EnterLongLimit()](enterlonglimit-1.htm)

•[isliveUntilCancelled](exitlonglimit-1.htm)

•[CrossAbove()](crossabove-1.htm)

•[CrossBelow()](crossbelow-1.htm)

Import instructions
-------------------

1.Download the file contained in this Help Guide topic to your PC desktop

2.From the Control Center window, select the menu Tools > Import > NinjaScript

3.Select the downloaded file

[SampleIsLiveUntilCanceled\_NT8.zip](samples/SampleIsLiveUntilCanceled_NT8.zip)