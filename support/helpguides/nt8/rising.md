
NinjaScript \> Language Reference \> Common \> Analytical \> IsRising()
IsRising()
| \<\< [Click to Display Table of Contents](rising.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Analytical](market_data.md) \> IsRising() | [Previous page](falling.md) [Return to chapter overview](market_data.md) [Next page](least_recent_occurence_lro.md) |
| --- | --- |
## Definition
Evaluates a rising condition which is true when the current value is greater than the value of 1 bar ago.
## 
## Method Return Value
This method returns true if a rising condition is present; otherwise, false.
## 
## Syntax
IsRising(ISeries\<double\> series)
## 
## Parameters
| series | Any Series\<double\> type object such as an indicator, Close, High, Low, etc... |
| --- | --- |

## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {    // If the 20 period SMA is rising (in uptrend) go long    if (IsRising(SMA(20)))        EnterLong(); } |

 
