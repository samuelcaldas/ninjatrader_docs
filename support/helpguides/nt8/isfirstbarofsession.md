


NinjaScript \> Language Reference \> Common \> Bars \> IsFirstBarOfSession






















IsFirstBarOfSession







| \<\< [Click to Display Table of Contents](isfirstbarofsession.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Bars](bars.md) \> IsFirstBarOfSession | [Previous page](getvolume.md) [Return to chapter overview](bars.md) [Next page](isfirstbarofsessionbyindex.md) |
| --- | --- |











## Definition


Indicates if the current bar processing is the first bar updated in a trading session.


 




| Note:  This property always returns true on the very first bar processed (i.e., CurrentBar \=\= 0\).  The represented time of the bar will NOT necessarily be equal to the trading hours start time (e.g., if you request 50 1\-minute bars at 11:50:00 AM, the first bar processed of the session would be 11:00:00 AM).  Loading a data series based on "dates" (Days or custom range) ensures that the first bar processed matches hours defined by the session template. |
| --- |



 


 


## Property Value


This property returns true if the bar is the first processed in a session; otherwise, false.  This property is read\-only.


 




| Warning:   This property will always return false on non\-intraday bar periods (e.g., Day, Month, etc).  For checking for new non\-intraday bar updates, please see [IsFirstTickOfBar](isfirsttickofbar.md) |
| --- |



 


 


## Syntax
Bars.IsFirstBarOfSession


## 




| Tip:  For checking at a specified bar index, please see [IsFirstBarOfSessionByIndex()](isfirstbarofsessionbyindex.md) |
| --- |



 


 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {    // Print the current bar number of the first bar processed for each session on a chart    if (Bars.IsFirstBarOfSession)      Print(string.Format("Bar number {0} was the first bar processed of the session at {1}.", CurrentBar, Time\[0])); } |









