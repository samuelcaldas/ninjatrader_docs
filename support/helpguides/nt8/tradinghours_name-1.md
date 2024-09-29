


NinjaScript \> Language Reference \> Common \> TradingHours \> Name






















Name







| \<\< [Click to Display Table of Contents](tradinghours_name.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [TradingHours](tradinghours-1.md) \> Name | [Previous page](holidays-1.md) [Return to chapter overview](tradinghours-1.md) [Next page](partialholidays-1.md) |
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









