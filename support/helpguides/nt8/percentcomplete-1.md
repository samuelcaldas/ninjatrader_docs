
NinjaScript \> Language Reference \> Common \> Bars \> PercentComplete

PercentComplete

| \<\< [Click to Display Table of Contents](percentcomplete.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Bars](bars-1.md) \> PercentComplete | [Previous page](istickreplay-1.md) [Return to chapter overview](bars-1.md) [Next page](tickcount-1.md) |
| --- | --- |
## Definition
Returns a value indicating the percentage complete of the real\-time bar processing.
 

| Notes:   1\.Since a historical bar is complete, values during State.Historical should be ignored (also the case with [TickReplay](developing_for__tick_replay-1.md) bars)2\.Some [BarsTypes](bars_type-1.md) may not be compatible with the PercentComplete property. In these cases, a value of 0 always returns (e.g.,  Range, Renko, Point \& Figure, Kagi, LineBreak, and some other 3rd party bars types) |
| --- |

## Property Value
A double value representing a percent e.g. a value of .5 indicates the bar was at 50%.  This property is read\-only.
 
## Syntax
Bars.PercentComplete
## 

| Tip:  If you are developing a custom BarsType, please use the [GetPercentComplete()](getpercentcomplete-1.md) method used to calculate the value returned by PercentComplete |
| --- |

## Examples

| ns |
| --- |
| protected override void OnBarUpdate() {    if(State \=\= State.Realtime)    {      Draw.TextFixed(this, "barstatus", Bars.PercentComplete.ToString("P2"), TextPosition.BottomRight);    } } |
