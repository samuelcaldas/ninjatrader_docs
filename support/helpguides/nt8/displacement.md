



Displacement

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](displacement.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Indicator](indicator.htm) > [AddPlot()](addplot.htm) >  Displacement | [Previous page](areplotsconfigurable.htm) [Return to chapter overview](addplot.htm) [Next page](plotbrushes.htm) |

Definition
----------

An offset value that shifts the visually displayed value of an indicator.

Property Value
--------------

An int value that represents the number of bars ago to offset with.

Syntax
------

Displacement

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()  {       if (State == State.SetDefaults)       {           Displacement = 2; // Plots the indicator value from 2 bars ago on the current bar                AddPlot(Brushes.Orange, "SMA");       }  } |