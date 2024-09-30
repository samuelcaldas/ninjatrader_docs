
NinjaScript \> Language Reference \> Drawing Tool \> ChartAnchor

ChartAnchor
| \<\< [Click to Display Table of Contents](chartanchor.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Drawing Tool](drawing_tools.md) \> ChartAnchor | [Previous page](attachedto.md) [Return to chapter overview](drawing_tools.md) [Next page](copydatavalues.md) |
| --- | --- |
## Definition
Defines objects used by Drawing Tools which represent a point on the chart where the Drawing Tool is located.
 
## Syntax
class ChartAnchor
 
## Constructors
| new ChartAnchor() | Initializes a new instance of the ChartAnchor object |
| --- | --- |
| new ChartAnchor(DateTime time, double price, [ChartControl](chartcontrol.md) chartControl) | Initializes a new instance of the ChartAnchor object using time, price, and relative chart control |
| new ChartAnchor(DateTime time, double yValue, int currentBar, [ChartControl](chartcontrol.md) chartControl) | Initializes a new instance of the ChartAnchor object using time, y\-axis coordinates, current bar, and relative chart control |

 
## Methods and Properties
| [CopyDataValues()](copydatavalues.md) | Copies the ChartAnchor time and price values from on anchor to another |
| --- | --- |
| [DisplayName](displayname.md) | A string value which sets the name prefix used for all properties for a chart anchor |
| [DrawingTool](drawingtool.md) | The drawing tool which owns a chart anchor |
| [DrawnOnBar](drawnonbar.md) | Gets the current bar value that the chart anchor is drawn by a NinjaScript object. |
| [GetPoint()](getpoint.md) | Returns a chart anchor's data points. |
| [IsBrowsable](isbrowsable.md) | A bool value determining the anchor is visible on the UI. |
| [IsEditing](isediting.md) | A bool value determining the anchor is currently being edited |
| [IsNinjaScriptDrawn](isninjascriptdrawn.md) | Indicates if the chart anchor was drawn by a NinjaScript object |
| [IsXPropertiesVisible](isypropertyvisibile.md) | A bool value determining the X properties are visible on the UI |
| [IsYPropertyVisible](isypropertyvisibile.md) | A bool value determining the Y data value is visible on the UI |
| [MoveAnchor()](moveanchor.md) | Moves a Chart Anchor's x and y values from start point by a delta point amount. |
| [MoveAnchorX()](moveanchorx.md) | Moves an anchor x values from start point by a delta point amount |
| [MoveAnchorY()](moveanchory.md) | Moves an anchor y values from start point by a delta point amount |
| [Price](price.md) | Determines price value the chart anchor is drawn. |
| [SlotIndex](barindex.md) | Indicates the nearest bar slot where anchor is drawn. |
| [Time](time.md) | Determines date/time value the chart anchor is drawn. |
| [UpdateFromPoint()](updatefrompoint.md) | Updates an anchor's x and y values from a given point (in device pixels) |
| [UpdateXFromPoint()](updatexfrompoint.md) | Updates an anchor's X values from a given point (in device pixels) |
| [UpdateYFromPoint()](updateyfrompoint.md) | Updates an anchor's Y value from a given point (in device pixels) |

## 
## 
## Examples
| ns |
| --- |
| public ChartAnchor MyAnchor { get; set; }   // declares the "MyAnchor" ChartAnchor object   public override IEnumerable\<ChartAnchor\> Anchors { get { return new\[] { MyAnchor }; } } //adds the "MyAnchor" ChartAnchor object to a collection of anchors used to interact with your anchors   protected override void OnStateChange() {    if (State \=\= State.SetDefaults)    {      Description \= @"Drawing tool example";      Name \= "SampleDrawingTool";        MyAnchor \= new ChartAnchor(); //creates a new instances of the ChartAnchor object      MyAnchor.IsEditing   \= true;      MyAnchor.DrawingTool \= this;      MyAnchor.IsBrowsable \= false;    } }   public override void OnMouseUp(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint) {    if (DrawingState \=\= DrawingState.Editing)    {      if (MyAnchor.IsEditing)      {          //if anchor is editing, update anchor point          dataPoint.CopyDataValues(MyAnchor);      }    } } |
