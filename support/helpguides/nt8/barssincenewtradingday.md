
NinjaScript > Language Reference > Common > Bars > BarsSinceNewTradingDay
BarsSinceNewTradingDay
| << [Click to Display Table of Contents](barssincenewtradingday.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Bars](bars.md) > BarsSinceNewTradingDay | [Previous page](bars.md) [Return to chapter overview](bars.md) [Next page](getask.md) |
| --- | --- |
## Definition
Returns the number of bars elapsed since the start of the trading day relative to the current bar processing.
 
## Property Value
An int value representing the number of bars elapsed.  This property cannot be set.
 
## Syntax
Bars.BarsSinceNewTradingDay
## 
## Examples
| ns |
| --- |
| // Only process strategy logic after five bars have posted since the start of the trading day protected override void OnBarUpdate() {    if (Bars.BarsSinceNewTradingDay >= 5)    {      //Strategy logic here    } } |

