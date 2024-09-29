


NinjaScript \> Language Reference \> Common \> Analytical \> ToDay()






















ToDay()







| \<\< [Click to Display Table of Contents](today.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Analytical](market_data-1.md) \> ToDay() | [Previous page](ticksize-1.md) [Return to chapter overview](market_data-1.md) [Next page](totime-1.md) |
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




| time | A DateTime structure to calculate Note:  See also the [Time](time-1.md) property |
| --- | --- |



 


 




| Tip:  NinjaScript uses the .NET [DateTime](http://msdn2.microsoft.com/en-us/library/system.datetime.aspx) structures which can be complicated for novice programmers. If you are familiar with C\# you can directly use DateTime structure properties and methods for date and time comparisons otherwise use this method and the [ToTime()](totime-1.md) method. |
| --- |



## 


## 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {       // Compare the date of the current bar to September 15, 2014    if (ToDay(Time\[0]) \> 20140915)    {        // Do something          } } |









