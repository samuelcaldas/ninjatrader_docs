



Name

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\tradinghours_name.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [TradingHours](tradinghours-1.htm) >  Name | [Previous page](holidays-1.htm) [Return to chapter overview](tradinghours-1.htm) [Next page](partialholidays-1.htm) |

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