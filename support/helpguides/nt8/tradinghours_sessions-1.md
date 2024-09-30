
NinjaScript \> Language Reference \> Common \> TradingHours \> Sessions
Sessions

| \<\< [Click to Display Table of Contents](tradinghours_sessions.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [TradingHours](tradinghours-1.md) \> Sessions | [Previous page](partialholidays-1.md) [Return to chapter overview](tradinghours-1.md) [Next page](timezoneinfo-1.md) |
| --- | --- |

## Definition
A collection of session definitions of the configured Trading Hours template.  
 
## Available Properties
| BeginDay | A [DayOfWeek](https://msdn.microsoft.com/en-us/library/system.dayofweek(v=vs.90).aspx) value representing the begin day |
| --- | --- |
| BeginTime | An int value representing the begin time |
| EndDay | A [DayOfWeek](https://msdn.microsoft.com/en-us/library/system.dayofweek(v=vs.90).aspx) value representing the end day |
| EndTime | An int value representing the end time |
| TradingDay | A [DayOfWeek](https://msdn.microsoft.com/en-us/library/system.dayofweek(v=vs.90).aspx) value representing the trading day this session belongs to |

 
## Syntax
Bars.TradingHours.Sessions\[int idx]
## 
## 
| Tip:  Each index value will represent a new defined session for the Trading Hours template. For example, accessing Bars.TradingHours.Sessions\[0] would provide you with information for the first trading session configured in the Trading Hours template:   Bars.TradingHours.Sessions\[0].TradingDay \= DayOfWeek.Monday, Bars.TradingHours.Sessions\[1].TradingDay \= DayOfWeek.Tuesday, Bars.TradingHours.Sessions\[2].TradingDay \= DayOfWeek.Wednesday, etc. |
| --- |

## 
 
## Examples
| ns |
| --- |
| // Print details for all sessions in the Trading Hours template for (int i \= 0; i \< TradingHours.Sessions.Count; i\+\+) {    Print(String.Format("Session {0}: {1} at {2} to {3} at {4}", i, TradingHours.Sessions\[i].BeginDay, TradingHours.Sessions\[i].BeginTime,      TradingHours.Sessions\[i].EndDay, TradingHours.Sessions\[i].EndTime)); } |

