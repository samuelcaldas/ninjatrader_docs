# Dividends

## Definition

An collection of Dividends configured for the [Master Instrument properties](editing_instruments.md) used in for stocks.

## Property Value

A collection of Dividends configured for the current instrument.

Possible values are:

| Name / Option | Description |
| --- | --- |
| Amount | A double value representing the amount in dollars which was paid on the date of the dividend |
| Date | A DateTime structure representing the date of the dividend |

## Syntax

Bars.Instrument.MasterInstrument.Dividends

## Examples

```csharp
foreach(Dividend dividends in Bars.Instrument.MasterInstrument.Dividends)
{
    Print(dividends.Amount);
    Print(dividends.Date);
}
```