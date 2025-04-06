



AddChartIndicator()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\addchartindicator.md) >>  **Navigation:**  [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Strategy](strategy-1.md) >  AddChartIndicator() | [Previous page](strategy_account-1.md) [Return to chapter overview](strategy-1.md) [Next page](addperformancemetric-1.md) |

Definition
----------

Adds an indicator to the strategy only for the purpose of displaying it on a chart.

|  |
| --- |
| Notes:  AddChartIndicator(). |

Method Return Value
-------------------

This method does not return a value.

Syntax 
AddChartIndicator(IndicatorBaseindicator)
-------------------------------------------------

|  |
| --- |
| State.DataLoaded |

Parameters
----------

|  |  |
| --- | --- |
| indicator | An indicator object |

Examples
--------

|  |
| --- |
| OnStateChange()  {  State.DataLoaded)  {  // Charts a 20 period simple moving average to the chart  ));  }  } |

 

 

|  |
| --- |
| State.RealTime for performance optimizations. |

 

 

|  |
| --- |
| OnStateChange()  {  State.DataLoaded)  {  // Charts a 20 period simple moving average to the chart  ));  }  }     OnBarUpdate()  {     // call SMA() historically to ensure the indicator processes its historical states as well  ];  } |