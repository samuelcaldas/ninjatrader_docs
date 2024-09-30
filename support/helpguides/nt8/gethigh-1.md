
NinjaScript > Language Reference > Common > Bars > GetHigh()
GetHigh()
| << [Click to Display Table of Contents](gethigh.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Bars](bars-1.md) > GetHigh() | [Previous page](getdaybar-1.md) [Return to chapter overview](bars-1.md) [Next page](getlow-1.md) |
| --- | --- |
## Definition
Returns the high price at the selected bar index value.
 
## Method Return Value
A double value that represents the high price at the desired bar index.
## 
## Syntax
Bars.GetHigh(int index)
 
## Parameters
| index | An int representing an absolute bar index value |
| --- | --- |

## Examples
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    base.OnRender(chartControl, chartScale);    // loop through only the rendered bars on the chart    for(int barIndex = ChartBars.FromIndex; barIndex <= ChartBars.ToIndex; barIndex++)    {      // get the high price at the selected bar index value      double highPrice = Bars.GetHigh(barIndex);      Print("Bar #" + barIndex + " high price is " + highPrice);    } } |

