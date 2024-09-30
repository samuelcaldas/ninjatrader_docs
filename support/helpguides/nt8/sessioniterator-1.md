
NinjaScript \> Language Reference \> Common \> SessionIterator
SessionIterator
| \<\< [Click to Display Table of Contents](sessioniterator.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> SessionIterator | [Previous page](state-1.md) [Return to chapter overview](common-1.md) [Next page](actualsessionbegin-1.md) |
| --- | --- |
## Definition
Allows you to traverse through various trading hours data elements which apply to a segment of bars.  
 
| Note:  Should you wish to obtain trading hours information for historical bar values, you need to construct and store your own session iterator object based of the desired bars series array. |
| --- |

## Parameters
| bars | The [Bars](bars-1.md) object used to create the SessionIterator |
| --- | --- |

## 
| Warning: The properties in this class should NOT be accessed within the [OnStateChange()](onstatechange-1.md) method before the State has reached State.DataLoaded |
| --- |

## Methods and Properties
| [ActualSessionBegin](actualsessionbegin-1.md) | Obtains the sessions start day and start time converted to the PC's local time zone |
| --- | --- |
| [ActualSessionEnd](actualsessionend-1.md) | Obtains the sessions end day and end time converted to the PC's local time zone |
| [ActualTradingDayEndLocal](actualtradingdayendlocal-1.md) | Returns the sessions End\-Of\-Day (EOD) in the local timezone |
| [ActualTradingDayExchange](actualtradingdayexchange-1.md) | Obtains the date of a session representing the trading date of the exchange |
| [CalculateTradingDay()](calculatetradingday-1.md) | Calculates the current trading date of a specified date |
| [GetNextSession()](getnextsession-1.md) | Calculates the next available session relative to a specified date |
| [GetTradingDay()](gettradingday-1.md) | Returns the actual trading date based on the exchange |
| [GetTradingDayBeginLocal()](gettradingdaybeginlocal-1.md) | Converts the trading day begin time from the exchange timezone to local time |
| [GetTradingDayEndLocal()](gettradingdayendlocal-1.md) | Converts the trading day end time from the exchange timezone to local time |
| [IsInSession()](isinsession-1.md) | Indicates if a specified date is within the bounds of the current session |
| [IsNewSession()](isnewsession-1.md) | Indicates if a specified time is greater than the actual session end of the current session |
| [IsTradingDayDefined()](istradingdaydefined-1.md) | Indicates if a trading day is defined for a specific date |

 
| Tip:  In order to calculate a session information for another multi\-instrument or multi\-time frame script, you can pass in the desired [BarsArray](barsarray-1.md) array value as the SessionIterator bars object. |
| --- |

## Examples
| ns |
| --- |
| private SessionIterator sessionIterator;   protected override void OnStateChange() {    if (State \=\= State.DataLoaded)    {      //stores the sessions once bars are ready, but before OnBarUpdate is called      sessionIterator \= new SessionIterator(Bars);    } }   protected override void OnBarUpdate() {    // on new bars session, find the next trading session    if (Bars.IsFirstBarOfSession)    {      Print("Calculating trading day for " \+ Time\[0]);      // use the current bar time to calculate the next session      sessionIterator.GetNextSession(Time\[0], true);        // store the desired session information      DateTime tradingDay   \= sessionIterator.ActualTradingDayExchange;      DateTime beginTime       \= sessionIterator.ActualSessionBegin;      DateTime endTime     \= sessionIterator.ActualSessionEnd;        Print(string.Format("The Current Trading Day {0} starts at {1} and ends at {2}",                          tradingDay.ToShortDateString(), beginTime, endTime));      // Output:      // Calculating trading day from 9/30/2015 4:01:00 PM      //The Current Trading Day 10/1/2015 starts at 9/30/2015 4:00:00 PM and ends at 10/1/2015 3:00:00 PM    } } |
