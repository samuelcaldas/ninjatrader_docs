
NinjaScript \> Language Reference \> Common \> Bars \> TickCount
TickCount
| \<\< [Click to Display Table of Contents](tickcount.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Bars](bars.md) \> TickCount | [Previous page](percentcomplete.md) [Return to chapter overview](bars.md) [Next page](tochartstring.md) |
| --- | --- |
## Definition
Returns the total number of ticks of the current bar processing.
 
| Note:  For historical usage, you must use Calculate.OnEachTick with [TickReplay](developing_for__tick_replay.md) enabled; otherwise a value of 1 will returned. |
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
