
NinjaScript > Language Reference > Common > SessionIterator > ActualTradingDayEndLocal
ActualTradingDayEndLocal
| << [Click to Display Table of Contents](actualtradingdayendlocal.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [SessionIterator](sessioniterator.md) > ActualTradingDayEndLocal | [Previous page](actualsessionend.md) [Return to chapter overview](sessioniterator.md) [Next page](actualtradingdayexchange.md) |
| --- | --- |
## Definition
Returns the session's End-Of-Day (EOD) in the user's configured timezone.
 
| Note:  In order to obtain historical ActualTradingDayEndLocal information, you must call [GetNextSession()](getnextsession.md) from a stored SessionIterator object. |
| --- |
## 
## 
## Property Value
A DateTime structure that represents end of a trading day (EOD).
 
## Syntax
<sessionIterator>.ActualTradingDayEndLocal
## 
## Example
| ns |
| --- |
| SessionIterator sessionIterator;   protected override void OnStateChange() {    if (State == State.Historical)    {      sessionIterator = new SessionIterator(Bars);    } }   protected override void OnBarUpdate() {    // on new bars session, find the next trading session    if (Bars.IsFirstBarOfSession)    {      // use the current bar time to calculate the next session      sessionIterator.GetNextSession(Time[0], true);        Print("The current session end of day is " + sessionIterator.ActualTradingDayEndLocal);    } } |

