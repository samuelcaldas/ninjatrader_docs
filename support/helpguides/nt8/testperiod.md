


NinjaScript \> Language Reference \> Strategy \> TestPeriod






















TestPeriod







| \<\< [Click to Display Table of Contents](testperiod.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> TestPeriod | [Previous page](shorttrades.md) [Return to chapter overview](strategy.md) [Next page](timeinforce.md) |
| --- | --- |











## Definition


Reserved for [Walk\-Forward Optimization](walk_forward_optimize_a_strate.md), this property determines the number of days used for the "out of sample" backtest period for a given strategy.  See also [OptimizationPeriod](optimizationperiod.md).


 




| Note:  This property should ONLY be called from the [OnStateChange()](onstatechange.md) method during State.SetDefaults |
| --- |



 


## Property Value


An int value representing the number of "out of sample" days used for walk\-forward optimization; Default value is set to 28


 


## Syntax


TestPeriod


 


## 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {                   //set the default TestPeriod to 31 days for WFOs          TestPeriod \= 31;      } } |









