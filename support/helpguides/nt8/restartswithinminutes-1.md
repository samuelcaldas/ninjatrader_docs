﻿
NinjaScript > Language Reference > Strategy > RestartsWithinMinutes
RestartsWithinMinutes
| << [Click to Display Table of Contents](restartswithinminutes.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Strategy](strategy-1.md) > RestartsWithinMinutes | [Previous page](realtimeerrorhandling-1.md) [Return to chapter overview](strategy-1.md) [Next page](setorderquantity-1.md) |
| --- | --- |
## Definition
Determines within how many minutes the strategy will attempt to restart.  The strategy will only restart off a reestablished connection when there have been fewer restart attempts than [NumberRestartAttempts](numberrestartattempts-1.md) in the last NumberRestartAttempts time span. The purpose of these settings is to stop the strategy should your connection be unstable and incapable of maintaining a consistent connected state.
 
## Property Value
An int value representing the maximum number of minutes in the time span in which restart attempts have to be less than NumberRestartAttempts for a strategy to be restarted when a connection is reestablished. Default value is set to 5.
 
## Syntax
RestartsWithinMinutes

## 
## Examples
| ns |
| --- |
| protected override void OnStateChange() {      if (State == State.SetDefaults)      {          /* Allow for restarting the strategy only if there were less restart attempts than           MaxRestartAttempts within the last 5 minutes */          RestartsWithinMinutes = 5;      } } |
