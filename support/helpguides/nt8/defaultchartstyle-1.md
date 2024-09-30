
NinjaScript > Language Reference > Bars Type > DefaultChartStyle
DefaultChartStyle
| << [Click to Display Table of Contents](defaultchartstyle.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Bars Type](bars_type-1.md) > DefaultChartStyle | [Previous page](builtfrom-1.md) [Return to chapter overview](bars_type-1.md) [Next page](getinitiallookbackdays-1.md) |
| --- | --- |
## Definition
Allows to set a default ChartStyle for usage with a NinjaTrader bars type
 
## Property Value
A ChartStyleTypeÂenum value representing the [ChartStyle](chartstyletype-1.md) to be set as default. System defaults include:
 
- ChartStyleType.Box,

- ChartStyleType.CandleStick,

- ChartStyleType.LineOnClose,

- ChartStyleType.OHLC,

- ChartStyleType.PointAndFigure,

- ChartStyleType.KagiLine,

- ChartStyleType.OpenClose,

- ChartStyleType.Mountain

 
## Syntax
DefaultChartStyle
 
## Examples
| ns |
| --- |
| protected override void OnStateChange() {         if (State == State.SetDefaults)        {            Name                       = "SampleBarsType";            BarsPeriod                 = new BarsPeriod { BarsPeriodType = (BarsPeriodType) 15, BarsPeriodTypeName = "SampleBarsType(15)", Value = 1 };            BuiltFrom                 = BarsPeriodType.Minute;            DaysToLoad                 = 5;            DefaultChartStyle         = Gui.Chart.ChartStyleType.CandleStick;            IsIntraday                 = true;          } } |

