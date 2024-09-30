
NinjaScript \> Language Reference \> Strategy \> OptimizationPeriod
OptimizationPeriod
| \<\< [Click to Display Table of Contents](optimizationperiod.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> OptimizationPeriod | [Previous page](onpositionupdate.md) [Return to chapter overview](strategy.md) [Next page](order.md) |
| --- | --- |
## Definition
Reserved for [Walk\-Forward Optimization](walk_forward_optimize_a_strate.md), this property determines the number of days used for the "in sample" backtest period for a given strategy.  See also [TestPeriod](testperiod.md).
 
| Note:  This property should ONLY be called from the [OnStateChange()](onstatechange.md) method during State.SetDefaults |
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
