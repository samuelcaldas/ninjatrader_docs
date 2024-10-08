﻿
NinjaScript > Language Reference > Common > OnBarUpdate() > IsFirstTickOfBar

IsFirstTickOfBar

| << [Click to Display Table of Contents](isfirsttickofbar.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [OnBarUpdate()](onbarupdate-1.md) > IsFirstTickOfBar | [Previous page](isdataseriesrequired-1.md) [Return to chapter overview](onbarupdate-1.md) [Next page](isresetonnewtradingdays-1.md) |
| --- | --- |
## Definition
Indicates if the incoming tick is the first tick of a new bar. This property is only of value in scripts that run tick by tick which is when the [Calculate](calculate-1.md) property is set to Calculate.OnEachTick or Calculate.OnPriceChange.
 

| Warning: This property should NOT be accessed outside of the [OnBarUpdate()](onbarupdate-1.md) method. |
| --- |

| Note: If a bar type is set up to [remove the last bar](removelastbar-1.md) on a chart, IsFirstTickOfBar will automatically be set to True. |
| --- |
## 
## 
## Property Value
This property returns true if the incoming tick is the first tick of a new bar; otherwise, false.
 
## Syntax
IsFirstTickOfBar
 

| Tip: In NinjaTrader's event driven framework, bar closures are signaled by the tick that opens the next bar. The price of the last tick of a bar can be referenced by checking Close[1] on IsFirstTickOfBar. For volume and tick based bars, [Bars.TickCount](tickcount-1.md) and Volume[0] can be referenced to see if the number of ticks / volume meet the criteria to build a new bar. |
| --- |
## 
## 
## Examples

| ns |
| --- |
| // On a tick by tick strategy the only way you know when a bar is closed is when // the IsFirsTickOfBar is true. protected override void OnBarUpdate() {      // Only process entry signals on a bar by bar basis (not tick by tick)      if (IsFirstTickOfBar)      {          if (CCI(20)[1] < -250)                EnterLong();          return;      }        // Process exit signals tick by tick      if (CCI(20)[0] > 250)          ExitLong(); } |
