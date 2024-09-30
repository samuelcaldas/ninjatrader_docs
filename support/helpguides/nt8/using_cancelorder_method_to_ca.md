
NinjaScript \> Educational Resources \> Reference Samples \> Strategy \> Using CancelOrder() method to cancel orders
Using CancelOrder() method to cancel orders

| \<\< [Click to Display Table of Contents](using_cancelorder_method_to_ca.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Educational Resources](educational_resources.md) \> [Reference Samples](reference_samples.md) \> [Strategy](strategy2.md) \> Using CancelOrder() method to cancel orders | [Previous page](using_a_time_filter_to_limit_t.md) [Return to chapter overview](strategy2.md) [Next page](using_multiple_entry_exit_sign.md) |
| --- | --- |

When using NinjaTrader's Enter() and Exit() methods, the default behavior is to automatically expire them at the end of a bar unless they are resubmitted to keep them alive. Sometimes you may want more flexibility in this behavior and wish to submit orders as live\-until\-cancelled. When orders are submitted as live\-until\-cancelled, the way to cancel them is by using the CancelOrder() method.
 
## Key concepts in this example
- Submitting live\-until\-cancelled entry orders

- Manually cancelling orders

## 
## Important related documentation
- [CancelOrder()](cancel.md)

- [Order](order.md)

- [OnOrderUpdate()](onorderupdate.md)

- [OnExecutionUpdate()](onexecutionupdate.md)

- [EnterLongLimit()](enterlonglimit.md)

 
## Import instructions
1\.Download the file contained in this Help Guide topic to your PC desktop

2\.From the Control Center window, select the menu Tools \> Import \> NinjaScript

3\.Select the downloaded file

 
[SampleCancelOrder\_NT8\.zip](https://ninjatrader.com/support/helpGuides/nt8/samples/SampleCancelOrder_NT8.zip)
