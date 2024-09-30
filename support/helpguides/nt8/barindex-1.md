
NinjaScript > Language Reference > Drawing Tool > ChartAnchor > SlotIndex
SlotIndex
| << [Click to Display Table of Contents](barindex.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Drawing Tool](drawing_tools-1.md) > [ChartAnchor](chartanchor-1.md) > SlotIndex | [Previous page](price-1.md) [Return to chapter overview](chartanchor-1.md) [Next page](time-1.md) |
| --- | --- |
## Definition
Indicates the nearest bar slot value where anchor is drawn on a chart.  In a single series chart there will always be equal number of slots and bars, however for multi-series charts there may be additonal slots compared to the bar series your drawing tool resides.
 
## Property Value
An double value representing the current bar.  
 
| Note:  The bar index value is represented as a double as it is possible (and likely) that a given chart anchor is drawn between bars (i.e., if a user draws the tool with snap mode disabled) |
| --- |

## Syntax
ChartAnchor.SlotIndex
 
## Examples
| ns |
| --- |
| public override void OnMouseDown(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint) {    Print(MyAnchor.SlotIndex); // prints the nearest current bar value    //4502.02734375 } |

