


NinjaScript \> Language Reference \> Common \> TradingHours \> PartialHolidays






















PartialHolidays







| \<\< [Click to Display Table of Contents](partialholidays.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [TradingHours](tradinghours-1.md) \> PartialHolidays | [Previous page](tradinghours_name-1.md) [Return to chapter overview](tradinghours-1.md) [Next page](tradinghours_sessions-1.md) |
| --- | --- |











## Definition


A collection of partial holidays which are configured for a Trading Hours template. Holidays are days which fall outside of the normal trading schedule, on which data will be excluded. For more information please see the "Understanding trading holidays" section of the [Using the Trading Hours](using_the_trading_hours_window-1.md) window.


 


## Property Value


A [Dictionary](https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.110).aspx) holding a collection of holiday Dates and PartialHoliday objects for each partial holiday.


 




| Date | A DateTime representing the trading date of the Trading Hours holiday |
| --- | --- |
| PartialHoliday | An object containing a DateTime representing the date of the early close or late begin, a description of the partial holiday, and two bool properties, IsEarlyClose and IsLateBegin |



 


## Syntax


TradingHours.PartialHolidays


 


 


## Examples




| ns |
| --- |
| // Print all partial holidays included in the Bars object's Trading Hours template foreach(KeyValuePair\<DateTime, PartialHoliday\> holiday in TradingHours.PartialHolidays) {    Print(holiday); } |









