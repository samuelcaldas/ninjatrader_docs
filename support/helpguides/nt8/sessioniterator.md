
NinjaScript > Language Reference > Common > SessionIterator

SessionIterator

| << [Click to Display Table of Contents](sessioniterator.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > SessionIterator | [Previous page](state.md) [Return to chapter overview](common.md) [Next page](actualsessionbegin.md) |
| --- | --- |
## Definition
Allows you to traverse through various trading hours data elements which apply to a segment of bars.  
 

| Note:  Should you wish to obtain trading hours information for historical bar values, you need to construct and store your own session iterator object based of the desired bars series array. |
| --- |

## Parameters

| bars | The [Bars](bars.md) object used to create the SessionIterator |
| --- | --- |
## 

| Warning: The properties in this class should NOT be accessed within the [OnStateChange()](onstatechange.md) method before the State has reached State.DataLoaded |
| --- |

## Methods and Properties

| [ActualSessionBegin](actualsessionbegin.md) | Obtains the sessions start day and start time converted to the PC's local time zone |
| --- | --- |
| [ActualSessionEnd](actualsessionend.md) | Obtains the sessions end day and end time converted to the PC's local time zone |
| [ActualTradingDayEndLocal](actualtradingdayendlocal.md) | Returns the sessions End-Of-Day (EOD) in the local timezone |
| [ActualTradingDayExchange](actualtradingdayexchange.md) | Obtains the date of a session representing the trading date of the exchange |
| [CalculateTradingDay()](calculatetradingday.md) | Calculates the current trading date of a specified date |
| [GetNextSession()](getnextsession.md) | Calculates the next available session relative to a specified date |
| [GetTradingDay()](gettradingday.md) | Returns the actual trading date based on the exchange |
| [GetTradingDayBeginLocal()](gettradingdaybeginlocal.md) | Converts the trading day begin time from the exchange timezone to local time |
| [GetTradingDayEndLocal()](gettradingdayendlocal.md) | Converts the trading day end time from the exchange timezone to local time |
| [IsInSession()](isinsession.md) | Indicates if a specified date is within the bounds of the current session |
| [IsNewSession()](isnewsession.md) | Indicates if a specified time is greater than the actual session end of the current session |
| [IsTradingDayDefined()](istradingdaydefined.md) | Indicates if a trading day is defined for a specific date |
 

| Tip:  In order to calculate a session information for another multi-instrument or multi-time frame script, you can pass in the desired [BarsArray](barsarray.md) array value as the SessionIterator bars object. |
| --- |

## Examples

| ns |
| --- |
| private SessionIterator sessionIterator;   protected override void OnStateChange() {    if (State == State.DataLoaded)    {      //stores the sessions once bars are ready, but before OnBarUpdate is called      sessionIterator = new SessionIterator(Bars);    } }   protected override void OnBarUpdate() {    // on new bars session, find the next trading session    if (Bars.IsFirstBarOfSession)    {      Print("Calculating trading day for " + Time[0]);      // use the current bar time to calculate the next session      sessionIterator.GetNextSession(Time[0], true);        // store the desired session information      DateTime tradingDay   = sessionIterator.ActualTradingDayExchange;      DateTime beginTime       = sessionIterator.ActualSessionBegin;      DateTime endTime     = sessionIterator.ActualSessionEnd;        Print(string.Format("The Current Trading Day {0} starts at {1} and ends at {2}",                          tradingDay.ToShortDateString(), beginTime, endTime));      // Output:      // Calculating trading day from 9/30/2015 4:01:00 PM      //The Current Trading Day 10/1/2015 starts at 9/30/2015 4:00:00 PM and ends at 10/1/2015 3:00:00 PM    } } |
