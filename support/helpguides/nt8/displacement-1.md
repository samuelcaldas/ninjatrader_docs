


NinjaScript \> Language Reference \> Indicator \> AddPlot() \> Displacement






















Displacement







| \<\< [Click to Display Table of Contents](displacement.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Indicator](indicator-1.md) \> [AddPlot()](addplot-1.md) \> Displacement | [Previous page](areplotsconfigurable-1.md) [Return to chapter overview](addplot-1.md) [Next page](plotbrushes-1.md) |
| --- | --- |











## Definition


An offset value that shifts the visually displayed value of an indicator.


 


## Property Value


An int value that represents the number of bars ago to offset with.


 


## Syntax


Displacement


## 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          Displacement \= 2; // Plots the indicator value from 2 bars ago on the current bar               AddPlot(Brushes.Orange, "SMA");      } } |









