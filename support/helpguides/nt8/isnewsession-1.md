


NinjaScript \> Language Reference \> Common \> SessionIterator \> IsNewSession()






















IsNewSession()







| \<\< [Click to Display Table of Contents](isnewsession.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [SessionIterator](sessioniterator-1.md) \> IsNewSession() | [Previous page](isinsession-1.md) [Return to chapter overview](sessioniterator-1.md) [Next page](istradingdaydefined-1.md) |
| --- | --- |











## Definition


Indicates a specified time is greater than the [ActualSessionEnd](actualsessionend-1.md) property on the configured Trading Hours template.


 


## Property Value


A bool value when true indicates the specified time is later than ActualSessionEnd; otherwise false.


 


 


## Parameters




| time | The DateTime value used to compare |
| --- | --- |
| includesEndTimeStamp | A bool determining if a timestamp of \<n\>:00 should fall into the current session. (e.g., used for time based intraday series such as minute or second). |



 


 


## Syntax


\<SessionIterator\>.IsNewSession(DateTime time, bool includesEndTimeStamp)


 


## 


## Example




| ns |
| --- |
| bool takeTrades;   protected override void OnBarUpdate() {    // Switch a bool named takeTrades to false when IsNewSession() returns true.     if (Bars.SessionIterator.IsNewSession(DateTime.Now, true)) ;    {        Alert("EOS", Priority.Medium, String.Format("New session beginning. Waiting until {0} to begin trading again"), " ", 5, Brushes.Black, Brushes.White);        takeTrades \= false;    }      // Set the bool back to true on the first bar of the new session    if (Bars.IsFirstBarOfSession)        takeTrades \= true; } |









