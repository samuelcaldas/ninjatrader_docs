



TestPeriod

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](testperiod.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Strategy](strategy.htm) >  TestPeriod | [Previous page](shorttrades.htm) [Return to chapter overview](strategy.htm) [Next page](timeinforce.htm) |

Definition
----------

Reserved for [Walk-Forward Optimization](walk_forward_optimize_a_strate.htm), this property determines the number of days used for the "out of sample" backtest period for a given strategy.  See also [OptimizationPeriod](optimizationperiod.htm).

|  |
| --- |
| Note:  This property should ONLY be called from the [OnStateChange()](onstatechange.htm) method during State.SetDefaults |

Property Value
--------------

An int value representing the number of "out of sample" days used for walk-forward optimization; Default value is set to 28

Syntax
------

TestPeriod

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()  {       if (State == State.SetDefaults)       {                    //set the default TestPeriod to 31 days for WFOs           TestPeriod = 31;       }  } |