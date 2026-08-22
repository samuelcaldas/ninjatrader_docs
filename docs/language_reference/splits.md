# Splits

## Definition

Indicates the Splits that have been configured for the [Master Instrument properties](editing_instruments.md) used in for stocks.

## Property Value

A collection of Splits configured for the current instrument.

Possible values are:

| Name / Option | Description |
| --- | --- |
| Date | A DateTime structure representing the date of the split |
| Factor | A double value representing the number of points the stock split |

## Syntax

Bars.Instrument.MasterInstrument.Splits

## Examples

```csharp
foreach (Split split in Bars.Instrument.MasterInstrument.Splits)
{
    Print(split.Date);
    Print(split.Factor);
}
```
