
NinjaScript > Language Reference > Common > Analytical > GetMedian()
GetMedian()
| << [Click to Display Table of Contents](getmedian.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Analytical](market_data-1.md) > GetMedian() | [Previous page](getcurrentbidvolume-1.md) [Return to chapter overview](market_data-1.md) [Next page](highestbar-1.md) |
| --- | --- |
## Definition
Returns the statistical median value of the specified series over the specified look-back period. This method sorts the values of the specified look back period in ascending order and return the middle value.  

 
| Notes:  1. This method should NOT be confused with [Median](median-1.md) prices defined as (High + Low) / 2. This method returns the statistical median of a series. 2. If an even number is passed as the look-back period, the average of the two middle values in the sorted values will be returned. |
| --- |

## Method Return Value
A double value representing the median value of the series.
 
## Syntax
GetMedian(ISeries<double> series, int lookBackPeriod)
 
## Parameters
| lookBackPeriod | Number of bars back to include in the calculation |
| --- | --- |
| series | Any Series<double> type object such as an indicator, Close, High, Low, etc... |
 
## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {       // Print the median price of the last 10 open prices     //(current open price + look back period's 9 open prices before that)    double openMedian = GetMedian(Open, 9);             Print("The median of the last 10 open prices is: " + openMedian);       } |

