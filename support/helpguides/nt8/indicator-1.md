



Indicator

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\indicator.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) >  Indicator | [Previous page](onnextdatapoint-1.htm) [Return to chapter overview](language_reference_wip-1.htm) [Next page](addline-1.htm) |

The methods and properties covered in this section are unique to custom indicator development.  Indicator configuration properties globally define various behaviors of indicators. All properties have default values and can be overridden by setting them in the [OnStateChange()](onstatechange-1.htm) method of the indicator.

|  |
| --- |
| Tip:  See also the "[Common](common-1.htm)" section for more method and properties which are shared by NinjaScript types |

Methods and Properties
----------------------

|  |  |
| --- | --- |
| [AddLine()](addline-1.htm) | Adds line objects on a chart. |
| [AddPlot()](addplot-1.htm) | Adds plot objects that define how an indicator or strategy data series render on a chart. |
| [BarsRequiredToPlot](barsrequiredtoplot-1.htm) | The number of bars on a chart required before the script plots. |
| [DisplayInDataBox](displayindatabox-1.htm) | Determines if plot(s) display in the chart data box. |
| [DrawHorizontalGridLines](drawhorizontalgridlines-1.htm) | Plots horizontal grid lines on the indicator panel. |
| [DrawOnPricePanel](drawonpricepanel-1.htm) | Determines the chart panel the draw objects renders. |
| [DrawVerticalGridLines](drawverticalgridlines-1.htm) | Plots vertical grid lines on the indicator panel. |
| [IndicatorBaseConverter](indicatorbaseconverter-1.htm) | A custom TypeConverter class handling the designed behavior of an indicator's property descriptor collection. |
| [IsChartOnly](ischartonly-1.htm) | If true, any indicator will be only available for charting usage - indicators with this property enabled would for example not be expected to show if called in a SuperDOM or MarketAnalyzer window. |
| [IsSuspendedWhileInactive](issuspendedwhileinactive-1.htm) | Prevents real-time market data events from being raised while the indicator's hosting feature is in a state that would be considered suspended and not in immediate use by a user. |
| [PaintPriceMarkers](paintpricemarkers-1.htm) | If true, any indicator plot values display price markers in the y-axis. |
| [ShowTransparentPlotsInDataBox](showtransparentplotsindatabox-1.htm) | Determines if plot(s) values which are set to a Transparent brush display in the chart data box. |