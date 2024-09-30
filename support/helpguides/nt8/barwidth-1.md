
NinjaScript \> Language Reference \> Chart Style \> BarWidth

BarWidth
| \<\< [Click to Display Table of Contents](barwidth.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Chart Style](chart_style-1.md) \> BarWidth | [Previous page](chart_style-1.md) [Return to chapter overview](chart_style-1.md) [Next page](barwidthui-1.md) |
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
