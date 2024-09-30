
NinjaScript \> Language Reference \> Common \> Bars \> IsLastBarOfSession

IsLastBarOfSession

| \<\< [Click to Display Table of Contents](islastbarofsession.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Bars](bars-1.md) \> IsLastBarOfSession | [Previous page](isfirstbarofsessionbyindex-1.md) [Return to chapter overview](bars-1.md) [Next page](isresetonnewtradingday-1.md) |
| --- | --- |
## Definition
Indicates if the current bar processing is the last bar updated in a trading session.
 

| Notes:   - This property will always return false on non\-intraday bar periods (e.g., Day, Month, etc.)- When running Calculate.OnEachTick / OnPriceChange, this property will always return true on the most current real\-time bar since it is the last bar that is updating in the trading session.  If you need to find a bar which coincides with the session end time, please use the [SessionIterator.ActualSessionEnd](actualsessionend-1.md). |
| --- |

## Property Value
This property returns true if the bar is the last processed in a session; otherwise, false.  This property is read\-only.
 
## Syntax
Bars.IsLastBarOfSession
 
## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {    // Print the current bar number of the first bar processed for each session on a chart    if(Bars.IsLastBarOfSession)      Print(string.Format("Bar number {0} was the last bar processed of the session at {1}.", CurrentBar, Time\[0])); } |
