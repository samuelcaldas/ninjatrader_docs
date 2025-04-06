



BarsSinceNewTradingDay

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](barssincenewtradingday.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [Bars](bars.htm) >  BarsSinceNewTradingDay | [Previous page](bars.htm) [Return to chapter overview](bars.htm) [Next page](getask.htm) |

Definition
----------

Returns the number of bars elapsed since the start of the trading day relative to the current bar processing.

 

Property Value
--------------

An int value representing the number of bars elapsed.  This property cannot be set.

Syntax 
Bars.BarsSinceNewTradingDay
-----------------------------------

Examples
--------

| ns |
| --- |
| // Only process strategy logic after five bars have posted since the start of the trading day  protected override void OnBarUpdate()  {     if (Bars.BarsSinceNewTradingDay >= 5)     {       //Strategy logic here     }  } |