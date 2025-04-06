



ActualTradingDayExchange

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\actualtradingdayexchange.md) >>  **Navigation:**  [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [SessionIterator](sessioniterator-1.md) >  ActualTradingDayExchange | [Previous page](actualtradingdayendlocal-1.md) [Return to chapter overview](sessioniterator-1.md) [Next page](calculatetradingday-1.md) |

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