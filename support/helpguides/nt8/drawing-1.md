


NinjaScript \> Language Reference \> Common \> Drawing






















Drawing







| \<\< [Click to Display Table of Contents](drawing.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> Drawing | [Previous page](usercontrolcollection-1.md) [Return to chapter overview](common-1.md) [Next page](draw_andrewspitchfork-1.md) |
| --- | --- |











You can use NinjaScript to draw custom shapes, lines, text and colors on price and indicator panels from both [Indicators](indicator-1.md) and [Strategies](strategy-1.md). 


 


## Draw Methods and Associated Return Types




| Draw Method | Return Type |
| --- | --- |
| [Draw.AndrewsPitchfork()](draw_andrewspitchfork-1.md) | [AndrewsPitchfork](andrewspitchfork-1.md) |
| [Draw.Arc()](draw_arc-1.md) | [Arc](arc-1.md) |
| [Draw.ArrowDown()](draw_arrowdown-1.md) | [ArrowDown](arrowdown-1.md) |
| [Draw.ArrowLine()](draw_arrowline-1.md) | [ArrowLine](arrowline-1.md) |
| [Draw.ArrowUp()](draw_arrowup-1.md) | [ArrowUp](arrowup-1.md) |
| [Draw.Diamond()](draw_diamond-1.md) | [Diamond](diamond-1.md) |
| [Draw.Dot()](draw_dot-1.md) | [Dot](dot-1.md) |
| [Draw.Ellipse()](draw_ellipse-1.md) | [Ellipse](ellipse-1.md) |
| [Draw.ExtendedLine()](draw_extendedline-1.md) | [ExtendedLine](extendedline-1.md) |
| [Draw.FibonacciCircle()](draw_fibonaccicircle-1.md) | [FibonacciCircle](fibonaccicircle-1.md) |
| [Draw.FibonacciExtensions()](draw_fibonacciextensions-1.md) | [FibonacciExtensions](fibonacciextensions-1.md) |
| [Draw.FibonacciRetracements()](draw_fibonacciretracements-1.md) | [FibonacciRetracements](fibonacciretracements-1.md) |
| [Draw.FibonacciTimeExtensions()](draw_fibonaccitimeextensions-1.md) | [FibonacciTimeExtensions](fibonaccitimeextensions-1.md) |
| [Draw.GannFan()](draw_gannfan-1.md) | [GannFan](gannfan-1.md) |
| [Draw.HorizontalLine()](draw_horizontalline-1.md) | [HorizontalLine](horizontalline-1.md) |
| [Draw.Line()](draw_line-1.md) | [Line](line-1.md) |
| [Draw.Pathtool()](draw_pathtool.md) | [Pathtool](pathtool-1.md) |
| [Draw.Polygon()](draw_polygon-1.md) | [Polygon](polygon-1.md) |
| [Draw.Ray()](draw_ray-1.md) | [Ray](ray-1.md) |
| [Draw.Rectangle()](draw_rectangle-1.md) | [Rectangle](rectangle-1.md) |
| [Draw.Region()](draw_region-1.md) | [Region](region-1.md) |
| [Draw.RegionHighlightX()](draw_regionhighlightx-1.md) | [RegionHighlightX](regionhighlightx-1.md) |
| [Draw.RegionHighlightY()](draw_regionhighlighty-1.md) | [RegionHighlightY](regionhighlighty-1.md) |
| [Draw.RegressionChannel()](draw_regressionchannel-1.md) | [RegressionChannel](regressionchannel-1.md) |
| [Draw.RiskReward()](draw_riskreward-1.md) | [RiskReward](riskreward-1.md) |
| [Draw.Ruler()](draw_ruler-1.md) | [Ruler](ruler-1.md) |
| [Draw.Square()](draw_square-1.md) | [Square](square-1.md) |
| [Draw.Text()](draw_text-1.md) | [Text](text-1.md) |
| [Draw.TextFixed()](draw_textfixed-1.md) | [TextFixed](textfixed-1.md) |
| [Draw.TimeCycles()](draw_timecycles-1.md) | [TimeCycles](timecycles-1.md) |
| [Draw.TrendChannel()](draw_trendchannel-1.md) | [TrendChannel](trendchannel-1.md) |
| [Draw.Triangle()](draw_triangle-1.md) | [Triangle](triangle-1.md) |
| [Draw.TriangleDown()](draw_triangledown-1.md) | [TriangleDown](triangledown-1.md) |
| [Draw.TriangleUp()](draw_triangleup-1.md) | [TriangleUp](triangleup-1.md) |
| [Draw.VerticalLine()](draw_verticalline-1.md) | [VerticalLine](verticalline-1.md) |



 


 


Drawing Methods and Properties




| Property | Description |
| --- | --- |
| [AllowRemovalOfDrawObjects](allowremovalofdrawobjects-1.md) | Determines if programmatically drawn DrawObjects can be manually removed from the chart |
| [BackBrush](backbrush-1.md) | Sets the brush used for painting the chart panel's background color for the current bar |
| [BackBrushAll](backbrushall-1.md) | Sets the brush used for painting the chart's background color for the current bar |
| [BackBrushes](backbrushes-1.md) | A collection of historical brushes used for the background colors for the chart panel |
| [BackBrushesAll](backbrushesall-1.md) | A collection of historical brushes used for the background colors for all chart panels |
| [BarBrush](barbrush-1.md) | Sets the brush used for painting the color of a price bar's body |
| [BarBrushes](barbrushes-1.md) | A collection of historical brushes used for painting the color of a price bar's body |
| [Brushes](brushes-1.md) | A collection of static, predefined Brushes supplied by the .NET Framework |
| [CandleOutlineBrush](candleoutlinebrush-1.md) | Sets the outline Brush of a candlestick |
| [CandleOutlineBrushes](candleoutlinebrushes-1.md) | A collection of historical outline brushes for candlesticks |
| [DrawObjects](drawingtools_drawobjects-1.md) | A collection holding all of the drawn chart objects for the primary bar series |
| [IDrawingTool](idrawingtool-1.md) | Represents an interface that exposes information regarding a drawn chart object |
| [RemoveDrawObject()](removedrawobject-1.md) | Removes a draw object from the chart based on its tag value |
| [RemoveDrawObjects()](removedrawobjects-1.md) | Removes all draw objects originating from the indicator or strategy from the chart |
| [SimpleFont Class](simplefont_class-1.md) | Defines a particular font configuration |



 


 




| 1\.Custom graphics for custom indicators can be painted on either the price panel or indicator panel. You could for example have a custom indicator displayed in an indicator panel yet have associated custom graphics painted on the price panel. The "[DrawOnPricePanel](drawonpricepanel-1.md)" property is set to true by default, which means that custom graphics will always be painted on the price panel, even if the indicator is plotted in a separate panel. If you want your custom graphics to be plotted on the indicator panel, set this property to false in the OnStateChange() method of your custom indicator. 2\.Set unique tag values for each draw object, unless you intend for new draw objects to replace existing objects with the same tag. A common trick is to incorporate the bar number as part of the unique tag identifier. For example, if you wanted to draw a dot that indicated a buying condition above a bar, you could express it:   Draw.Dot(this, CurrentBar.ToString() \+ "Buy", false, 0, High\[0] \+ TickSize, Brushes.ForestGreen);   3\. Draw methods will not work if they are called from the OnStateChange() method. |
| --- |









