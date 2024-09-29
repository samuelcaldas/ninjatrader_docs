


NinjaScript \> Language Reference \> Strategy \> OptimizationPeriod






















OptimizationPeriod







| \<\< [Click to Display Table of Contents](optimizationperiod.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> OptimizationPeriod | [Previous page](onpositionupdate-1.md) [Return to chapter overview](strategy-1.md) [Next page](order-1.md) |
| --- | --- |











## Definition


Reserved for [Walk\-Forward Optimization](walk_forward_optimize_a_strate-1.md), this property determines the number of days used for the "in sample" backtest period for a given strategy.  See also [TestPeriod](testperiod-1.md).


 




| Note:  This property should ONLY be called from the [OnStateChange()](onstatechange-1.md) method during State.SetDefaults |
| --- |



 


## Property Value


An int value representing the number of "in sample" days used for walk\-forward optimization; Default value is set to 10\.


 


## Syntax


OptimizationPeriod


 


## 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {                   //set the default optimization period to 20 days for WFOs          OptimizationPeriod \= 20;      } } |









