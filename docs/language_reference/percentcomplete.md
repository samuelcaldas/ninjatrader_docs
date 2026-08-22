# PercentComplete

## Definition

Returns a value indicating the percentage complete of the real-time bar processing.

> **Notes:** 1.Since a historical bar is complete, values during State.Historical should be ignored (also the case with [TickReplay](../ninjascript/developing_for__tick_replay.md) bars)  2.Some [BarsTypes](bars_type.md) may not be compatible with the PercentComplete property. In these cases, a value of 0 always returns (e.g.,  Range, Renko, Point & Figure, Kagi, LineBreak, and some other 3rd party bars types)

## Property Value

A double value representing a percent e.g. a value of .5 indicates the bar was at 50%.  This property is read-only.

## Syntax

`Bars.PercentComplete`

> **Tip:** If you are developing a custom BarsType, please use the [GetPercentComplete()](getpercentcomplete.md) method used to calculate the value returned by PercentComplete

## Examples

![Ns](../images/ns.png)

```csharp
protected override void OnBarUpdate()
{
    if(State == State.Realtime)
    {
        Draw.TextFixed(this, "barstatus", Bars.PercentComplete.ToString("P2"), TextPosition.BottomRight);
    }
}
```