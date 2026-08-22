# RemoveLastBar()

## Definition

Removes the last data point for the Bars Type.  There may be cases where your custom bar type may need to amend the last values added on a bar that has already closed.  Calling RemoveLastBar() will remove the last points for that bar type and allow you to call AddBar() with the updated values.

> **Notes:**
- In order to use this method, the [IsRemoveLastBarSupported](isremovelastbarsupported.md) method must be true.
- RemoveLastBar() CANNOT be used with [TickReplay](../operations/tick_replay.md)

## Syntax

RemoveLastBar(Bars bars)

## Parameters

| Name / Option | Description |
| --- | --- |
| bars | The Bars object of your bars type |

## Examples

![Ns](../images/ns.png)

```csharp
RemoveLastBar(bars);
```