
NinjaScript > Language Reference > Common > Charts > Rendering > MaxValue

MaxValue

| << [Click to Display Table of Contents](maxvalue.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Charts](chart.md) > [Rendering](rendering.md) > MaxValue | [Previous page](isvisibleonchart.md) [Return to chapter overview](rendering.md) [Next page](minvalue.md) |
| --- | --- |
## Definition
The maximum value used for the automatic scaling of the y axis.  This property will only be used when the chart object is set to [IsAutoScale](isautoscale.md)
## 
## Property Value
A double value
 
## Syntax
MaxValue
 
## Examples

| ns |
| --- |
| public override void OnCalculateMinMax() {    if (DrawingState != DrawingState.Building)    {      //set the maximum value to the chart anchors price      MaxValue = Anchor.Price;    } } |
