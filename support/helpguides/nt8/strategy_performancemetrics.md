



PerformanceMetrics

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](strategy_performancemetrics.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Strategy](strategy.htm) >  PerformanceMetrics | [Previous page](orderfillresolutionvalue.htm) [Return to chapter overview](strategy.htm) [Next page](strategy_plots.htm) |

Definition
----------

Holds an array of [PerformanceMetrics](performancemetrics.htm) objects that represent custom metrics that can be used for strategy calcuations.

Index value is based on the the array of Bars objects added via the [AddPerformanceMetric](addperformancemetric.htm) method.

Property Value
--------------

An array of [PerformanceMetrics](performancemetrics.htm) objects.

Syntax 
PerformanceMetrics[int index]
-------------------------------------

Examples
--------

| ns |
| --- |
| // Define a new SampleCumProfit object  NinjaTrader.NinjaScript.PerformanceMetrics.SampleCumProfit myProfit;     protected override void OnStateChange()  {     if (State == State.Configure)     {       // Instantiate myProfit to a new instance of SampleCumProfit       myProfit = new NinjaTrader.NinjaScript.PerformanceMetrics.SampleCumProfit();               // Use AddPerformanceMetric to add myProfit to the strategy       AddPerformanceMetric(myProfit);     }  }     protected override void OnBarUpdate()  {     // Print a string representing the Type of the performance metric at Index 0 of the PerformanceMetrics collection     Print(PerformanceMetrics[0]);  } |