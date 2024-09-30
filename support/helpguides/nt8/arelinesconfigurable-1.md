
NinjaScript \> Language Reference \> Indicator \> AddLine() \> AreLinesConfigurable
AreLinesConfigurable
| \<\< [Click to Display Table of Contents](arelinesconfigurable.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Indicator](indicator-1.md) \> [AddLine()](addline-1.md) \> AreLinesConfigurable | [Previous page](addline-1.md) [Return to chapter overview](addline-1.md) [Next page](line_class-1.md) |
| --- | --- |
## Definition
Determines if the [line](addline-1.md)(s) used in an indicator are configurable from within the indicator dialog window.
 
## 
## Property Value
A bool which true if any indicator line(s) are configurable; otherwise, false. Default set to true.
 
## Syntax
AreLinesConfigurable

## Examples
| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          AddLine(Brushes.Gray, 30, "Lower");          AreLinesConfigurable \= false; // Indicator lines are not configurable      } } |

