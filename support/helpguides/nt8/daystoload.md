
NinjaScript > Language Reference > Strategy > DaysToLoad
DaysToLoad
| << [Click to Display Table of Contents](daystoload.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > DaysToLoad | [Previous page](connectionlosshandling.md) [Return to chapter overview](strategy.md) [Next page](defaultquantity.md) |
| --- | --- |
## Definition
Determines the number of trading days which will be configured when loading the strategy from the Strategies Grid.
 
| Notes:   1.This property does NOT affect a strategy configured of a Chart or the Strategy Analyzer.2.A trading day is defined by a [Trading Hour](using_the_trading_hours_window.md) template |
| --- |
 
## Property Value
An int value determining the number of trading days to load for historical data processing.  Default value is 5, but can be configured and overridden  from the UI.
## 
## Syntax
DaysToLoad
## 
## Examples
| ns |
| --- |
| protected override void OnStateChange() {      if (State == State.SetDefaults)      {          DaysToLoad = 15;      } } |
 

