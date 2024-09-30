
NinjaScript \> Language Reference \> Strategy \> IsExitOnSessionCloseStrategy

IsExitOnSessionCloseStrategy

| \<\< [Click to Display Table of Contents](isexitonsessionclosestrategy.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> IsExitOnSessionCloseStrategy | [Previous page](isadoptaccountpositionaware-1.md) [Return to chapter overview](strategy-1.md) [Next page](isfilllimitontouch-1.md) |
| --- | --- |
## Definition
Determines if the strategy will cancel all strategy generated orders on all strategy instruments and close all open strategy positions at the close of ANY session for multi\-time frame/multi\-instrument strategies. This property can be set programatically in the [OnStateChange()](onstatechange-1.md) method or be driven by the UI at run time. See also "[ExitOnSessionCloseSeconds](exitonsessioncloseseconds-1.md)".
 
## Property Value
This property returns true if the strategy will exit on close; otherwise, false.  Default value is set to true.
 

| Warnings:   - This property should ONLY bet set from the [OnStateChange()](onstatechange-1.md) method during State.SetDefaults or State.Configure- On historical data, IsExitOnSessionCloseStrategy will cause positions to be exited at the close of the last bar of the session. If you are using a non time\-based Bar Type, such as Renko, and have "Break at EOD" set to False on the Data Series, this means that IsExitOnSessionCloseStrategy could trigger after the session close, since the last bar of the session can extend beyond the session close time in this scenario.- Even if you're backtesting with a historical [order fill resolution](orderfillresolution-1.md) set to be more granular than your base primary series, the ExitOnSessionCloseSeconds will still be tied to the primary higher timeframe series bar.  IsExitOnSessionCloseStrategy should not be used in combination with Daily Bars and High Order Fill Resolution since it will cause the position to close as the same time as the daily bar updates (at session close)- This property is designed to be only used on intraday strategies |
| --- |
## 
## 
## Syntax
IsExitOnSessionCloseStrategy
 
## 
## Examples

| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          // Triggers the exit on session close function 30 seconds prior to real\-time trading day end           IsExitOnSessionCloseStrategy \= true;          ExitOnSessionCloseSeconds \= 30;      } } |
