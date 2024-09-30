
NinjaScript > Language Reference > Strategy > ChartIndicators
ChartIndicators
| << [Click to Display Table of Contents](chartindicators.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Strategy](strategy-1.md) > ChartIndicators | [Previous page](barssinceexitexecution-1.md) [Return to chapter overview](strategy-1.md) [Next page](closestrategy-1.md) |
| --- | --- |
## Definition
Contains a collection of Indicators which have been added to the strategy instance using [AddChartIndicator()](addchartindicator-1.md).
## 
## Property Value
An [Indicator](indicator-1.md) object
 
## Syntax
ChartIndicators[int index]
 
## 
## Examples
| ns |
| --- |
| if (State == State.DataLoaded) {    AddChartIndicator(SMA(20));        // Set the plots color for the added indicator     ChartIndicators[0].Plots[0].Brush = Brushes.Blue;        // Set the added indicator to panel 1 (specified index needs to be >= 1)    ChartIndicators[0].Panel = 1; } |
 

