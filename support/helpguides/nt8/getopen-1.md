
NinjaScript \> Language Reference \> Common \> Bars \> GetOpen()
GetOpen()
| \<\< [Click to Display Table of Contents](getopen.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Bars](bars-1.md) \> GetOpen() | [Previous page](getlow-1.md) [Return to chapter overview](bars-1.md) [Next page](getsessionendtime-1.md) |
| --- | --- |
## Definition
Returns the open price at the selected bar index value.
 
## Method Return Value
A double value that represents the open price at the desired bar index.
## 
## Syntax
Bars.GetOpen(int index)
 
## Parameters
| index | An int representing an absolute bar index value |
| --- | --- |

## Examples
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    base.OnRender(chartControl, chartScale);    // loop through only the rendered bars on the chart    for(int barIndex \= ChartBars.FromIndex; barIndex \<\= ChartBars.ToIndex; barIndex\+\+)    {      // get the open price at the selected bar index value      double openPrice \= Bars.GetOpen(barIndex);      Print("Bar \#" \+ barIndex \+ " open price is " \+ openPrice);    } } |

