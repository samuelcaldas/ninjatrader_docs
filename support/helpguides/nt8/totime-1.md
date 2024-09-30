
NinjaScript \> Language Reference \> Common \> Analytical \> ToTime()
ToTime()
| \<\< [Click to Display Table of Contents](totime.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Analytical](market_data-1.md) \> ToTime() | [Previous page](today-1.md) [Return to chapter overview](market_data-1.md) [Next page](attributes-1.md) |
| --- | --- |
## Definition
Calculates an integer value representing a time.
 
| Note:  Integer representation of time is in the format Hmmss where 7:30 AM would be 73000 and 2:15:12 PM would be 141512\. |
| --- |

## Method Return Value
An int value representing a time structure
 
## Syntax
ToTime(DateTime time)
ToTime(int hour, int minute, int second)
 
## Parameters
| time | A DateTime structure to calculate Note:  See also the [Time](time-1.md) property |
| --- | --- |
| hour | An int value representing the hour used for the input |
| minute | An int value representing the minute used for the input |
| second | An int value representing the second used for the input |

| Tip:  NinjaScript uses the .NET DateTime structure which can be complicated for novice programmers. If you are familiar with C\# you can directly use DateTime structure properties and methods for date and time comparisons otherwise use this method and the [ToDay()](today-1.md) method. |
| --- |

## Examples
| ns |
| --- |
| // Only trade between 7:45 AM and 1:45 PM if (ToTime(Time\[0]) \>\= 74500 \&\& ToTime(Time\[0]) \<\= 134500) {      // Strategy logic goes here } |

 
## 
| ns |
| --- |
| //store start time as an int variable to be compared int startTime \= ToTime(9, 30, 00); // 93000   //only trade after 9:30AM if (ToTime(Time\[0]) \>\= startTime) {      // Strategy logic goes here } |
