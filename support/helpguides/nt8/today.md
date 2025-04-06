



ToDay()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](today.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [Analytical](market_data.htm) >  ToDay() | [Previous page](ticksize.htm) [Return to chapter overview](market_data.htm) [Next page](totime.htm) |

Definition
----------

Calculates an integer value representing a date.

 

|  |
| --- |
| Note:   Integer representation of day is format as yyyyMMdd where January 8, 2015 would be 20150108. |

 

 

Method Return Value
-------------------

An int value representing date structure

Syntax 
ToDay(DateTime time)
----------------------------

Parameters
----------

|  |  |
| --- | --- |
| time | A DateTime structure to calculate Note:  See also the [Time](time.htm) property |

|  |
| --- |
| Tip:  NinjaScript uses the .NET [DateTime](http://msdn2.microsoft.com/en-us/library/system.datetime.aspx) structures which can be complicated for novice programmers. If you are familiar with C# you can directly use DateTime structure properties and methods for date and time comparisons otherwise use this method and the [ToTime()](totime.htm) method. |

Examples
--------

| ns |
| --- |
| protected override void OnBarUpdate()  {        // Compare the date of the current bar to September 15, 2014     if (ToDay(Time[0]) > 20140915)     {         // Do something           }  } |