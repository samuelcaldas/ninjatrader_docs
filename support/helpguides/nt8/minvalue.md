
NinjaScript > Language Reference > Common > Charts > Rendering > MinValue

MinValue

| << [Click to Display Table of Contents](minvalue.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Charts](chart.md) > [Rendering](rendering.md) > MinValue | [Previous page](maxvalue.md) [Return to chapter overview](rendering.md) [Next page](oncalculateminmax.md) |
| --- | --- |
## Definition
The minimum value used for the automatic scaling of the y axis.  This property will only be used when the chart object is set to [IsAutoScale](isautoscale.md)
## 
## Property Value
A double value
 
## Syntax
MinValue
 
## Examples

| ns |
| --- |
| public override void OnCalculateMinMax() {    if (DrawingState != DrawingState.Building)    {      //set the minimum value to the chart anchors price      MinValue = Anchor.Price;    } } |
