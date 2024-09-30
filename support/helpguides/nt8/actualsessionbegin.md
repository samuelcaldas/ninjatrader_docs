
NinjaScript > Language Reference > Common > SessionIterator > ActualSessionBegin

ActualSessionBegin
| << [Click to Display Table of Contents](actualsessionbegin.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [SessionIterator](sessioniterator.md) > ActualSessionBegin | [Previous page](sessioniterator.md) [Return to chapter overview](sessioniterator.md) [Next page](actualsessionend.md) |
| --- | --- |
## Definition
Obtains the sessions start date and start time converted to the user's configured Time Zone.
 
| Note:  In order to obtain historical ActualSessionBegin information, you must call [GetNextSession()](getnextsession.md) from a stored SessionIterator object. |
| --- |

## 
## 
## Property Value
A DateTime structure that represents beginning of a trading session.
 
## Syntax
<sessionIterator>.ActualSessionBegin
## 
## Example
| ns |
| --- |
| SessionIterator sessionIterator;   protected override void OnStateChange() {    if (State == State.Historical)    {      sessionIterator = new SessionIterator(Bars);    } }   protected override void OnBarUpdate() {    // on new bars session, find the next trading session    if (Bars.IsFirstBarOfSession)    {      // use the current bar time to calculate the next session      sessionIterator.GetNextSession(Time[0], true);        Print("The current session start time is " + sessionIterator.ActualSessionBegin);    } } |
