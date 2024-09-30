
NinjaScript > Language Reference > Common > System Indicator Methods > Trend Lines
Trend Lines
| << [Click to Display Table of Contents](trend-lines.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [System Indicator Methods](indicators.md) > Trend Lines | [Previous page](time_series_forecast_tsf.md) [Return to chapter overview](indicators.md) [Next page](true_strength_index_tsi.md) |
| --- | --- |
## Description
When a high swing is followed by a lower high swing, a trend line high is automatically plotted. When a low swing is followed by a higher low swing, a trend line low is automatically plotted.
 
## Syntax
## 
TrendLines(int strength, int numberOfTrendLines, int oldTrendsOpacity, bool alertOnBreak)
TrendLines(ISeries<double> input, int strength, int numberOfTrendLines, int oldTrendsOpacity, bool alertOnBreak)
 
## Return Value
double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.
 
## Parameters
| input | Indicator source data ([?](valid_input_data_for_indicator.md)) |
| --- | --- |
| strength | The number of required bars to the left and right of the swing point |
| numberOfTrendLines | The number of recent trend lines to plot |
| oldTrendOpacity | The opacity to apply to old trend lines |
| alertOnBreak | Sets if there should be an alert when the price breaks the current trend line |

 
## 
## Examples
| ns |
| --- |
| // Prints the current value of a 5 strength Trend Lines double value = TrendLines(5, 4, 25, true)[0]; Print("The current Trend Lines value is " + value.ToString()); |
