# TickCount

## Definition

Returns the total number of ticks of the current bar processing.

 

> **Note:** For historical usage, you must use Calculate.OnEachTick with [TickReplay](../ninjascript/developing_for__tick_replay.md) enabled; otherwise a value of 1 will returned.

## Property Value

A long value that represents the total number of ticks of the current bar.

## Syntax

Bars.TickCount

## Examples

```csharp
// Prints the tick count to the output window
Print("The tick count of the current bar is " + Bars.TickCount.ToString());
```
