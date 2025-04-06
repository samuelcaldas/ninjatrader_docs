



ActualTradingDayEndLocal

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](actualtradingdayendlocal.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [SessionIterator](sessioniterator.htm) >  ActualTradingDayEndLocal | [Previous page](actualsessionend.htm) [Return to chapter overview](sessioniterator.htm) [Next page](actualtradingdayexchange.htm) |

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