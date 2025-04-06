



ChartIndicators

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](chartindicators.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Strategy](strategy.htm) >  ChartIndicators | [Previous page](barssinceexitexecution.htm) [Return to chapter overview](strategy.htm) [Next page](closestrategy.htm) |

Definition
----------

Contains a collection of Indicators which have been added to the strategy instance using [AddChartIndicator()](addchartindicator.htm).

Property Value
--------------

An [Indicator](indicator.htm) object

Syntax 
ChartIndicators[int index]
----------------------------------

Examples
--------

| ns |
| --- |
| if (State == State.DataLoaded)  {     AddChartIndicator(SMA(20));          // Set the plots color for the added indicator      ChartIndicators[0].Plots[0].Brush = Brushes.Blue;          // Set the added indicator to panel 1 (specified index needs to be >= 1)     ChartIndicators[0].Panel = 1;  } |