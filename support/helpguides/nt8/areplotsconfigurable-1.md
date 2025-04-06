



ArePlotsConfigurable

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\areplotsconfigurable.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Indicator](indicator-1.htm) > [AddPlot()](addplot-1.htm) >  ArePlotsConfigurable | [Previous page](addplot-1.htm) [Return to chapter overview](addplot-1.htm) [Next page](displacement-1.htm) |

Definition
----------

Determines if the plot(s) used in an indicator are configurable within the indicator dialog window.

Property Value
--------------

A bool which returns true if any indicator plot(s) are configurable; otherwise, false. Default set to true.

Syntax
------

ArePlotsConfigurable

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()  {       if (State == State.SetDefaults)       {           AddPlot(Brushes.Orange, "SMA");           ArePlotsConfigurable = false; // Plots are not configurable in the indicator dialog       }  } |