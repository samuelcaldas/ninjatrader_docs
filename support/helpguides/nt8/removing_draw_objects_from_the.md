
NinjaScript \> Educational Resources \> Reference Samples \> Strategy \> Removing draw objects from the chart
Removing draw objects from the chart
| \<\< [Click to Display Table of Contents](removing_draw_objects_from_the.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Educational Resources](educational_resources.md) \> [Reference Samples](reference_samples.md) \> [Strategy](strategy2.md) \> Removing draw objects from the chart | [Previous page](plotting_from_within_a_ninjasc.md) [Return to chapter overview](strategy2.md) [Next page](resetting_values_at_the_beginn.md) |
| --- | --- |
Drawing objects can be used for a number of different purposes, like keeping track of where a strategy has its entry point, profit target, and stop loss. If a strategy draws an object(s) for every trade it takes, the chart could quickly become cluttered. This sample will show how to remove the objects that aren't necessary anymore.
 
| Note: This is a real\-time only strategy. Please view this strategy on a real\-time data connection or the Simulated Data Feed. |
| --- |

## 
## 
## Key concepts in this example
- Drawing lines at the price where the orders are that extend for the duration of the trade

- Removing those lines when the trade is over

 
## Important related documentation
- [Draw](drawing.md)

- [Line()](line.md)

- [RemoveDrawObject()](removedrawobject.md)

- [RemoveDrawObjects()](removedrawobjects.md)

- [CrossAbove()](crossabove.md)

- [CrossBelow()](crossbelow.md)

 
## Import instructions
1\.Download the file contained in this Help Guide topic to your PC desktop

2\.From the Control Center window, select the menu Tools \> Import \> NinjaScript

3\.Select the downloaded file

 
[SampleRemoveDrawObjects\_NT8\.zip](https://ninjatrader.com/support/helpGuides/nt8/samples/SampleRemoveDrawObjects_NT8.zip)
