


NinjaScript \> Language Reference \> Common \> SessionIterator \> ActualTradingDayEndLocal






















ActualTradingDayEndLocal







| \<\< [Click to Display Table of Contents](actualtradingdayendlocal.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [SessionIterator](sessioniterator-1.md) \> ActualTradingDayEndLocal | [Previous page](actualsessionend-1.md) [Return to chapter overview](sessioniterator-1.md) [Next page](actualtradingdayexchange-1.md) |
| --- | --- |











## Definition


Returns the session's End\-Of\-Day (EOD) in the user's configured timezone.


 




| Note:  In order to obtain historical ActualTradingDayEndLocal information, you must call [GetNextSession()](getnextsession-1.md) from a stored SessionIterator object. |
| --- |



## 


## 


## Property Value


A DateTime structure that represents end of a trading day (EOD).


 


## Syntax


\<sessionIterator\>.ActualTradingDayEndLocal


## 


## Example




| ns |
| --- |
| SessionIterator sessionIterator;   protected override void OnStateChange() {    if (State \=\= State.Historical)    {      sessionIterator \= new SessionIterator(Bars);    } }   protected override void OnBarUpdate() {    // on new bars session, find the next trading session    if (Bars.IsFirstBarOfSession)    {      // use the current bar time to calculate the next session      sessionIterator.GetNextSession(Time\[0], true);        Print("The current session end of day is " \+ sessionIterator.ActualTradingDayEndLocal);    } } |









