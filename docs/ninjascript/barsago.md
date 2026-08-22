# BarsAgo

Definition 
## Gets the number of bars back (x-axis coordinate) the chart anchor is drawn by a NinjaScript object.  This value is the direct value which was passed to a NinjaScript Draw method.  Please see the [Drawing](../language_reference/drawing.md) section for more information.

> **Note:** This value will NOT work on manually drawn objects.  This property is reserved for chart anchors which were drawn by another NinjaScript object (e.g, using a Draw method in an indicator).  For manually drawn objects, please see the [SlotIndex](../drawing_tools/barindex.md) property

## Property Value

A int value that value representing the barsAgo value used to drawn the anchor .  This property is read-only.

## Syntax

<ChartAnchor>.BarsAgo
