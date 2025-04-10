



ActualTradingDayEndLocal

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](actualtradingdayendlocal.md) >>  **Navigation:**  [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [SessionIterator](sessioniterator.md) >  ActualTradingDayEndLocal | [Previous page](actualsessionend.md) [Return to chapter overview](sessioniterator.md) [Next page](actualtradingdayexchange.md) |

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