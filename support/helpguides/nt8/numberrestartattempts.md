


NinjaScript \> Language Reference \> Strategy \> NumberRestartAttempts






















NumberRestartAttempts







| \<\< [Click to Display Table of Contents](numberrestartattempts.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> NumberRestartAttempts | [Previous page](iswaituntilflat.md) [Return to chapter overview](strategy.md) [Next page](onaccountitemupdate.md) |
| --- | --- |











## Definition


Determines the maximum number of restart attempts allowed within the last x minutes defined in [RestartsWithinMinutes](restartswithinminutes.md) when the strategy experiences a connection loss. If restart attempts exceeds this property within a time span shorter than or equal to RestartsWithinMinutes, then the strategy will be stopped and no further attempts will occur. The purpose of these settings is to stop the strategy should your connection be unstable and incapable of maintaining a consistent connected state.


 


## Property Value


An int value represents the maximum number of restart attempts.  Default value is set to 4\.


 


## Syntax


NumberRestartAttempts


 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          // Only allow the strategy to restart 4 times within the MaxRestartMinutes time span          // If disconnected more than 4 times within that time span, stop the strategy and do not          // attempt any further restarts.          NumberRestartAttempts \= 4;      } } |









