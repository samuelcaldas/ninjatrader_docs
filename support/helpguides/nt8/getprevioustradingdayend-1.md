


NinjaScript \> Language Reference \> Common \> TradingHours \> GetPreviousTradingDayEnd()






















GetPreviousTradingDayEnd()







| \<\< [Click to Display Table of Contents](getprevioustradingdayend.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [TradingHours](tradinghours-1.md) \> GetPreviousTradingDayEnd() | [Previous page](tradinghoursget-1.md) [Return to chapter overview](tradinghours-1.md) [Next page](holidays-1.md) |
| --- | --- |











## Definition


Returns the end date and time of the previous trading session regarding the time passed in the methods parameters.


 


## Method Return Value


A DateTime structure representing the previous trading days end date and time


 


## Syntax


GetPreviousTradingDayEnd(DateTime timeLocal)


 




| Warning:  This method is resource intensive and should ONLY be reserved for situations when calculations would be limited to a few specific use cases.  For example, calling this method for each bar in the OnBarUpdate() method would NOT be recommended. |
| --- |



 


## Parameters




| timeLocal | An DateTime structure which is used to calculate the current trading day |
| --- | --- |



## 


 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {    if (Bars.IsFirstBarOfSession)    {      DateTime previousEndDate \= TradingHours.GetPreviousTradingDayEnd(Time\[0]);        Print(string.Format("The current bars date is {0} \- the previous trading session ended on {1}", Time\[0], previousEndDate));    }    //Output:  The current bars date is 2/18/2015 12:35:00 PM \- the previous trading session ended on 2/17/2015 3:15:00 PM } |









