
NinjaScript \> Language Reference \> Common \> SessionIterator \> CalculateTradingDay()

CalculateTradingDay()

| \<\< [Click to Display Table of Contents](calculatetradingday.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [SessionIterator](sessioniterator-1.md) \> CalculateTradingDay() | [Previous page](actualtradingdayexchange-1.md) [Return to chapter overview](sessioniterator-1.md) [Next page](getnextsession-1.md) |
| --- | --- |
## Definition
Calculates the trading date of the time value passed in as the timeLocal argument. This method may need to be used before you can accurately determine various session properties such as [ActualSessionBegin](actualsessionbegin-1.md) or [ActualTradingDayEndLocal](actualtradingdayendlocal-1.md), etc. CalculateTradingDay() also checks the local date/time against the exchange's current date/time to ensure that the script is in sync with the exchange's current day.
 

| Warning:  This method is resource intensive and should ONLY be reserved for situations when calculations would be limited to a few specific use cases. |
| --- |
 
## 
## Property Value
This method does not return a value.
 
## Parameters

| timeLocal | The DateTime value used to calculate the trading day. |
| --- | --- |
| includesEndTimeStamp | A bool determining if a timestamp of \<n\>:00 should fall into the current session. (e.g., used for time based intraday series such as minute or second). |
## 
 
## Syntax
\<sessionIterator\>.CalculateTradingDay(DateTime timeLocal, bool includesEndTimeStamp)
## 
## Example

| ns |
| --- |
| protected override void OnDataPoint(Bars bars, double open, double high, double low, double close, DateTime time, long volume, bool isBar, double bid, double ask) {    // build the bars type session iterator from the bars object provided    if (SessionIterator \=\= null)      SessionIterator \= new SessionIterator(bars);      // calculate the trading day of the time value provided    SessionIterator.CalculateTradingDay(time, false);      // add a new bar using the sessions exchanges date    AddBar(bars, open, high, low, close, SessionIterator.ActualTradingDayExchange, volume); } |
