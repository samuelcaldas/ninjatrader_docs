



ActualTradingDayEndLocal

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\actualtradingdayendlocal.md) >>  **Navigation:**  [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [SessionIterator](sessioniterator-1.md) >  ActualTradingDayEndLocal | [Previous page](actualsessionend-1.md) [Return to chapter overview](sessioniterator-1.md) [Next page](actualtradingdayexchange-1.md) |

Definition
----------

Returns the session's End-Of-Day (EOD) in the user's configured timezone.

 

|  |
| --- |
| object. |

Property Value
--------------

A DateTime structure that represents end of a trading day (EOD).

Syntax
------

<sessionIterator>.ActualTradingDayEndLocal

Example
-------

|  |
| --- |
| SessionIteratorsessionIterator;     OnStateChange()  {  State.Historical)  {  SessionIterator(Bars);  }  }     OnBarUpdate()  {  // on new bars session, find the next trading session  (Bars.IsFirstBarOfSession)  {  // use the current bar time to calculate the next session  );     sessionIterator.ActualTradingDayEndLocal);  }  } |