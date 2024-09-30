
BarsAgo
BarsAgo
| << [Click to Display Table of Contents](barsago.md) >> **Navigation:**   »No topics above this level«   BarsAgo | [Return to chapter overview](sharpdx_directwrite_textlayout-1.md) |
| --- | --- |
## Definition
Gets the number of bars back (x-axis coordinate) the chart anchor is drawn by a NinjaScript object.  This value is the direct value which was passed to a NinjaScript Draw method.  Please see the [Drawing](drawing-1.md) section for more information.
## 
| Note:  This value will NOT work on manually drawn objects.  This property is reserved for chart anchors which were drawn by another NinjaScript object (e.g, using a Draw method in an indicator).  For manually drawn objects, please see the [SlotIndex](barindex-1.md) property |
| --- |

## Property Value
A int value that value representing the barsAgo value used to drawn the anchor .  This property is read-only.
 
## Syntax
<ChartAnchor>.BarsAgo

