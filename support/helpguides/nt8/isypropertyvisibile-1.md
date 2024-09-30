
NinjaScript > Language Reference > Drawing Tool > ChartAnchor > IsYPropertyVisibile
IsYPropertyVisibile
| << [Click to Display Table of Contents](isypropertyvisibile.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Drawing Tool](drawing_tools-1.md) > [ChartAnchor](chartanchor-1.md) > IsYPropertyVisibile | [Previous page](isxpropertiesvisible-1.md) [Return to chapter overview](chartanchor-1.md) [Next page](moveanchor-1.md) |
| --- | --- |
## Definition
Indicates the anchor's Y properties are visible on the UI.  When set to true, the Y values can be viewed from the Drawing Objects properties.
 
## Property Value
A bool value which when true will display the anchor's Y (price) data values from the drawing object properties; otherwise false.  Default value is true.
 
## Syntax
# <ChartAnchor>.IsYPropertyVisibile
## 
## Examples
| ns |
| --- |
| protected override void OnStateChange() {      if (State == State.SetDefaults)      { MyAnchor = new ChartAnchor(); MyAnchor.IsYPropertyVisibile = true;      }      else if (State == State.Configure)      {        } } |
