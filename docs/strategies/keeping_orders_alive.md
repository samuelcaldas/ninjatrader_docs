# Keeping orders alive

The default behavior for NinjaTrader is to cancel limit orders if the trigger conditions are no longer true. It is possible to submit orders that stay active until cancelled by setting liveUntilCancelled to true. This sample demonstrates and explains the difference between submitting an order with isLiveUntilCancelled true and false. The comments contain a longer, more detailed explanation.

## Key concepts in this example:

- How to submit an order that stays active until it is explicitly canceled\*

\*Another sample demonstrating how to explicitly cancel orders can be found here: [Using CancelOrder() method to cancel orders](using_cancelorder_method_to_ca.md)

## Important related documentation

- [EnterLongLimit()](enterlonglimit.md)

- [isliveUntilCancelled](exitlonglimit.md)

- [CrossAbove()](../language_reference/crossabove.md)

- [CrossBelow()](../language_reference/crossbelow.md)

## Import instructions

1.Download the file contained in this Help Guide topic to your PC desktop

2.From the Control Center window, select the menu Tools > Import > NinjaScript

3.Select the downloaded file

[SampleIsLiveUntilCanceled\_NT8.zip](https://ninjatrader.com/support/helpGuides/nt8/samples/SampleIsLiveUntilCanceled_NT8.zip)
