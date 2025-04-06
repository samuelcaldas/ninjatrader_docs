



DaysToLoad

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\daystoload.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) >  DaysToLoad | [Previous page](connectionlosshandling-1.htm) [Return to chapter overview](strategy-1.htm) [Next page](defaultquantity-1.htm) |

Definition
----------

Determines the number of trading days which will be configured when loading the strategy from the Strategies Grid.

|  |
| --- |
| Notes:  1.This property does NOT affect a strategy configured of a Chart or the Strategy Analyzer.  2.A trading day is defined by a [Trading Hour](using_the_trading_hours_window-1.htm) template |

Property Value
--------------

An int value determining the number of trading days to load for historical data processing.  Default value is 5, but can be configured and overridden  from the UI.

Syntax
------

DaysToLoad

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()  {       if (State == State.SetDefaults)       {           DaysToLoad = 15;       }  } |