
NinjaScript > Language Reference > Strategy > TestPeriod
TestPeriod
| << [Click to Display Table of Contents](testperiod.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Strategy](strategy-1.md) > TestPeriod | [Previous page](shorttrades-1.md) [Return to chapter overview](strategy-1.md) [Next page](timeinforce-1.md) |
| --- | --- |
## Definition
Reserved for [Walk-Forward Optimization](walk_forward_optimize_a_strate-1.md), this property determines the number of days used for the "out of sample" backtest period for a given strategy.  See also [OptimizationPeriod](optimizationperiod-1.md).
 
| Note:  This property should ONLY be called from the [OnStateChange()](onstatechange-1.md) method during State.SetDefaults |
| --- |

 
## Property Value
An int value representing the number of "out of sample" days used for walk-forward optimization; Default value is set to 28
 
## Syntax
TestPeriod
 
## 
## Examples
| ns |
| --- |
| protected override void OnStateChange() {      if (State == State.SetDefaults)      {                   //set the default TestPeriod to 31 days for WFOs          TestPeriod = 31;      } } |
