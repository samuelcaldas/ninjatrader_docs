



Removing draw objects from the chart

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](removing_draw_objects_from_the.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Educational Resources](educational_resources.htm) > [Reference Samples](reference_samples.htm) > [Strategy](strategy2.htm) >  Removing draw objects from the chart | [Previous page](plotting_from_within_a_ninjasc.htm) [Return to chapter overview](strategy2.htm) [Next page](resetting_values_at_the_beginn.htm) |

Drawing objects can be used for a number of different purposes, like keeping track of where a strategy has its entry point, profit target, and stop loss. If a strategy draws an object(s) for every trade it takes, the chart could quickly become cluttered. This sample will show how to remove the objects that aren't necessary anymore.

 

|  |
| --- |
| Note: This is a real-time only strategy. Please view this strategy on a real-time data connection or the Simulated Data Feed. |

Key concepts in this example
----------------------------

•Drawing lines at the price where the orders are that extend for the duration of the trade

•Removing those lines when the trade is over

Important related documentation
-------------------------------

•[Draw](drawing.htm)

•[Line()](line.htm)

•[RemoveDrawObject()](removedrawobject.htm)

•[RemoveDrawObjects()](removedrawobjects.htm)

•[CrossAbove()](crossabove.htm)

•[CrossBelow()](crossbelow.htm)

Import instructions
-------------------

1.Download the file contained in this Help Guide topic to your PC desktop

2.From the Control Center window, select the menu Tools > Import > NinjaScript

3.Select the downloaded file

[SampleRemoveDrawObjects\_NT8.zip](https://ninjatrader.com/support/helpGuides/nt8/samples/SampleRemoveDrawObjects_NT8.zip)