
NinjaScript > Language Reference > Drawing Tool > ChartAnchor > DisplayName
DisplayName
| << [Click to Display Table of Contents](displayname.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Drawing Tool](drawing_tools-1.md) > [ChartAnchor](chartanchor-1.md) > DisplayName | [Previous page](copydatavalues-1.md) [Return to chapter overview](chartanchor-1.md) [Next page](drawingtool-1.md) |
| --- | --- |
## Definition
Sets the display name prefix used for all properties for a chart anchor. 
 
## Property Value
A string value that is used to identify the name for a corresponding anchor.  Default value is null.
 
## Syntax
# <ChartAnchor>.DisplayName
## 
## Examples
| ns |
| --- |
| protected override void OnStateChange() {    if (State == State.SetDefaults)    {                  MyAnchor = new ChartAnchor();        MyAnchor.DisplayName = "MyChartAnchor";    }    } |

