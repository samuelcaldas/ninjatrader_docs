


NinjaScript \> Language Reference \> Drawing Tool \> ChartAnchor \> DisplayName






















DisplayName







| \<\< [Click to Display Table of Contents](displayname.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Drawing Tool](drawing_tools.md) \> [ChartAnchor](chartanchor.md) \> DisplayName | [Previous page](copydatavalues.md) [Return to chapter overview](chartanchor.md) [Next page](drawingtool.md) |
| --- | --- |











## Definition


Sets the display name prefix used for all properties for a chart anchor. 


 


## Property Value


A string value that is used to identify the name for a corresponding anchor.  Default value is null.


 


## Syntax


# \<ChartAnchor\>.DisplayName


## 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {    if (State \=\= State.SetDefaults)    {                  MyAnchor \= new ChartAnchor();        MyAnchor.DisplayName \= "MyChartAnchor";    }    } |









