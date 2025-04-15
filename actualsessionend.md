



ActualSessionEnd

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](actualsessionend.md) >>  **Navigation:**  [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [SessionIterator](sessioniterator.md) >  ActualSessionEnd | [Previous page](actualsessionbegin.md) [Return to chapter overview](sessioniterator.md) [Next page](actualtradingdayendlocal.md) |

Definition
----------

Obtains the session's end date and end time converted to the user's configured Time Zone.

 

|  |
| --- |
| object. |

Property Value
--------------

A DateTime structure that represents end of a trading session.

Syntax
------

<sessionIterator>.ActualSessionEnd

Example
-------

|  |
| --- |
| SessionIteratorsessionIterator;     OnStateChange()  {  State.Historical)  {  SessionIterator(Bars);  }  }     OnBarUpdate()  {  // on new bars session, find the next trading session  (Bars.IsFirstBarOfSession)  {  // use the current bar time to calculate the next session  );     sessionIterator.ActualSessionEnd);  }  } |