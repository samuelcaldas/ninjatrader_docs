# TickSize

## Definition

Indicates the tick size configured for the [Master Instrument properties](editing_instruments.md).

## Property Value

A double value representing the tick size configured for the current master instrument.

## Syntax

Bars.Instrument.MasterInstrument.TickSize

## Examples

![Ns](../images/ns.png)

```csharp
protected override void OnBarUpdate()
{
    // Displays the master instrument's tick size at the bottom right of the chart
    Draw.TextFixed(this, "tag1", Bars.Instrument.MasterInstrument.TickSize.ToString(), TextPosition.BottomRight);
}
```