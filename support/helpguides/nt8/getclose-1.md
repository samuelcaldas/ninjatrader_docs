


NinjaScript \> Language Reference \> Common \> Bars \> GetClose()






















GetClose()







| \<\< [Click to Display Table of Contents](getclose.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Bars](bars-1.md) \> GetClose() | [Previous page](getbid-1.md) [Return to chapter overview](bars-1.md) [Next page](getdaybar-1.md) |
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









