
NinjaScript > Language Reference > Drawing Tool > ChartAnchor

ChartAnchor
| << [Click to Display Table of Contents](chartanchor.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Drawing Tool](drawing_tools-1.md) > ChartAnchor | [Previous page](attachedto-1.md) [Return to chapter overview](drawing_tools-1.md) [Next page](copydatavalues-1.md) |
| --- | --- |
## Definition
Defines objects used by Drawing Tools which represent a point on the chart where the Drawing Tool is located.
 
## Syntax
class ChartAnchor
 
## Constructors
| new ChartAnchor() | Initializes a new instance of the ChartAnchor object |
| --- | --- |
| new ChartAnchor(DateTime time, double price, [ChartControl](chartcontrol-1.md) chartControl) | Initializes a new instance of the ChartAnchor object using time, price, and relative chart control |
| new ChartAnchor(DateTime time, double yValue, int currentBar, [ChartControl](chartcontrol-1.md) chartControl) | Initializes a new instance of the ChartAnchor object using time, y-axis coordinates, current bar, and relative chart control |

 
## Methods and Properties
| [CopyDataValues()](copydatavalues-1.md) | Copies the ChartAnchor time and price values from on anchor to another |
| --- | --- |
| [DisplayName](displayname-1.md) | A string value which sets the name prefix used for all properties for a chart anchor |
| [DrawingTool](drawingtool-1.md) | The drawing tool which owns a chart anchor |
| [DrawnOnBar](drawnonbar-1.md) | Gets the current bar value that the chart anchor is drawn by a NinjaScript object. |
| [GetPoint()](getpoint-1.md) | Returns a chart anchor's data points. |
| [IsBrowsable](isbrowsable-1.md) | A bool value determining the anchor is visible on the UI. |
| [IsEditing](isediting-1.md) | A bool value determining the anchor is currently being edited |
| [IsNinjaScriptDrawn](isninjascriptdrawn-1.md) | Indicates if the chart anchor was drawn by a NinjaScript object |
| [IsXPropertiesVisible](isypropertyvisibile-1.md) | A bool value determining the X properties are visible on the UI |
| [IsYPropertyVisible](isypropertyvisibile-1.md) | A bool value determining the Y data value is visible on the UI |
| [MoveAnchor()](moveanchor-1.md) | Moves a Chart Anchor's x and y values from start point by a delta point amount. |
| [MoveAnchorX()](moveanchorx-1.md) | Moves an anchor x values from start point by a delta point amount |
| [MoveAnchorY()](moveanchory-1.md) | Moves an anchor y values from start point by a delta point amount |
| [Price](price-1.md) | Determines price value the chart anchor is drawn. |
| [SlotIndex](barindex-1.md) | Indicates the nearest bar slot where anchor is drawn. |
| [Time](time-1.md) | Determines date/time value the chart anchor is drawn. |
| [UpdateFromPoint()](updatefrompoint-1.md) | Updates an anchor's x and y values from a given point (in device pixels) |
| [UpdateXFromPoint()](updatexfrompoint-1.md) | Updates an anchor's X values from a given point (in device pixels) |
| [UpdateYFromPoint()](updateyfrompoint-1.md) | Updates an anchor's Y value from a given point (in device pixels) |

## 
## 
## Examples
| ns |
| --- |
| public ChartAnchor MyAnchor { get; set; }   // declares the "MyAnchor" ChartAnchor object   public override IEnumerable<ChartAnchor> Anchors { get { return new[] { MyAnchor }; } } //adds the "MyAnchor" ChartAnchor object to a collection of anchors used to interact with your anchors   protected override void OnStateChange() {    if (State == State.SetDefaults)    {      Description = @"Drawing tool example";      Name = "SampleDrawingTool";        MyAnchor = new ChartAnchor(); //creates a new instances of the ChartAnchor object      MyAnchor.IsEditing   = true;      MyAnchor.DrawingTool = this;      MyAnchor.IsBrowsable = false;    } }   public override void OnMouseUp(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint) {    if (DrawingState == DrawingState.Editing)    {      if (MyAnchor.IsEditing)      {          //if anchor is editing, update anchor point          dataPoint.CopyDataValues(MyAnchor);      }    } } |
