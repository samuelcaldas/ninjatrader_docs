


NinjaScript \> Language Reference \> Common \> SessionIterator \> ActualTradingDayExchange






















ActualTradingDayExchange







| \<\< [Click to Display Table of Contents](actualtradingdayexchange.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [SessionIterator](sessioniterator-1.md) \> ActualTradingDayExchange | [Previous page](actualtradingdayendlocal-1.md) [Return to chapter overview](sessioniterator-1.md) [Next page](calculatetradingday-1.md) |
| --- | --- |











## Definition


Obtains the date of a trading session defined by the exchange.


 




| Notes: 1\.In order to obtain historical ActualTradingDayExchange information, you must call [GetNextSession()](getnextsession-1.md) from a stored SessionIterator object.2\.The calculated value may differ from the current date as some trading sessions will begin before the actual calender date changes. For example, the "CME US Index Futures ETH" [actual session](accumulation_distribution_adl-1.md) started on 3/30/2015 at 5:00PM Central Time, however the actual exchange trading day would be considered 3/31/2015 12:00:00AM |
| --- |



## 


## 


## Property Value


A DateTime structure that represents the trading day.


 


## Syntax


\<sessionIterator\>.ActualTradingDayExchange


## 


## Example




| ns |
| --- |
| SessionIterator sessionIterator;   protected override void OnStateChange() {    if (State \=\= State.Historical)    {      sessionIterator \= new SessionIterator(Bars);    } }   protected override void OnBarUpdate() {    // on new bars session, find the next trading session    if (Bars.IsFirstBarOfSession)    {      // use the current bar time to calculate the next session      sessionIterator.GetNextSession(Time\[0], true);        Print("The current exchange trading day is " \+ sessionIterator.ActualTradingDayExchange);    } } |









