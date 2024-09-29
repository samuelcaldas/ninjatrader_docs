


NinjaScript \> Language Reference \> Common \> Bars \> TickCount






















TickCount







| \<\< [Click to Display Table of Contents](tickcount.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Bars](bars-1.md) \> TickCount | [Previous page](percentcomplete-1.md) [Return to chapter overview](bars-1.md) [Next page](tochartstring-1.md) |
| --- | --- |











## Definition


Returns the total number of ticks of the current bar processing.


 




| Note:  For historical usage, you must use Calculate.OnEachTick with [TickReplay](developing_for__tick_replay-1.md) enabled; otherwise a value of 1 will returned. |
| --- |



 


 


## Property Value


A long value that represents the total number of ticks of the current bar.


 


## Syntax


Bars.TickCount


## 


## Examples




| ns |
| --- |
| // Prints the tick count to the output window Print("The tick count of the current bar is " \+ Bars.TickCount.ToString()); |









