


NinjaScript \> Language Reference \> Common \> TradingHours






















TradingHours







| \<\< [Click to Display Table of Contents](tradinghours.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> TradingHours | [Previous page](zigzag.md) [Return to chapter overview](common.md) [Next page](tradinghoursget.md) |
| --- | --- |











## Definition


Represents the Trading Hours information returned from the current bars series. The Trading Hours object contains several methods and properties for working with various trading sessions.


## 




| Warning: The properties in this class should NOT be accessed within the [OnStateChange()](onstatechange.md) method before the State has reached State.DataLoaded |
| --- |



 


 


## Methods and Properties




| [Get()](tradinghoursget.md) | Returns the Trading Hours object for the specified Trading Hours template name |
| --- | --- |
| [GetPreviousTradingDayEnd()](getprevioustradingdayend.md) | Returns the end date and time of the previous trading session relative to the time passed in the methods parameters. |
| [Holidays](holidays.md) | A collection of full holidays which are configured for a Trading Hours template |
| [Name](tradinghours_name.md) | Indicates the name of the trading hours template applied to the Bars series object. |
| [PartialHolidays](partialholidays.md) | A collection of partial holidays which are configured for a Trading Hours template |
| [Sessions](tradinghours_sessions.md) | A collection of session definitions of the trading hours template. |
| [TimeZoneInfo](timezoneinfo.md) | Indicates a time zone that is configured by a Trading Hour template |









