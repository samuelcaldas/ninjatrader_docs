
NinjaScript > Language Reference > Drawing Tool > ChartAnchor > IsYPropertyVisibile
IsYPropertyVisibile
| << [Click to Display Table of Contents](isypropertyvisibile.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Drawing Tool](drawing_tools.md) > [ChartAnchor](chartanchor.md) > IsYPropertyVisibile | [Previous page](isxpropertiesvisible.md) [Return to chapter overview](chartanchor.md) [Next page](moveanchor.md) |
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
