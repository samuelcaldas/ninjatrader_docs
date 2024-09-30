
NinjaScript > Language Reference > Common > SessionIterator > GetTradingDayEndLocal()
GetTradingDayEndLocal()
| << [Click to Display Table of Contents](gettradingdayendlocal.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [SessionIterator](sessioniterator-1.md) > GetTradingDayEndLocal() | [Previous page](gettradingdaybeginlocal-1.md) [Return to chapter overview](sessioniterator-1.md) [Next page](isinsession-1.md) |
| --- | --- |
## Definition
Converts the trading day end time from the exchange timezone to local time, and returns a DateTime object in the local timezone. The [ActualTradingDayExchange](actualtradingdayexchange-1.md) property can be passed into GetTradingDayEndLocal() for a quick timezone conversion.
 
## Property Value
A DateTime object representing the exchange-based trading day end time converted to local time.
 
## Syntax
<SessionIterator>.GetTradingDayEndLocal(DateTime tradingDayExchange)
 
## Parameters
| tradingDayExchange | The DateTime value used to calculate the trading day. |
| --- | --- |

## 
## 
## Example
| ns | Code: |
| --- | --- |
| private SessionIterator sessionIterator;   protected override void OnStateChange() {    if (State == State.DataLoaded)    {      //stores the sessions once bars are ready, but before OnBarUpdate is called      sessionIterator = new SessionIterator(Bars);    } }   protected override void OnBarUpdate() {    // Only process strategy logic up until three hours prior to the end of the trading day at the exchange    if (Core.Globals.Now <= sessionIterator.GetTradingDayEndLocal(sessionIterator.ActualTradingDayExchange).AddHours(-3))    {        // Strategy logic here    } } | |
