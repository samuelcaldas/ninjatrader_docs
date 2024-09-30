
NinjaScript \> Language Reference \> Bars Type \> RemoveLastBar()
RemoveLastBar()
| \<\< [Click to Display Table of Contents](removelastbar.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Bars Type](bars_type.md) \> RemoveLastBar() | [Previous page](ondatapoint.md) [Return to chapter overview](bars_type.md) [Next page](setpropertyname2.md) |
| --- | --- |
## Definition
Removes the last data point for the Bars Type.  There may be cases where your custom bar type may need to amend the last values added on a bar that has already closed.  Calling RemoveLastBar() will remove the last points for that bar type and allow you to call AddBar() with the updated values.
## 
| Notes:   - In order to use this method, the [IsRemoveLastBarSupported](isremovelastbarsupported.md) method must be true.  - RemoveLastBar() CANNOT be used with [TickReplay](tick_replay.md) |
| --- |

## Syntax
RemoveLastBar(Bars bars)
 
## Parameters
| bars | The Bars object of your bars type |
| --- | --- |

 
## 
## Examples
| ns |
| --- |
| RemoveLastBar(bars); |
