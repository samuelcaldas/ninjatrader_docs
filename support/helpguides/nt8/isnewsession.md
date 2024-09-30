
NinjaScript \> Language Reference \> Common \> SessionIterator \> IsNewSession()

IsNewSession()

| \<\< [Click to Display Table of Contents](isnewsession.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [SessionIterator](sessioniterator.md) \> IsNewSession() | [Previous page](isinsession.md) [Return to chapter overview](sessioniterator.md) [Next page](istradingdaydefined.md) |
| --- | --- |
## Definition
Indicates a specified time is greater than the [ActualSessionEnd](actualsessionend.md) property on the configured Trading Hours template.
 
## Property Value
A bool value when true indicates the specified time is later than ActualSessionEnd; otherwise false.

## Parameters

| time | The DateTime value used to compare |
| --- | --- |
| includesEndTimeStamp | A bool determining if a timestamp of \<n\>:00 should fall into the current session. (e.g., used for time based intraday series such as minute or second). |

## Syntax
\<SessionIterator\>.IsNewSession(DateTime time, bool includesEndTimeStamp)
 
## 
## Example

| ns |
| --- |
| bool takeTrades;   protected override void OnBarUpdate() {    // Switch a bool named takeTrades to false when IsNewSession() returns true.     if (Bars.SessionIterator.IsNewSession(DateTime.Now, true)) ;    {        Alert("EOS", Priority.Medium, String.Format("New session beginning. Waiting until {0} to begin trading again"), " ", 5, Brushes.Black, Brushes.White);        takeTrades \= false;    }      // Set the bool back to true on the first bar of the new session    if (Bars.IsFirstBarOfSession)        takeTrades \= true; } |
