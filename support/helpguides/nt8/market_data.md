
NinjaScript > Language Reference > Common > Analytical

Analytical

| << [Click to Display Table of Contents](market_data.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > Analytical | [Previous page](share.md) [Return to chapter overview](common.md) [Next page](approxcompare.md) |
| --- | --- |
NinjaScript provides a number of methods and properties useful for analyzing and identifying specific conditions within [Series<T>](seriest.md) collections. Some of these methods test a condition and return true or false, while others return an int-based bar index or other numerical value. A list of analytical methods can be found below:
 
## Methods and Properties

| [CountIf()](countif.md) | Counts the number of occurrences of the test condition |
| --- | --- |
| [CrossAbove()](crossabove.md) | Evaluates a cross above condition |
| [CrossBelow()](crossbelow.md) | Evaluates a cross below condition |
| [GetCurrentAsk()](getcurrentask.md) | Returns the current Ask price |
| [GetCurrentAskVolume()](getcurrentaskvolume.md) | Returns the current Ask volume |
| [GetCurrentBid()](getcurrentbid.md) | Returns the current Bid price |
| [GetCurrentBidVolume()](getcurrentbidvolume.md) | Returns the current Bid volume |
| [GetMedian()](getmedian.md) | Returns the median value of the specified series |
| [HighestBar()](highestbar.md) | Returns the number of bars ago the highest price value occurred |
| [IsFalling()](falling.md) | Evaluates a falling condition |
| [IsRising()](rising.md) | Evaluates a rising condition |
| [Least Recent Occurrence (LRO)](least_recent_occurence_lro.md) | Returns the number of bars ago that the least recent occurrence of a test condition evaluated to true |
| [LowestBar()](lowestbar.md) | Returns the number of bars ago the lowest price value occurred |
| [Most Recent Occurrence (MRO)](most_recent_occurence_mro.md) | Returns the number of bars ago that the most recent occurrence of a  test condition evaluated to true |
| [Slope()](slope.md) | Returns a measurement of the steepness of a price series measured by the change over time |
| [TickSize](ticksize.md) | The value of 1 tick for the corresponding instrument |
| [ToDay()](today.md) | Calculates an integer value representing a date |
| [ToTime()](totime.md) | Calculates an integer value representing a time |
