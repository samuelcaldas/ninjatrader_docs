


NinjaScript \> Language Reference \> Common \> Bars \> GetLow()






















GetLow()







| \<\< [Click to Display Table of Contents](getlow.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Bars](bars-1.md) \> GetLow() | [Previous page](gethigh-1.md) [Return to chapter overview](bars-1.md) [Next page](getopen-1.md) |
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









