# Using CancelOrder() method to cancel orders

When using NinjaTrader's Enter() and Exit() methods, the default behavior is to automatically expire them at the end of a bar unless they are resubmitted to keep them alive. Sometimes you may want more flexibility in this behavior and wish to submit orders as live-until-cancelled. When orders are submitted as live-until-cancelled, the way to cancel them is by using the CancelOrder() method.

## Key concepts in this example

- Submitting live-until-cancelled entry orders

- Manually cancelling orders

## Important related documentation

- [CancelOrder()](../addons/cancel.md)

- [Order](order.md)

- [OnOrderUpdate()](onorderupdate.md)

- [OnExecutionUpdate()](onexecutionupdate.md)

- [EnterLongLimit()](enterlonglimit.md)

## Import instructions

1.Download the file contained in this Help Guide topic to your PC desktop

2.From the Control Center window, select the menu Tools > Import > NinjaScript

3.Select the downloaded file

[SampleCancelOrder\_NT8.zip](https://ninjatrader.com/support/helpGuides/nt8/samples/SampleCancelOrder_NT8.zip)
