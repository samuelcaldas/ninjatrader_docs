



Values

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\performancemetric_values.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Performance Metrics](performance_metrics-1.htm) >  Values | [Previous page](performanceunit-1.htm) [Return to chapter overview](performance_metrics-1.htm) [Next page](share_service-1.htm) |

Definition
----------

The Values array holds an 5 values corresponding to each Cbi.PerformanceUnit. NinjaTrader will then access the Values property to display the calculated performance metric in the UI. You can also access these performance metrics for a NinjaScript strategy.

Syntax
------

public double[] Values

{ get; private set; }

Calculating Values OnAddTrade Example
-------------------------------------

| ns |
| --- |
| protected override void OnAddTrade(Cbi.Trade trade)  {          Values[(int)Cbi.PerformanceUnit.Currency] += trade.ProfitCurrency;           Values[(int)Cbi.PerformanceUnit.Percent]   = (1.0 + Values[(int)Cbi.PerformanceUnit.Percent]) \* (1.0 + trade.ProfitPercent) - 1;           Values[(int)Cbi.PerformanceUnit.Pips]     += trade.ProfitPips;           Values[(int)Cbi.PerformanceUnit.Points]   += trade.ProfitPoints;           Values[(int)Cbi.PerformanceUnit.Ticks]     += trade.ProfitTicks;  }     // The attribute determines the name of the performance value on the grid  [Display("MyPerformanceMetric", Order = 0)]  public double[] Values  { get; private set; } |

 

Calculating Values On Demand Example
------------------------------------

| ns |
| --- |
| // The attribute determines the name of the performance value on the grid  [Display("MyPerformanceMetric", Order = 0)]  public double[] Values  {    get    {       return /\*Your custom math here\*/    }       private set;  } |