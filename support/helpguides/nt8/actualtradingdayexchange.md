



ActualTradingDayExchange

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](actualtradingdayexchange.md) >>  **Navigation:**  [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [SessionIterator](sessioniterator.md) >  ActualTradingDayExchange | [Previous page](actualtradingdayendlocal.md) [Return to chapter overview](sessioniterator.md) [Next page](calculatetradingday.md) |

Definition
----------

Obtains the date of a trading session defined by the exchange.

 

|  |
| --- |
| Notes:  would be considered 3/31/2015 12:00:00AM |

Property Value
--------------

A DateTime structure that represents the trading day.

Syntax
------

<sessionIterator>.ActualTradingDayExchange

Example
-------

|  |
| --- |
| SessionIteratorsessionIterator;     OnStateChange()  {  State.Historical)  {  SessionIterator(Bars);  }  }     OnBarUpdate()  {  // on new bars session, find the next trading session  (Bars.IsFirstBarOfSession)  {  // use the current bar time to calculate the next session  );     sessionIterator.ActualTradingDayExchange);  }  } |