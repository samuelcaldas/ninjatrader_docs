
NinjaScript > Language Reference > Drawing Tool > ChartAnchor > Price

Price

| << [Click to Display Table of Contents](price.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Drawing Tool](drawing_tools-1.md) > [ChartAnchor](chartanchor-1.md) > Price | [Previous page](moveanchory-1.md) [Return to chapter overview](chartanchor-1.md) [Next page](barindex-1.md) |
| --- | --- |
## Definition
Determines price value the chart anchor is drawn.
 
## Property Value
An double value representing a price value
 
## Syntax
<ChartAnchor>.Price
 
## Examples

| ns |
| --- |
| public override void OnMouseDown(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, Point point) {    Print(MyAnchor.Price); // prints the Y axis data point of the chart anchor     // 1999.25 } |
