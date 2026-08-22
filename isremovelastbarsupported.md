# IsRemoveLastBarSupported

## Definition

Determines if the bars type can use the [RemoveLastBar()](removelastbar.md) method when true, otherwise an exception will be thrown. Bar Types which use remove last bar concepts CANNOT be used with [Tick Replay](tick_replay.md), and as a result Tick Replay will be disabled on the UI when IsRemoveLastBarSupported is set to true.

> **Note:** This property is read-only, but may be overridden in a custom bar type.

## Syntax

IsRemoveLastBarSupported

## Property value

A bool determining if the BarsType can remove the last; default value is false.

## Examples

```csharp
// allows RemoveLastBar() to be called
public override bool IsRemoveLastBarSupported { get { return true; } }
```
