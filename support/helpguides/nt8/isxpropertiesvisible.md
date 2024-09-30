
NinjaScript \> Language Reference \> Drawing Tool \> ChartAnchor \> IsXPropertiesVisibile
IsXPropertiesVisible
| \<\< [Click to Display Table of Contents](isxpropertiesvisible.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Drawing Tool](drawing_tools.md) \> [ChartAnchor](chartanchor.md) \> IsXPropertiesVisible | [Previous page](isninjascriptdrawn.md) [Return to chapter overview](chartanchor.md) [Next page](isypropertyvisibile.md) |
| --- | --- |
## Definition
Indicates the anchor's X properties are visible on the UI.  When set to true, the X values can be viewed from the Drawing Objects properties.
 
## Property Value
A bool value which when true will display the anchor's X (time) data values from the drawing object properties; otherwise false.  Default value is true.
 
## Syntax
# \<ChartAnchor\>.IsXPropertiesVisibile
## 
## Examples
| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      { MyAnchor \= new ChartAnchor(); MyAnchor.IsXPropertiesVisible \= true;      }      else if (State \=\= State.Configure)      {        } } |
