
NinjaScript \> Language Reference \> Common \> Analytical \> ToDay()
ToDay()
| \<\< [Click to Display Table of Contents](today.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Analytical](market_data.md) \> ToDay() | [Previous page](ticksize.md) [Return to chapter overview](market_data.md) [Next page](totime.md) |
| --- | --- |
## Definition
Calculates an integer value representing a date.
 
| Note:   Integer representation of day is format as yyyyMMdd where January 8, 2015 would be 20150108\. |
| --- |

## Method Return Value
An int value representing date structure
 
## Syntax
ToDay(DateTime time)
 
## Parameters
| time | A DateTime structure to calculate Note:  See also the [Time](time.md) property |
| --- | --- |

| Tip:  NinjaScript uses the .NET [DateTime](http://msdn2.microsoft.com/en-us/library/system.datetime.aspx) structures which can be complicated for novice programmers. If you are familiar with C\# you can directly use DateTime structure properties and methods for date and time comparisons otherwise use this method and the [ToTime()](totime.md) method. |
| --- |

## 
## 
## Examples
| ns |
| --- |
| protected override void OnBarUpdate() {       // Compare the date of the current bar to September 15, 2014    if (ToDay(Time\[0]) \> 20140915)    {        // Do something          } } |
