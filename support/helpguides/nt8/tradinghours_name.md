


NinjaScript \> Language Reference \> Common \> TradingHours \> Name






















Name







| \<\< [Click to Display Table of Contents](tradinghours_name.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [TradingHours](tradinghours.md) \> Name | [Previous page](holidays.md) [Return to chapter overview](tradinghours.md) [Next page](partialholidays.md) |
| --- | --- |











## Definition


Indicates the name of the trading hours template applied to the Bars series object.  

 


## 


## Property Value


A string representing the name of the trading hours template.


 


## Syntax
Bars.TradingHours.Name


 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate()  {                      Print(TradingHours.Name);    //Output if applied to the ES with 'use instrument settings':  CME US Index Futures ETH } |









