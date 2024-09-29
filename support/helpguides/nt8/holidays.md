


NinjaScript \> Language Reference \> Common \> TradingHours \> Holidays






















Holidays







| \<\< [Click to Display Table of Contents](holidays.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [TradingHours](tradinghours.md) \> Holidays | [Previous page](getprevioustradingdayend.md) [Return to chapter overview](tradinghours.md) [Next page](tradinghours_name.md) |
| --- | --- |











## Definition


A collection of full holidays configured for a Trading Hours template. Holidays are days which fall outside of the regular trading schedule.


 




| Note: For more information please see the "Understanding trading holidays" section of the [Using the Trading Hours](using_the_trading_hours_window.md) window. |
| --- |



 


 


## Property Value


A [Dictionary](https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.110).aspx) holding a collection of holiday Dates and Descriptions of each holiday.


 




| Date | A DateTime representing the date of the trading hours holiday |
| --- | --- |
| Description | A string which is used to describe the holiday (e.g., Christmas) |



 


## Syntax


TradingHours.Holidays


 


 


## Examples




| ns |
| --- |
| // Print all holidays included in the Bars object's Trading Hours template foreach(KeyValuePair\<DateTime, string\> holiday in TradingHours.Holidays) {    Print(holiday); } |









