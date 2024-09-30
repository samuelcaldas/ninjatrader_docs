
NinjaScript > Language Reference > Common > OnBarUpdate() > Count
Count
| << [Click to Display Table of Contents](count.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [OnBarUpdate()](onbarupdate-1.md) > Count | [Previous page](calculate-1.md) [Return to chapter overview](onbarupdate-1.md) [Next page](currentbar-1.md) |
| --- | --- |
## Definition
The total number of bars or data points.
## 
## Property Value
An int value representing the the total number of bars.
 
## Syntax
Count
 
## 
## Examples
| ns |
| --- |
| //If there are less than 365 bars on the chart, text indicates how many bars are on the chart if (Count < 365) {  Draw.TextFixed(this, "tag1", "There are " + Count + " bars on the chart", TextPosition.BottomRight); } |
## 
 
| Tip: [CurrentBar](currentbar-1.md) value is guaranteed to be <= Count - 1. This is because of the NinjaTrader multi-threaded architecture, the Count value can have additional bars as inflight ticks come in to the system. |
| --- |

