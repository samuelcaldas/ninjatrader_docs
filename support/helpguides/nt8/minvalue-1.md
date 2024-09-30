
NinjaScript > Language Reference > Common > Charts > Rendering > MinValue

MinValue

| << [Click to Display Table of Contents](minvalue.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Charts](chart-1.md) > [Rendering](rendering-1.md) > MinValue | [Previous page](maxvalue-1.md) [Return to chapter overview](rendering-1.md) [Next page](oncalculateminmax-1.md) |
| --- | --- |
## Definition
The minimum value used for the automatic scaling of the y axis.  This property will only be used when the chart object is set to [IsAutoScale](isautoscale-1.md)
## 
## Property Value
A double value
 
## Syntax
MinValue
 
## Examples

| ns |
| --- |
| public override void OnCalculateMinMax() {    if (DrawingState != DrawingState.Building)    {      //set the minimum value to the chart anchors price      MinValue = Anchor.Price;    } } |
