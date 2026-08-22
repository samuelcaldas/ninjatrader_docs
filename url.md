# Url

## Definition

Indicates the Url configured for the [Master Instrument properties](editing_instruments.md).

## Property Value

A string value representing the Url that is configured for the current master instrument.

## Syntax

Bars.Instrument.MasterInstrument.Url

## Examples

```csharp
protected override void OnBarUpdate()
{
    // Displays the master instrument's URL at the bottom right of the chart
    Draw.TextFixed(this, "tag1", "Instruments URL is " + Bars.Instrument.MasterInstrument.Url, TextPosition.BottomRight);
}
```
