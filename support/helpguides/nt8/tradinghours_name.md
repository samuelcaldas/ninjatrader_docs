



Name

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](tradinghours_name.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [TradingHours](tradinghours.htm) >  Name | [Previous page](holidays.htm) [Return to chapter overview](tradinghours.htm) [Next page](partialholidays.htm) |

Definition
----------

Indicates the name of the trading hours template applied to the Bars series object.

Property Value
--------------

A string representing the name of the trading hours template.

Syntax 
Bars.TradingHours.Name
------------------------------

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()   {                       Print(TradingHours.Name);     //Output if applied to the ES with 'use instrument settings':  CME US Index Futures ETH  } |