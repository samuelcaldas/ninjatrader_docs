
NinjaScript > Language Reference > Bars Type > SessionIterator

SessionIterator
| << [Click to Display Table of Contents](barstype_sessioniterator.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Bars Type](bars_type-1.md) > SessionIterator | [Previous page](setpropertyname2-1.md) [Return to chapter overview](bars_type-1.md) [Next page](updatebar-1.md) |
| --- | --- |
## Definition
Provides trading session information to the bars type.  Must be built using the bars object.
 
## Property Value
A [SessionIterator](sessioniterator-1.md) object which is used to to calculate trading day/session information.
 
## Syntax
SessionIterator
 
## Examples
| ns |
| --- |
| protected override void OnDataPoint(Bars bars, double open, double high, double low, double close, DateTime time, long volume, bool isBar, double bid, double ask) {    // build a session iterator from the bars object being updated    if (SessionIterator == null)      SessionIterator = new SessionIterator(bars);      // check if we are in a new trading session based on the trading hours selected by the user    bool isNewSession = SessionIterator.IsNewSession(time, isBar);      // calculate the new trading day    if (isNewSession)      SessionIterator.CalculateTradingDay(time, isBar);      Print(SessionIterator.ActualTradingDayExchange);   } |
