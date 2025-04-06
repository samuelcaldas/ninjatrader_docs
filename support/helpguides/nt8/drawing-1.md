



Drawing

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\drawing.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) >  Drawing | [Previous page](usercontrolcollection-1.htm) [Return to chapter overview](common-1.htm) [Next page](draw_andrewspitchfork-1.htm) |

You can use NinjaScript to draw custom shapes, lines, text and colors on price and indicator panels from both [Indicators](indicator-1.htm) and [Strategies](strategy-1.htm).

Draw Methods and Associated Return Types
----------------------------------------

|  |  |
| --- | --- |
| Draw Method | Return Type |
| [Draw.AndrewsPitchfork()](draw_andrewspitchfork-1.htm) | [AndrewsPitchfork](andrewspitchfork-1.htm) |
| [Draw.Arc()](draw_arc-1.htm) | [Arc](arc-1.htm) |
| [Draw.ArrowDown()](draw_arrowdown-1.htm) | [ArrowDown](arrowdown-1.htm) |
| [Draw.ArrowLine()](draw_arrowline-1.htm) | [ArrowLine](arrowline-1.htm) |
| [Draw.ArrowUp()](draw_arrowup-1.htm) | [ArrowUp](arrowup-1.htm) |
| [Draw.Diamond()](draw_diamond-1.htm) | [Diamond](diamond-1.htm) |
| [Draw.Dot()](draw_dot-1.htm) | [Dot](dot-1.htm) |
| [Draw.Ellipse()](draw_ellipse-1.htm) | [Ellipse](ellipse-1.htm) |
| [Draw.ExtendedLine()](draw_extendedline-1.htm) | [ExtendedLine](extendedline-1.htm) |
| [Draw.FibonacciCircle()](draw_fibonaccicircle-1.htm) | [FibonacciCircle](fibonaccicircle-1.htm) |
| [Draw.FibonacciExtensions()](draw_fibonacciextensions-1.htm) | [FibonacciExtensions](fibonacciextensions-1.htm) |
| [Draw.FibonacciRetracements()](draw_fibonacciretracements-1.htm) | [FibonacciRetracements](fibonacciretracements-1.htm) |
| [Draw.FibonacciTimeExtensions()](draw_fibonaccitimeextensions-1.htm) | [FibonacciTimeExtensions](fibonaccitimeextensions-1.htm) |
| [Draw.GannFan()](draw_gannfan-1.htm) | [GannFan](gannfan-1.htm) |
| [Draw.HorizontalLine()](draw_horizontalline-1.htm) | [HorizontalLine](horizontalline-1.htm) |
| [Draw.Line()](draw_line-1.htm) | [Line](line-1.htm) |
| [Draw.Pathtool()](draw_pathtool.htm) | [Pathtool](pathtool-1.htm) |
| [Draw.Polygon()](draw_polygon-1.htm) | [Polygon](polygon-1.htm) |
| [Draw.Ray()](draw_ray-1.htm) | [Ray](ray-1.htm) |
| [Draw.Rectangle()](draw_rectangle-1.htm) | [Rectangle](rectangle-1.htm) |
| [Draw.Region()](draw_region-1.htm) | [Region](region-1.htm) |
| [Draw.RegionHighlightX()](draw_regionhighlightx-1.htm) | [RegionHighlightX](regionhighlightx-1.htm) |
| [Draw.RegionHighlightY()](draw_regionhighlighty-1.htm) | [RegionHighlightY](regionhighlighty-1.htm) |
| [Draw.RegressionChannel()](draw_regressionchannel-1.htm) | [RegressionChannel](regressionchannel-1.htm) |
| [Draw.RiskReward()](draw_riskreward-1.htm) | [RiskReward](riskreward-1.htm) |
| [Draw.Ruler()](draw_ruler-1.htm) | [Ruler](ruler-1.htm) |
| [Draw.Square()](draw_square-1.htm) | [Square](square-1.htm) |
| [Draw.Text()](draw_text-1.htm) | [Text](text-1.htm) |
| [Draw.TextFixed()](draw_textfixed-1.htm) | [TextFixed](textfixed-1.htm) |
| [Draw.TimeCycles()](draw_timecycles-1.htm) | [TimeCycles](timecycles-1.htm) |
| [Draw.TrendChannel()](draw_trendchannel-1.htm) | [TrendChannel](trendchannel-1.htm) |
| [Draw.Triangle()](draw_triangle-1.htm) | [Triangle](triangle-1.htm) |
| [Draw.TriangleDown()](draw_triangledown-1.htm) | [TriangleDown](triangledown-1.htm) |
| [Draw.TriangleUp()](draw_triangleup-1.htm) | [TriangleUp](triangleup-1.htm) |
| [Draw.VerticalLine()](draw_verticalline-1.htm) | [VerticalLine](verticalline-1.htm) |

Drawing Methods and Properties

|  |  |
| --- | --- |
| Property | Description |
| [AllowRemovalOfDrawObjects](allowremovalofdrawobjects-1.htm) | Determines if programmatically drawn DrawObjects can be manually removed from the chart |
| [BackBrush](backbrush-1.htm) | Sets the brush used for painting the chart panel's background color for the current bar |
| [BackBrushAll](backbrushall-1.htm) | Sets the brush used for painting the chart's background color for the current bar |
| [BackBrushes](backbrushes-1.htm) | A collection of historical brushes used for the background colors for the chart panel |
| [BackBrushesAll](backbrushesall-1.htm) | A collection of historical brushes used for the background colors for all chart panels |
| [BarBrush](barbrush-1.htm) | Sets the brush used for painting the color of a price bar's body |
| [BarBrushes](barbrushes-1.htm) | A collection of historical brushes used for painting the color of a price bar's body |
| [Brushes](brushes-1.htm) | A collection of static, predefined Brushes supplied by the .NET Framework |
| [CandleOutlineBrush](candleoutlinebrush-1.htm) | Sets the outline Brush of a candlestick |
| [CandleOutlineBrushes](candleoutlinebrushes-1.htm) | A collection of historical outline brushes for candlesticks |
| [DrawObjects](drawingtools_drawobjects-1.htm) | A collection holding all of the drawn chart objects for the primary bar series |
| [IDrawingTool](idrawingtool-1.htm) | Represents an interface that exposes information regarding a drawn chart object |
| [RemoveDrawObject()](removedrawobject-1.htm) | Removes a draw object from the chart based on its tag value |
| [RemoveDrawObjects()](removedrawobjects-1.htm) | Removes all draw objects originating from the indicator or strategy from the chart |
| [SimpleFont Class](simplefont_class-1.htm) | Defines a particular font configuration |

|  |
| --- |
| 1.Custom graphics for custom indicators can be painted on either the price panel or indicator panel. You could for example have a custom indicator displayed in an indicator panel yet have associated custom graphics painted on the price panel. The "[DrawOnPricePanel](drawonpricepanel-1.htm)" property is set to true by default, which means that custom graphics will always be painted on the price panel, even if the indicator is plotted in a separate panel. If you want your custom graphics to be plotted on the indicator panel, set this property to false in the OnStateChange() method of your custom indicator.  2.Set unique tag values for each draw object, unless you intend for new draw objects to replace existing objects with the same tag. A common trick is to incorporate the bar number as part of the unique tag identifier. For example, if you wanted to draw a dot that indicated a buying condition above a bar, you could express it:     Draw.Dot(this, CurrentBar.ToString() + "Buy", false, 0, High[0] + TickSize, Brushes.ForestGreen);     3. Draw methods will not work if they are called from the OnStateChange() method. |