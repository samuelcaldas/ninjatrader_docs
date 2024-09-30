
NinjaScript > Language Reference > Common > Analytical > IsRising()
IsRising()
| << [Click to Display Table of Contents](rising.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Analytical](market_data-1.md) > IsRising() | [Previous page](falling-1.md) [Return to chapter overview](market_data-1.md) [Next page](least_recent_occurence_lro-1.md) |
| --- | --- |
## Definition
Evaluates a rising condition which is true when the current value is greater than the value of 1 bar ago.
## 
## Method Return Value
This method returns true if a rising condition is present; otherwise, false.
## 
## Syntax
IsRising(ISeries<double> series)
## 
## Parameters
| series | Any Series<double> type object such as an indicator, Close, High, Low, etc... |
| --- | --- |

## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {    // If the 20 period SMA is rising (in uptrend) go long    if (IsRising(SMA(20)))        EnterLong(); } |

 
