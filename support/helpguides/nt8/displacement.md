
NinjaScript \> Language Reference \> Indicator \> AddPlot() \> Displacement
Displacement
| \<\< [Click to Display Table of Contents](displacement.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Indicator](indicator.md) \> [AddPlot()](addplot.md) \> Displacement | [Previous page](areplotsconfigurable.md) [Return to chapter overview](addplot.md) [Next page](plotbrushes.md) |
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

