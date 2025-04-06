



ActualSessionEnd

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\actualsessionend.md) >>  **Navigation:**  [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [SessionIterator](sessioniterator-1.md) >  ActualSessionEnd | [Previous page](actualsessionbegin-1.md) [Return to chapter overview](sessioniterator-1.md) [Next page](actualtradingdayendlocal-1.md) |

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