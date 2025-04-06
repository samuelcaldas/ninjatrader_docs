



AreLinesConfigurable

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\arelinesconfigurable.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Indicator](indicator-1.htm) > [AddLine()](addline-1.htm) >  AreLinesConfigurable | [Previous page](addline-1.htm) [Return to chapter overview](addline-1.htm) [Next page](line_class-1.htm) |

Definition
----------

Determines if the [line](addline-1.htm)(s) used in an indicator are configurable from within the indicator dialog window.

Property Value
--------------

A bool which true if any indicator line(s) are configurable; otherwise, false. Default set to true.

Syntax
------

AreLinesConfigurable

 

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()  {       if (State == State.SetDefaults)       {           AddLine(Brushes.Gray, 30, "Lower");           AreLinesConfigurable = false; // Indicator lines are not configurable       }  } |