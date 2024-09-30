
NinjaScript \> Language Reference \> Drawing Tool

Drawing Tools
| \<\< [Click to Display Table of Contents](drawing_tools.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> Drawing Tools | [Previous page](upbrushdx-1.md) [Return to chapter overview](language_reference_wip-1.md) [Next page](addpastedoffset-1.md) |
| --- | --- |
Custom Drawing Tools can be used to render custom shapes to a point on the chart to represent various information.  The methods and properties covered in this section are unique to custom Drawing Tools development. Following is an index of the documented properties and methods related to drawing tools.
 
## Methods and Properties
| [AddPastedOffset()](addpastedoffset-1.md) | A [virtual method](https://msdn.microsoft.com/en-us/library/9fkccyh4.aspx) which is called every time a Drawing Tool is copied and pasted to a chart |
| --- | --- |
| [Anchors](anchors-1.md) | Creates a collection of Chart Anchors which will represent various points of the drawing tool |
| [AttachedTo](attachedto-1.md) | An object which holds information regarding where the drawing tool is attached |
| [ChartAnchor](chartanchor-1.md) | Defines objects used by Drawing Tools which represent a point on the chart where the Drawing Tool is located |
| [ConvertToVerticalPixels](converttoverticalpixels-1.md) | Used to convert the cursor position (pixels) to device pixels represented on the Y axis of the chart |
| [CreateAnchor()](createanchor-1.md) | Used to create a new chart anchor at a specified mouse point |
| [DisplayOnChartsMenus](displayonchartsmenus-1.md) | Determines if the drawing tool should be listed in the chart's drawing tool menus |
| [Dispose()](dispose-1.md) | Releases any device resources used for the drawing tool |
| [DrawingState](drawingstate-1.md) | Represents the current state of the drawing tool in order to perform various actions, such as building, editing, or moving |
| [DrawnBy](drawnby-1.md) | Represents the NinjaScript object by which the drawing tool was created |
| [GetAttachedToChartBars()](getattachedtochartbars-1.md) | Returns information which relate to the underlying bars series in which the drawing tool is attached |
| [GetClosestAnchor()](getclosestanchor-1.md) | Returns the closest chart anchor within a specified maximum distance from the mouse cursor |
| [GetCursor()](getcursor-1.md) | An event driven method which is called when a chart object is selected |
| [GetSelectionPoints()](getselectionpoints-1.md) | Returns the chart object's data points where the user can interact |
| [Icon](icon_drawingtool-1.md) | The shape which displays next to the drawing tool menu item |
| [IgnoresSnapping](ignoressnapping-1.md) | Determines if the drawing tool chart anchor's will use the chart's Snap Mode mouse coordinates |
| [IgnoresUserInput](ignoresuserinput-1.md) | Determines if the drawing tool can be clicked on by the user |
| [IsAttachedToNinjaScript](isattachedtoninjascript-1.md) | Indicates if the drawing tool is currently [attached to](attachedto-1.md) a NinjaScript object (such an indicator or a strategy) |
| [IsGlobalDrawingTool](isglobaldrawingtool-1.md) | Indicates if the drawing tool is currently set as a Global Drawing object |
| [IsLocked](islocked-1.md) | Determines if the drawing tool should be be locked in place |
| [IsUserDrawn](isuserdrawn-1.md) | Indicates if the drawing tool was manually drawn by a user |
| [OnBarsChanged()](onbarschanged-1.md) | An event driven method which is called any time the underlying bar series have changed for the chart where the drawing tool resides |
| [OnMouseDown()](onmousedown-1.md) | An event driven method which is called any time the mouse pointer over the chart control has the mouse button pressed |
| [OnMouseMove()](onmousemove-1.md) | An event driven method which is called any time the mouse pointer is over the chart control and a mouse is moving |
| [OnMouseUp()](onmouseup-1.md) | An event driven method is called any time the mouse pointer is over the chart control and a mouse button is being released |
| [SupportsAlerts](supportsalerts-1.md) | Indicates if the drawing tool can be used for manually configured alerts through the UI |
| [ZOrderType](zordertype-1.md) | Determintes the order in which the drawing tool will be rendered |
