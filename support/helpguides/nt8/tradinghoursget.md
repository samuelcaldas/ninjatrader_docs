
NinjaScript > Language Reference > Common > TradingHours > Get
Get()

| << [Click to Display Table of Contents](tradinghoursget.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [TradingHours](tradinghours.md) > Get() | [Previous page](tradinghours.md) [Return to chapter overview](tradinghours.md) [Next page](getprevioustradingdayend.md) |
| --- | --- |

## Definition
Returns the [TradingHours](tradinghours.md) object for the specified Trading Hours template name, such as "CME US Index Futures RTH"  

 
## Method Return Value
A [TradingHours](tradinghours.md) object representing the specified Trading Hours template name.
 
## Syntax
Get(string name)
 
## Parameters
| name | The name of the desired TradingHours object to return |
| --- | --- |

 
## 
## Examples
| ns |
| --- |
| // Loop through and print all regular holidays in the found TradingHours object foreach(KeyValuePair<DateTime, string> holiday in TradingHours.Get("CME US Index Futures RTH").Holidays) {    Print(String.Format("Date: {0} Description: {1}", holiday.Key, holiday.Value)); } |

