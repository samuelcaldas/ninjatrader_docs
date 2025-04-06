



OnCopyTo()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](oncopyto.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Performance Metrics](performance_metrics.htm) >  OnCopyTo() | [Previous page](onaddtrade.htm) [Return to chapter overview](performance_metrics.htm) [Next page](onmergeperformancemetric.htm) |

Definition
----------

Called as the values of a trade metric are saved.

Syntax
------

protected override void OnCopyTo(PerformanceMetricBase target)  
{  
     
}

Examples
--------

| ns |
| --- |
| protected override void OnCopyTo(PerformanceMetricBase target)  {     // You need to cast, in order to access the right type     SampleCumProfit targetMetrics = (target as SampleCumProfit);        if (targetMetrics != null)       Array.Copy(Values, targetMetrics.Values, Values.Length);  } |