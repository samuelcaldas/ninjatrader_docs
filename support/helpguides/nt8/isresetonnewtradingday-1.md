



IsResetOnNewTradingDay

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\isresetonnewtradingday.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [Bars](bars-1.htm) >  IsResetOnNewTradingDay | [Previous page](islastbarofsession-1.htm) [Return to chapter overview](bars-1.htm) [Next page](istickreplay-1.htm) |

Definition
----------

Indicates if the bars series is using the [Break EOD](break_at_eod-1.htm) data series property.

Property Value
--------------

This property returns true if the bars series should reset on a new trading day; otherwise, false.  This property is read-only.

Syntax 
Bars.IsResetOnNewTradingDay
-----------------------------------

|  |
| --- |
| Tip: This property can be helpful in determine on how to amend new bar data when working with a [BarType](bars_type-1.htm) |

Examples
--------

| ns |
| --- |
| protected override void OnDataPoint(Bars bars, double open, double high, double low, double close, DateTime time, long volume, bool isBar, double bid, double ask)  {     // create a session iterator to keep track of session related information     if(SessionIterator == null)       SessionIterator = new SessionIterator(bars);        // determine if the bars are in a new session     bool isNewSession = SessionIterator.IsNewSession(time, isBar);        if(isNewSession)       SessionIterator.GetNextSession(time, isBar);        // If bars are using "Break end of day", add a new bar for next session     if(bars.IsResetOnNewTradingDay && isNewSession))       AddBar(bars, open, high, low, close, time, volume);     else     {       // do something with existing bar values     }  } |