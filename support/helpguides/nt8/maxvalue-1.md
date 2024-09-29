


NinjaScript \> Language Reference \> Common \> Charts \> Rendering \> MaxValue






















MaxValue







| \<\< [Click to Display Table of Contents](maxvalue.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Charts](chart-1.md) \> [Rendering](rendering-1.md) \> MaxValue | [Previous page](isvisibleonchart-1.md) [Return to chapter overview](rendering-1.md) [Next page](minvalue-1.md) |
| --- | --- |











## Definition


The maximum value used for the automatic scaling of the y axis.  This property will only be used when the chart object is set to [IsAutoScale](isautoscale-1.md)


## 


## Property Value


A double value


 


## Syntax


MaxValue


 


## Examples




| ns |
| --- |
| public override void OnCalculateMinMax() {    if (DrawingState !\= DrawingState.Building)    {      //set the maximum value to the chart anchors price      MaxValue \= Anchor.Price;    } } |









