
NinjaScript > Language Reference > Bars Type > AddBar()
AddBar()
| << [Click to Display Table of Contents](addbar.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Bars Type](bars_type.md) > AddBar() | [Previous page](bars_type.md) [Return to chapter overview](bars_type.md) [Next page](applydefaultbaseperiodvalue.md) |
| --- | --- |
## Definition
Adds new data points for the Bars Type.
 
## Syntax
AddBar(Bars bars, double open, double high, double low, double close, DateTime time, long volume)
AddBar(Bars bars, double open, double high, double low, double close, DateTime time, long volume, double bid, double ask)
 
## Parameters
| bars | The Bars object of your bars type |
| --- | --- |
| open | A double value representing the open price |
| high | A double value representing the high price |
| low | A double value representing the low price |
| close | A double value representing the close price |
| time | A DateTime value representing the time |
| volume | A long value representing the volume |
| bid | A double value representing the bid price |
| ask | A double value representing the ask price |

## 
## Examples
| ns |
| --- |
| AddBar(bars, open, high, low, close, time, (long)Math.Min(volumeTmp, bars.BarsPeriod.Value)); |
