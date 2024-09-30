
NinjaScript \> Language Reference \> Indicator \> AddLine() \> AreLinesConfigurable
AreLinesConfigurable
| \<\< [Click to Display Table of Contents](arelinesconfigurable.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Indicator](indicator.md) \> [AddLine()](addline.md) \> AreLinesConfigurable | [Previous page](addline.md) [Return to chapter overview](addline.md) [Next page](line_class.md) |
| --- | --- |
## Definition
Determines if the [line](addline.md)(s) used in an indicator are configurable from within the indicator dialog window.
 
## 
## Property Value
A bool which true if any indicator line(s) are configurable; otherwise, false. Default set to true.
 
## Syntax
AreLinesConfigurable

## Examples
| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          AddLine(Brushes.Gray, 30, "Lower");          AreLinesConfigurable \= false; // Indicator lines are not configurable      } } |

