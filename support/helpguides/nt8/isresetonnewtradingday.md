﻿
NinjaScript > Language Reference > Common > Bars > IsResetOnNewTradingDay

IsResetOnNewTradingDay

| << [Click to Display Table of Contents](isresetonnewtradingday.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Bars](bars.md) > IsResetOnNewTradingDay | [Previous page](islastbarofsession.md) [Return to chapter overview](bars.md) [Next page](istickreplay.md) |
| --- | --- |
## Definition
Indicates if the bars series is using the [Break EOD](break_at_eod.md) data series property.  
 
## Property Value
This property returns true if the bars series should reset on a new trading day; otherwise, false.  This property is read-only.
 
## Syntax
Bars.IsResetOnNewTradingDay
## 

| Tip: This property can be helpful in determine on how to amend new bar data when working with a [BarType](bars_type.md) |
| --- |
## 
## 
## Examples

| ns |
| --- |
| protected override void OnDataPoint(Bars bars, double open, double high, double low, double close, DateTime time, long volume, bool isBar, double bid, double ask) {    // create a session iterator to keep track of session related information    if(SessionIterator == null)      SessionIterator = new SessionIterator(bars);      // determine if the bars are in a new session    bool isNewSession = SessionIterator.IsNewSession(time, isBar);      if(isNewSession)      SessionIterator.GetNextSession(time, isBar);      // If bars are using "Break end of day", add a new bar for next session    if(bars.IsResetOnNewTradingDay && isNewSession))      AddBar(bars, open, high, low, close, time, volume);    else    {      // do something with existing bar values    } } |
