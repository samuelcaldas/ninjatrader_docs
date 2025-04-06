



TradingHours

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\tradinghours.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) >  TradingHours | [Previous page](zigzag-1.htm) [Return to chapter overview](common-1.htm) [Next page](tradinghoursget-1.htm) |

Definition
----------

Represents the Trading Hours information returned from the current bars series. The Trading Hours object contains several methods and properties for working with various trading sessions.

|  |
| --- |
| Warning: The properties in this class should NOT be accessed within the [OnStateChange()](onstatechange-1.htm) method before the State has reached State.DataLoaded |

Methods and Properties
----------------------

|  |  |
| --- | --- |
| [Get()](tradinghoursget-1.htm) | Returns the Trading Hours object for the specified Trading Hours template name |
| [GetPreviousTradingDayEnd()](getprevioustradingdayend-1.htm) | Returns the end date and time of the previous trading session relative to the time passed in the methods parameters. |
| [Holidays](holidays-1.htm) | A collection of full holidays which are configured for a Trading Hours template |
| [Name](tradinghours_name-1.htm) | Indicates the name of the trading hours template applied to the Bars series object. |
| [PartialHolidays](partialholidays-1.htm) | A collection of partial holidays which are configured for a Trading Hours template |
| [Sessions](tradinghours_sessions-1.htm) | A collection of session definitions of the trading hours template. |
| [TimeZoneInfo](timezoneinfo-1.htm) | Indicates a time zone that is configured by a Trading Hour template |