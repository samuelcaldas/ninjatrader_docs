



RemoveLastBar()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](removelastbar.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Bars Type](bars_type.htm) >  RemoveLastBar() | [Previous page](ondatapoint.htm) [Return to chapter overview](bars_type.htm) [Next page](setpropertyname2.htm) |

Definition
----------

Removes the last data point for the Bars Type.  There may be cases where your custom bar type may need to amend the last values added on a bar that has already closed.  Calling RemoveLastBar() will remove the last points for that bar type and allow you to call AddBar() with the updated values.

|  |
| --- |
| Notes: •In order to use this method, the [IsRemoveLastBarSupported](isremovelastbarsupported.htm) method must be true.    •RemoveLastBar() CANNOT be used with [TickReplay](tick_replay.htm) |

Syntax
------

RemoveLastBar(Bars bars)

Parameters
----------

|  |  |
| --- | --- |
| bars | The Bars object of your bars type |

Examples
--------

| ns |
| --- |
| RemoveLastBar(bars); |