
NinjaScript \> Language Reference \> Strategy \> IsWaitUntilFlat
IsWaitUntilFlat
| \<\< [Click to Display Table of Contents](iswaituntilflat.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> IsWaitUntilFlat | [Previous page](istradinghoursbreaklinevisible.md) [Return to chapter overview](strategy.md) [Next page](numberrestartattempts.md) |
| --- | --- |
## Definition
Indicates the strategy is currently waiting until a flat position is detected before submitting live orders. 
 
| Note: This property would only apply if the strategy [StartBehavior](startbehavior.md) was set to StartBehavior.WaitUntilFlat or StartBehavior.WaitUntilFlatSynchronizeAccount. |
| --- |

 
## Property Value
This property returns true if the strategy has detected it is either in a long or short position during [State.Transition](onstatechange.md); otherwise false.  Default value is set to false.
 
## Syntax
IsWaitUntilFlat
 
## 
## Examples
| ns |
| --- |
| // If a strategy is waiting for a flat position, return and print a message if (!IsWaitUntilFlat) {     Print("This strategy is currently waiting for a flat account position to begin placing trades");    return; } |
