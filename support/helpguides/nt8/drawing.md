
NinjaScript \> Language Reference \> Common \> Drawing

Drawing
| \<\< [Click to Display Table of Contents](drawing.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> Drawing | [Previous page](usercontrolcollection.md) [Return to chapter overview](common.md) [Next page](draw_andrewspitchfork.md) |
| --- | --- |
You can use NinjaScript to draw custom shapes, lines, text and colors on price and indicator panels from both [Indicators](indicator.md) and [Strategies](strategy.md). 
 
## Draw Methods and Associated Return Types
| Draw Method | Return Type |
| --- | --- |
| [Draw.AndrewsPitchfork()](draw_andrewspitchfork.md) | [AndrewsPitchfork](andrewspitchfork.md) |
| [Draw.Arc()](draw_arc.md) | [Arc](arc.md) |
| [Draw.ArrowDown()](draw_arrowdown.md) | [ArrowDown](arrowdown.md) |
| [Draw.ArrowLine()](draw_arrowline.md) | [ArrowLine](arrowline.md) |
| [Draw.ArrowUp()](draw_arrowup.md) | [ArrowUp](arrowup.md) |
| [Draw.Diamond()](draw_diamond.md) | [Diamond](diamond.md) |
| [Draw.Dot()](draw_dot.md) | [Dot](dot.md) |
| [Draw.Ellipse()](draw_ellipse.md) | [Ellipse](ellipse.md) |
| [Draw.ExtendedLine()](draw_extendedline.md) | [ExtendedLine](extendedline.md) |
| [Draw.FibonacciCircle()](draw_fibonaccicircle.md) | [FibonacciCircle](fibonaccicircle.md) |
| [Draw.FibonacciExtensions()](draw_fibonacciextensions.md) | [FibonacciExtensions](fibonacciextensions.md) |
| [Draw.FibonacciRetracements()](draw_fibonacciretracements.md) | [FibonacciRetracements](fibonacciretracements.md) |
| [Draw.FibonacciTimeExtensions()](draw_fibonaccitimeextensions.md) | [FibonacciTimeExtensions](fibonaccitimeextensions.md) |
| [Draw.GannFan()](draw_gannfan.md) | [GannFan](gannfan.md) |
| [Draw.HorizontalLine()](draw_horizontalline.md) | [HorizontalLine](horizontalline.md) |
| [Draw.Line()](draw_line.md) | [Line](line.md) |
| [Draw.Pathtool()](draw_pathtool.md) | [Pathtool](pathtool.md) |
| [Draw.Polygon()](draw_polygon.md) | [Polygon](polygon.md) |
| [Draw.Ray()](draw_ray.md) | [Ray](ray.md) |
| [Draw.Rectangle()](draw_rectangle.md) | [Rectangle](rectangle.md) |
| [Draw.Region()](draw_region.md) | [Region](region.md) |
| [Draw.RegionHighlightX()](draw_regionhighlightx.md) | [RegionHighlightX](regionhighlightx.md) |
| [Draw.RegionHighlightY()](draw_regionhighlighty.md) | [RegionHighlightY](regionhighlighty.md) |
| [Draw.RegressionChannel()](draw_regressionchannel.md) | [RegressionChannel](regressionchannel.md) |
| [Draw.RiskReward()](draw_riskreward.md) | [RiskReward](riskreward.md) |
| [Draw.Ruler()](draw_ruler.md) | [Ruler](ruler.md) |
| [Draw.Square()](draw_square.md) | [Square](square.md) |
| [Draw.Text()](draw_text.md) | [Text](text.md) |
| [Draw.TextFixed()](draw_textfixed.md) | [TextFixed](textfixed.md) |
| [Draw.TimeCycles()](draw_timecycles.md) | [TimeCycles](timecycles.md) |
| [Draw.TrendChannel()](draw_trendchannel.md) | [TrendChannel](trendchannel.md) |
| [Draw.Triangle()](draw_triangle.md) | [Triangle](triangle.md) |
| [Draw.TriangleDown()](draw_triangledown.md) | [TriangleDown](triangledown.md) |
| [Draw.TriangleUp()](draw_triangleup.md) | [TriangleUp](triangleup.md) |
| [Draw.VerticalLine()](draw_verticalline.md) | [VerticalLine](verticalline.md) |

Drawing Methods and Properties
| Property | Description |
| --- | --- |
| [AllowRemovalOfDrawObjects](allowremovalofdrawobjects.md) | Determines if programmatically drawn DrawObjects can be manually removed from the chart |
| [BackBrush](backbrush.md) | Sets the brush used for painting the chart panel's background color for the current bar |
| [BackBrushAll](backbrushall.md) | Sets the brush used for painting the chart's background color for the current bar |
| [BackBrushes](backbrushes.md) | A collection of historical brushes used for the background colors for the chart panel |
| [BackBrushesAll](backbrushesall.md) | A collection of historical brushes used for the background colors for all chart panels |
| [BarBrush](barbrush.md) | Sets the brush used for painting the color of a price bar's body |
| [BarBrushes](barbrushes.md) | A collection of historical brushes used for painting the color of a price bar's body |
| [Brushes](brushes.md) | A collection of static, predefined Brushes supplied by the .NET Framework |
| [CandleOutlineBrush](candleoutlinebrush.md) | Sets the outline Brush of a candlestick |
| [CandleOutlineBrushes](candleoutlinebrushes.md) | A collection of historical outline brushes for candlesticks |
| [DrawObjects](drawingtools_drawobjects.md) | A collection holding all of the drawn chart objects for the primary bar series |
| [IDrawingTool](idrawingtool.md) | Represents an interface that exposes information regarding a drawn chart object |
| [RemoveDrawObject()](removedrawobject.md) | Removes a draw object from the chart based on its tag value |
| [RemoveDrawObjects()](removedrawobjects.md) | Removes all draw objects originating from the indicator or strategy from the chart |
| [SimpleFont Class](simplefont_class.md) | Defines a particular font configuration |

| 1\.Custom graphics for custom indicators can be painted on either the price panel or indicator panel. You could for example have a custom indicator displayed in an indicator panel yet have associated custom graphics painted on the price panel. The "[DrawOnPricePanel](drawonpricepanel.md)" property is set to true by default, which means that custom graphics will always be painted on the price panel, even if the indicator is plotted in a separate panel. If you want your custom graphics to be plotted on the indicator panel, set this property to false in the OnStateChange() method of your custom indicator. 2\.Set unique tag values for each draw object, unless you intend for new draw objects to replace existing objects with the same tag. A common trick is to incorporate the bar number as part of the unique tag identifier. For example, if you wanted to draw a dot that indicated a buying condition above a bar, you could express it:   Draw.Dot(this, CurrentBar.ToString() \+ "Buy", false, 0, High\[0] \+ TickSize, Brushes.ForestGreen);   3\. Draw methods will not work if they are called from the OnStateChange() method. |
| --- |
