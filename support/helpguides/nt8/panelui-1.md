


NinjaScript \> Language Reference \> Common \> Charts \> Rendering \> PanelUI






















PanelUI







| \<\< [Click to Display Table of Contents](panelui.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Charts](chart-1.md) \> [Rendering](rendering-1.md) \> PanelUI | [Previous page](onrendertargetchanged-1.md) [Return to chapter overview](rendering-1.md) [Next page](rendertarget-1.md) |
| --- | --- |











## Definition


The zero\-based index of the chart panel in which the calling script is configured. 


 




| Note: The "Panel" property configured in the Indicators or Strategies window on a chart is non\-zero\-based, while PanelUI is zero\-based. For example, if an indicator is configured in Panel \# 1 in the Indicators window, PanelUI will return an index of 0\. If the indicator were configured in Panel \# 4 in the Indicators window, PanelUI would return an index of 3\. |
| --- |



## 


## Property Value


An int value representing the panel the object is configured.  This property is read\-only.


 


## Syntax


PanelUI


## 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {    // Print the zero\-based panel index on which the script is configured    Print("My object is on is on panel \# " \+ PanelUI); } |









