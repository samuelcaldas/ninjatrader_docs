
NinjaScript \> Language Reference \> Common \> Bars \> GetLow()
GetLow()
| \<\< [Click to Display Table of Contents](getlow.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Bars](bars.md) \> GetLow() | [Previous page](gethigh.md) [Return to chapter overview](bars.md) [Next page](getopen.md) |
| --- | --- |
## Definition
Returns the low price at the selected bar index value.
 
## Method Return Value
A double value that represents the low price at the desired bar index.
## 
## Syntax
Bars.GetLow(int index)
 
## Parameters
| index | An int representing an absolute bar index value |
| --- | --- |

## Examples
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    base.OnRender(chartControl, chartScale);    // loop through only the rendered bars on the chart    for(int barIndex \= ChartBars.FromIndex; barIndex \<\= ChartBars.ToIndex; barIndex\+\+)    {      // get the low price at the selected bar index value      double lowPrice \= Bars.GetLow(barIndex);      Print("Bar \#" \+ barIndex \+ " low price is " \+ lowPrice);    } } |

