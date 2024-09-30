
NinjaScript > Educational Resources > Reference Samples > Strategy > Using CancelOrder() method to cancel orders
Using CancelOrder() method to cancel orders

| << [Click to Display Table of Contents](using_cancelorder_method_to_ca.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Educational Resources](educational_resources-1.md) > [Reference Samples](reference_samples-1.md) > [Strategy](strategy2-1.md) > Using CancelOrder() method to cancel orders | [Previous page](using_a_time_filter_to_limit_t-1.md) [Return to chapter overview](strategy2-1.md) [Next page](using_multiple_entry_exit_sign-1.md) |
| --- | --- |

When using NinjaTrader's Enter() and Exit() methods, the default behavior is to automatically expire them at the end of a bar unless they are resubmitted to keep them alive. Sometimes you may want more flexibility in this behavior and wish to submit orders as live-until-cancelled. When orders are submitted as live-until-cancelled, the way to cancel them is by using the CancelOrder() method.
 
## Key concepts in this example
- Submitting live-until-cancelled entry orders

- Manually cancelling orders

## 
## Important related documentation
- [CancelOrder()](cancel-1.md)

- [Order](order-1.md)

- [OnOrderUpdate()](onorderupdate-1.md)

- [OnExecutionUpdate()](onexecutionupdate-1.md)

- [EnterLongLimit()](enterlonglimit-1.md)

 
## Import instructions
1.Download the file contained in this Help Guide topic to your PC desktop

2.From the Control Center window, select the menu Tools > Import > NinjaScript

3.Select the downloaded file

 
[SampleCancelOrder_NT8.zip](samples/SampleCancelOrder_NT8.zip)
