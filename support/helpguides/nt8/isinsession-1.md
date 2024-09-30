
NinjaScript \> Language Reference \> Common \> SessionIterator \> IsInSession()

IsInSession()

| \<\< [Click to Display Table of Contents](isinsession.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [SessionIterator](sessioniterator-1.md) \> IsInSession() | [Previous page](gettradingdayendlocal-1.md) [Return to chapter overview](sessioniterator-1.md) [Next page](isnewsession-1.md) |
| --- | --- |
## Definition
Indicates a specified date is within the bounds of the current session, according to the configured Trading Hours template.
 

| Note:  Additionally this method will internally trigger a [GetNextSession()](getnextsession-1.md) call to calculate the next available session relative to the "timeLocal" value used in the method's input. |
| --- |
 
## Property Value
A bool value when true indicates the specified time is within the current trading session; otherwise false.
 
## Parameters

| timeLocal | The DateTime value used to calculate the next trading day. |
| --- | --- |
| includesEndTimeStamp | A bool determining if a timestamp of \<n\>:00 should fall into the current session. (e.g., used for time based intraday series such as minute or second). |
| isIntraDay | A bool determining if IsInSession() considers the time of day (when true) or only the date (when false) |

## Syntax
\<SessionIterator\>.IsInSession(DateTime timeLocal, bool includesEndTimeStamp, bool isIntraDay)
 
## 
## Example

| ns |
| --- |
| private SessionIterator sessionIterator;   protected override void OnStateChange() {    if (State \=\= State.Historical)    {        //stores the sessions once bars are ready, but before OnBarUpdate is called        sessionIterator \= new SessionIterator(Bars);    } }   protected override void OnBarUpdate() {    // Only place an order if the time three hours from now will still be within the current session    if (sessionIterator.IsInSession(DateTime.Now.AddHours(3), true, true) /\* \&\& additional conditions here \*/)        EnterLongStopMarket(CurrentDayOHL().High\[0] \+ TickSize); } |
