


NinjaScript \> Language Reference \> Chart Style \> BarWidth






















BarWidth







| \<\< [Click to Display Table of Contents](barwidth.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Chart Style](chart_style.md) \> BarWidth | [Previous page](chart_style.md) [Return to chapter overview](chart_style.md) [Next page](barwidthui.md) |
| --- | --- |











## Definition


The painted width of a ChartStyle bar.  This value will updated as the ChartControl is resized.


 


## Property Value


A double value representing the current width the chart bars


 


## Syntax


BarWidth


 


 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {    if (State \=\= State.SetDefaults)    {      Name             \= "Example ChartStyle";               ChartStyleType   \= (ChartStyleType) 52;      BarWidth         \= 1;    } } |









