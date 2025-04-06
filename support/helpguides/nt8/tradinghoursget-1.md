



Get()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\tradinghoursget.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [TradingHours](tradinghours-1.htm) >  Get() | [Previous page](tradinghours-1.htm) [Return to chapter overview](tradinghours-1.htm) [Next page](getprevioustradingdayend-1.htm) |

Definition
----------

Returns the [TradingHours](tradinghours-1.htm) object for the specified Trading Hours template name, such as "CME US Index Futures RTH"

Method Return Value
-------------------

A [TradingHours](tradinghours-1.htm) object representing the specified Trading Hours template name.

Syntax
------

Get(string name)

 

Parameters
----------

|  |  |
| --- | --- |
| name | The name of the desired TradingHours object to return |

Examples
--------

| ns |
| --- |
| // Loop through and print all regular holidays in the found TradingHours object  foreach(KeyValuePair<DateTime, string> holiday in TradingHours.Get("CME US Index Futures RTH").Holidays)  {     Print(String.Format("Date: {0} Description: {1}", holiday.Key, holiday.Value));  } |