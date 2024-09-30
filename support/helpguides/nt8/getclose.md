
NinjaScript \> Language Reference \> Common \> Bars \> GetClose()
GetClose()
| \<\< [Click to Display Table of Contents](getclose.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Bars](bars.md) \> GetClose() | [Previous page](getbid.md) [Return to chapter overview](bars.md) [Next page](getdaybar.md) |
| --- | --- |
## Definition
Returns the closing price at the current bar index value.
 
## Method Return Value
A double value that represents the close price at the desired bar index.
## 
## Syntax
Bars.GetClose(int index)
 
## Parameters
| index | An int representing an absolute bar index value |
| --- | --- |

## Examples
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    base.OnRender(chartControl, chartScale);    // loop through only the rendered bars on the chart    for(int barIndex \= ChartBars.FromIndex; barIndex \<\= ChartBars.ToIndex; barIndex\+\+)    {      // get the close price at the selected bar index value      double closePrice \= Bars.GetClose(barIndex);      Print("Bar \#" \+ barIndex \+ " closing price is " \+ closePrice);    } } |

