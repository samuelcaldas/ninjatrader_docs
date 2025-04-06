



ArePlotsConfigurable

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](areplotsconfigurable.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Indicator](indicator.htm) > [AddPlot()](addplot.htm) >  ArePlotsConfigurable | [Previous page](addplot.htm) [Return to chapter overview](addplot.htm) [Next page](displacement.htm) |

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