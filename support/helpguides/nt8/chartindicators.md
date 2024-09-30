
NinjaScript > Language Reference > Strategy > ChartIndicators

ChartIndicators
| << [Click to Display Table of Contents](chartindicators.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > ChartIndicators | [Previous page](barssinceexitexecution.md) [Return to chapter overview](strategy.md) [Next page](closestrategy.md) |
| --- | --- |
## Definition
Contains a collection of Indicators which have been added to the strategy instance using [AddChartIndicator()](addchartindicator.md).
## 
## Property Value
An [Indicator](indicator.md) object
 
## Syntax
ChartIndicators[int index]
 
## 
## Examples
| ns |
| --- |
| if (State == State.DataLoaded) {    AddChartIndicator(SMA(20));        // Set the plots color for the added indicator     ChartIndicators[0].Plots[0].Brush = Brushes.Blue;        // Set the added indicator to panel 1 (specified index needs to be >= 1)    ChartIndicators[0].Panel = 1; } |

 
