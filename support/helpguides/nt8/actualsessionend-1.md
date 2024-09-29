


NinjaScript \> Language Reference \> Common \> SessionIterator \> ActualSessionEnd






















ActualSessionEnd







| \<\< [Click to Display Table of Contents](actualsessionend.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [SessionIterator](sessioniterator-1.md) \> ActualSessionEnd | [Previous page](actualsessionbegin-1.md) [Return to chapter overview](sessioniterator-1.md) [Next page](actualtradingdayendlocal-1.md) |
| --- | --- |











## Definition


Obtains the session's end date and end time converted to the user's configured Time Zone.


 




| Note:  In order to obtain historical ActualSessionEnd information, you must call [GetNextSession()](getnextsession-1.md) from a stored SessionIterator object. |
| --- |



## 


## 


## Property Value


A DateTime structure that represents end of a trading session.


 


## Syntax


\<sessionIterator\>.ActualSessionEnd


## 


## Example




| ns |
| --- |
| SessionIterator sessionIterator;   protected override void OnStateChange() {    if (State \=\= State.Historical)    {      sessionIterator \= new SessionIterator(Bars);    } }   protected override void OnBarUpdate() {    // on new bars session, find the next trading session    if (Bars.IsFirstBarOfSession)    {      // use the current bar time to calculate the next session      sessionIterator.GetNextSession(Time\[0], true);        Print("The current session end time is " \+ sessionIterator.ActualSessionEnd);    } } |









