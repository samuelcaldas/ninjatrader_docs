
NinjaScript \> Language Reference \> Common \> Charts \> ChartBars \> ToIndex

ToIndex
| \<\< [Click to Display Table of Contents](chartbars_toindex.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Charts](chart.md) \> [ChartBars](chartbars.md) \> ToIndex | [Previous page](chartbars_tochartstring().md) [Return to chapter overview](chartbars.md) [Next page](chartcontrol.md) |
| --- | --- |
## Definition
An index value representing the last bar rendered on the chart.  See also [FromIndex](chartbars_fromindex.md).
 
| Note:  This value is NOT the last value that exists on the [ChartBars](chartbars.md), but rather the last bar index that is within the viewable range of the chart canvas area.  This value changes as the user interacts with the [ChartControl](chartcontrol.md) time\-scale (x\-axis). |
| --- |

 
## 
## Property Value
An int representing the last bar index painted on the chart
 
## Syntax
ChartBars.ToIndex
## 
## Examples
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    if (ChartBars !\= null)    {      // loop through all of the viewable range of the chart      for (int barIndex \= ChartBars.FromIndex; barIndex \<\= ChartBars.ToIndex; barIndex\+\+)      {          // print the High value for each index within the viewable range          Print(High.GetValueAt(barIndex));      }    } } |
