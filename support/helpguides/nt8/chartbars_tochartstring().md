
NinjaScript \> Language Reference \> Common \> Charts \> ChartBars \> ToChartString()

ToChartString()
| \<\< [Click to Display Table of Contents](chartbars_tochartstring().md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Charts](chart.md) \> [ChartBars](chartbars.md) \> ToChartString() | [Previous page](chartbars_properties.md) [Return to chapter overview](chartbars.md) [Next page](chartbars_toindex.md) |
| --- | --- |
## Definition
Returns a formatted string representing the [ChartBars.Properties.Label](chartbars_properties.md) property, [BarsPeriod](barsperiod.md) Value, and BarsPeriodType name.
 
| Note:  The property returned is dependent on a user configured [Data Series](working_with_price_data.md) property, and results may return differently than expected.  See also [Bars.ToChartString()](tochartstring.md) for a return value which is not subject to user\-defined variables. |
| --- |

## Syntax
ChartBars.ToChartString()
 
## Return Value
A string value that represents the ChartBars label and configured bars period
 
## Parameters
This method does not accept any parameters
## 
## Examples
| ns |
| --- |
| protected override void OnRender(ChartControl chartControl, ChartScale chartScale) {    if (ChartBars !\= null)      Print(ChartBars.ToChartString()); // My Favorite Instrument (1 Minute) } |
