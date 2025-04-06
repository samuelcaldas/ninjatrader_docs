



ActualSessionBegin

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](actualsessionbegin.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [SessionIterator](sessioniterator.htm) >  ActualSessionBegin | [Previous page](sessioniterator.htm) [Return to chapter overview](sessioniterator.htm) [Next page](actualsessionend.htm) |

Definition
----------

Obtains the sessions start date and start time converted to the user's configured Time Zone.

 

|  |
| --- |
| SessionIterator object. |

Property Value
--------------

A DateTime structure that represents beginning of a trading session.

Syntax
------

<sessionIterator>.ActualSessionBegin

Example
-------

|  |
| --- |
| SessionIteratorsessionIterator;     OnStateChange()  {  State.Historical)  {  SessionIterator(Bars);  }  }     OnBarUpdate()  {  // on new bars session, find the next trading session  (Bars.IsFirstBarOfSession)  {  // use the current bar time to calculate the next session  );     sessionIterator.ActualSessionBegin);  }  } |